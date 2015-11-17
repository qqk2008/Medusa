// Copyright (c) 2015 fjz13. All rights reserved.
// Use of this source code is governed by a MIT-style
// license that can be found in the LICENSE file.
#include "MedusaPreCompiled.h"
#include "FntTextMesh.h"
#include "Graphics/Buffer/VertexGraphicsBuffer.h"
#include "Graphics/Buffer/IndexGraphicsBuffer.h"
#include "Graphics/Buffer/TexCoordGraphicsBuffer.h"
#include "Graphics/Buffer/ColorGraphicsBuffer.h"
#include "Core/Geometry/Quad.h"
#include "Core/Geometry/Matrix.h"
#include "Resource/Font/FontChar.h"
#include "Resource/Font/IFont.h"
#include "Rendering/RenderingContext.h"
#include "Rendering/RenderingStatics.h"
#include "Resource/Effect/Pass/Program/BaseProgramRenderPass.h"
#include "Resource/Effect/Shader/Parameter/ShaderAttribute.h"
#include "Resource/ResourceNames.h"
#include "Core/Log/Log.h"
#include "Node/Sprite/Sprite.h"

MEDUSA_BEGIN;


FntTextMesh::FntTextMesh(IEffect* effect/*=nullptr*/, IMaterial* material/*=nullptr*/, bool isStatic/*=false*/)
	:BaseFontMesh(effect, material, isStatic),
	mVertexTexcoordBuffer(GraphicsBufferType::Array, GraphicsBufferUsage::DynamicDraw, GraphicsDataType::Float, 0)
{
	if (mIsStatic)
	{
		mVertexTexcoordBuffer.SetUsageType(GraphicsBufferUsage::StaticDraw);
		mIndexBuffer.SetUsageType(GraphicsBufferUsage::StaticDraw);
	}
	else
	{
		mVertexTexcoordBuffer.SetUsageType(GraphicsBufferUsage::DynamicDraw);
		mIndexBuffer.SetUsageType(GraphicsBufferUsage::DynamicDraw);
	}
}


FntTextMesh::~FntTextMesh(void)
{
}


void FntTextMesh::Clear()
{
	mCharIndex = 0;
	OnAllComponentChanged();

	
}

INode* FntTextMesh::CreateCloneInstance()const
{
	Sprite* sprite = new Sprite();
	//sprite->GetMesh()->CopyFrom(*this);
	return sprite;
}

bool FntTextMesh::CopyFrom(const FntTextMesh& val)
{
	IMesh::CopyFrom(val);

	return false;
}

void FntTextMesh::ReserveMesh(uint charCount)
{
	mCharCount = charCount;
	size_t outOriginalCount;
	bool isChanged = false;

	if (mVertexTexcoordBuffer.ReserveData(mCharCount, outOriginalCount))
	{
		OnVertexChanged();
		OnTexcoordChanged();

		isChanged = true;
	}

	mPositions.ReserveSize(mCharCount);

	mChars.ReserveSize(mCharCount);

	if (mIndexBuffer.ReserveData(mCharCount * 6, outOriginalCount))
	{
		OnIndexChanged();
		isChanged = true;

	}

	mCharIndex = 0;

	if (isChanged)
	{
		
	}

}

void FntTextMesh::ShrinkMesh()
{
	if (mCharIndex < mCharCount)
	{
		mVertexTexcoordBuffer.ForceSetCount(mCharIndex);
		mPositions.ForceSetCount(mCharIndex);
		mChars.ForceSetCount(mCharIndex);
		mIndexBuffer.ForceSetCount(mCharIndex * 6);
		mCharCount = mCharIndex;

		OnVertexChanged();
		OnTexcoordChanged();
		OnIndexChanged();

	}
}


void FntTextMesh::AddFontChar(const IFont& font, const FontChar& fontChar, const Point3F& origin)
{
	//Notice that mCharIndex maybe bigger than mCharCount

	ListGraphicsBuffer<FontCharQuad>::ListType& items = mVertexTexcoordBuffer.MutableData();
	if (mCharIndex >= items.Count())
	{
		uint originalIndex = mCharIndex;
		ReserveMesh(mCharCount + 1);
		mCharIndex = originalIndex;
	}

	FontCharQuad& quad = items[mCharIndex];
    bool isVertexChanged = true;
    bool isCharChanged=true;
    if (mCharCount>=mChars.Count())
    {
        //new char
        mChars.Add(fontChar.Id);
        mPositions.Add(origin);
    }
    else
    {
        Point3F& oldOrigin = mPositions[mCharIndex];
        wchar_t& oldChar = mChars[mCharIndex];
        isCharChanged = oldChar != fontChar.Id;
        if (!isCharChanged)
        {
            isVertexChanged = oldOrigin != origin;
        }
        
        oldChar=fontChar.Id;
        oldOrigin=origin;
    }
    
	
	++mCharIndex;

	if (isCharChanged)
	{
		quad.LeftBottom.TexCoord = fontChar.TextureCoords[0];
		quad.RightBottom.TexCoord = fontChar.TextureCoords[1];
		quad.RightTop.TexCoord = fontChar.TextureCoords[2];
		quad.LeftTop.TexCoord = fontChar.TextureCoords[3];
        
		isVertexChanged = true;
		OnTexcoordChanged();
	}
	
	if (isVertexChanged)
	{
		Point3F pos = origin;
		pos.X += (float)fontChar.HBearing.X;
		//pos.Y+=(float)(font.GetDescender()-((int)fontChar.TextureRect.Size.Height-(int)fontChar.HBearing.Y));
		pos.Y += (float)(-((int)fontChar.TextureRect.Size.Height - (int)fontChar.HBearing.Y));

		quad.LeftBottom.Vertex = pos;

		pos.X += fontChar.TextureRect.Size.Width;
		quad.RightBottom.Vertex = pos;

		pos.Y += fontChar.TextureRect.Size.Height;
		quad.RightTop.Vertex = pos;

		pos = quad.LeftBottom.Vertex;
		pos.Y += fontChar.TextureRect.Size.Height;
		quad.LeftTop.Vertex = pos;

		mVertexTexcoordBuffer.SetSingleDirtyIndex(mCharIndex - 1);

		OnVertexChanged();

	}

}


void FntTextMesh::Apply()
{
	ShrinkMesh();

	size_t stride = sizeof(FontCharVertex);
	BaseProgramRenderPass* pass = RenderingContext::Instance().ProgramRenderPass();
	ShaderAttribute* vertices = pass->GetAttributeByIndex(ShaderAttributeIndex::VertexArray);
	if (vertices != nullptr)
	{
		mVertexTexcoordBuffer.Apply();
		size_t vertexOffset = offsetof(FontCharVertex, Vertex);

		vertices->Invalidate();
		vertices->SetPointer(3, GraphicsDataType::Float, false, (uint)stride, (const void*)vertexOffset);

	}

	ShaderAttribute* texCoords = pass->GetAttributeByIndex(ShaderAttributeIndex::TexCoordArray);
	if (texCoords != nullptr)
	{
		size_t texcoordOffset = offsetof(FontCharVertex, TexCoord);
		//size_t texcoordStride=sizeof(Point3F);

		texCoords->Invalidate();
		texCoords->SetPointer(2, GraphicsDataType::Float, false, (uint)stride, (const void*)texcoordOffset);
	}

	mIndexBuffer.Apply();

}

void FntTextMesh::Restore()
{
	mIndexBuffer.Restore();
	BaseProgramRenderPass* pass = RenderingContext::Instance().ProgramRenderPass();

	ShaderAttribute* vertices = pass->GetAttributeByIndex(ShaderAttributeIndex::VertexArray);
	if (vertices != nullptr)
	{
		vertices->EnableArray(false);
		mVertexTexcoordBuffer.Restore();
	}

	ShaderAttribute* texCoords = pass->GetAttributeByIndex(ShaderAttributeIndex::TexCoordArray);
	if (texCoords != nullptr)
	{
		texCoords->EnableArray(false);
	}
}


void FntTextMesh::Draw(IRenderQueue& renderQueue, RenderingFlags renderingFlags/*=RenderingFlags::None*/)
{
	mIndexBuffer.DrawElements();

	RenderingStatics::Instance().CountOriginalAndBatchDraw();
	RenderingStatics::Instance().CountVertexCount(VertexCount());
	RenderingStatics::Instance().CountTriangleCount(IndexCount() / 3);
	RenderingStatics::Instance().CountDrawMode(mDrawMode);

}

void FntTextMesh::AddToVertexBufferObject(VertexGraphicsBuffer& bufferObject, size_t vertexIndex, const Matrix& matrix) const
{
	RETURN_IF_EMPTY(mVertexTexcoordBuffer);
	bufferObject.ReserveSize(vertexIndex, VertexCount());

	size_t quadCount = mVertexTexcoordBuffer.Count();
	const ListGraphicsBuffer<FontCharQuad>::ListType& quads = mVertexTexcoordBuffer.Data();

	Point3F pos;
	FOR_EACH_SIZE(i, quadCount)
	{
		const FontCharQuad& quad = quads[i];
		uintp j = i * 4;
		pos = matrix.Transform(quad.LeftBottom.Vertex);
		bufferObject.AppendOrUpdateData(vertexIndex + j++, pos);

		pos = matrix.Transform(quad.RightBottom.Vertex);
		bufferObject.AppendOrUpdateData(vertexIndex + j++, pos);

		pos = matrix.Transform(quad.RightTop.Vertex);
		bufferObject.AppendOrUpdateData(vertexIndex + j++, pos);

		pos = matrix.Transform(quad.LeftTop.Vertex);
		bufferObject.AppendOrUpdateData(vertexIndex + j, pos);
	}

}

void FntTextMesh::AddToTexCoordBufferObject(TexCoordGraphicsBuffer& bufferObject, size_t vertexIndex) const
{
	size_t quadCount = mVertexTexcoordBuffer.Count();
	const ListGraphicsBuffer<FontCharQuad>::ListType& quads = mVertexTexcoordBuffer.Data();

	FOR_EACH_SIZE(i, quadCount)
	{
		const FontCharQuad& quad = quads[i];
		uintp j = i * 4;
		bufferObject.AppendOrUpdateData(vertexIndex + j++, quad.LeftBottom.TexCoord);
		bufferObject.AppendOrUpdateData(vertexIndex + j++, quad.RightBottom.TexCoord);
		bufferObject.AppendOrUpdateData(vertexIndex + j++, quad.RightTop.TexCoord);
		bufferObject.AppendOrUpdateData(vertexIndex + j, quad.LeftTop.TexCoord);
	}
}

void FntTextMesh::AddToIndexBufferObject(IndexGraphicsBuffer& bufferObject, size_t vertexIndex, size_t indexIndex) const
{
	size_t indexCount = mIndexBuffer.Count();
	const QuadIndexGraphicsBuffer::ListType& indices = mIndexBuffer.Data();
	FOR_EACH_SIZE(i, indexCount)
	{
		QuadIndexGraphicsBuffer::ItemType curIndex = indices[i];
		bufferObject.AppendOrUpdateData(indexIndex + i, (QuadIndexGraphicsBuffer::ItemType)(vertexIndex + curIndex));
	}

}
void FntTextMesh::AddToColorBufferObject(ColorGraphicsBuffer& bufferObject, size_t vertexIndex, const Color4F& parentColor/*=Color4F::White*/) const
{
	bufferObject.SetDataRange(vertexIndex, parentColor,VertexCount());
}



Point2F FntTextMesh::GetCharPosition(uint charIndex) const
{
	if (mCharCount <= 0)
	{
		return Point2F::Zero;
	}

	charIndex = Math::Min(charIndex, mCharCount - 1);
	const FontCharQuad& quad = mVertexTexcoordBuffer.Data()[charIndex];
	return quad.LeftBottom.Vertex.To2D();
}

Point2F FntTextMesh::GetCursorPosition(uint charIndex) const
{
	if (mCharCount <= 0)
	{
		return Point2F::Zero;
	}

	charIndex = Math::Min(charIndex, mCharCount - 1);
	const FontCharQuad& quad = mVertexTexcoordBuffer.Data()[charIndex];
	return quad.RightBottom.Vertex.To2D();
}

uint FntTextMesh::FindCharIndex(const Point2F& touchPosition, Point2F& outCharPosition) const
{
	return Math::UIntMaxValue;
}

void FntTextMesh::SetIsStatic(bool val)
{
	RETURN_IF_EQUAL(mIsStatic, val);
	if (mIsStatic)
	{
		mVertexTexcoordBuffer.SetUsageType(GraphicsBufferUsage::StaticDraw);
		mIndexBuffer.SetUsageType(GraphicsBufferUsage::StaticDraw);
	}
	else
	{
		mVertexTexcoordBuffer.SetUsageType(GraphicsBufferUsage::DynamicDraw);
		mIndexBuffer.SetUsageType(GraphicsBufferUsage::DynamicDraw);
	}
}


MEDUSA_END;