// Copyright (c) 2015 fjz13. All rights reserved.
// Use of this source code is governed by a MIT-style
// license that can be found in the LICENSE file.
#include "MedusaPreCompiled.h"
#include "Rendering/State/StateRenderGroup.h"
#include "Rendering/RenderingContext.h"
#include "Rendering/RenderingStatics.h"
#include "Graphics/State/Tree/RenderStateTreeLeafNode.h"
#include "Rendering/Batch/IRenderBatch.h"

MEDUSA_BEGIN;


StateRenderGroup::StateRenderGroup()
	:mStateNode(nullptr)
{
}


StateRenderGroup::~StateRenderGroup()
{
	
}

bool StateRenderGroup::Initialize()
{
	return true;
}

bool StateRenderGroup::Uninitialize()
{
	mRenderBatches.Clear();	//no need to recycle as it's owned outside
	SAFE_RELEASE(mStateNode);

	return true;
}

void StateRenderGroup::SetStateNode(RenderStateTreeLeafNode* val)
{
	SAFE_ASSIGN_REF(mStateNode, val);
}

bool StateRenderGroup::Add(IRenderBatch* batch)
{
	mRenderBatches.Add(batch);
	return true;
}

void StateRenderGroup::Draw(IRenderQueue& renderQueue, RenderingFlags renderingFlags/*=RenderingFlags::None*/)
{
	RenderingContext::Instance().ApplyState(mStateNode);
	FOR_EACH_COLLECTION(i, mRenderBatches)
	{
		IRenderBatch* batch = *i;
		RenderingContext::Instance().ApplyBatch(batch);
		RenderingContext::Instance().ValidateBeforeDraw();
		batch->Draw(renderQueue,renderingFlags);
		RenderingContext::Instance().RestoreBatch();

	}

	RenderingContext::Instance().RestoreState();
}


void StateRenderGroup::Print(HeapString& ioStr, uint level)
{
	ioStr.Append('\t', level);

	FOR_EACH_COLLECTION(i, mRenderBatches)
	{
		IRenderBatch* batch = *i;
		batch->Print(ioStr, level + 1);
	}
}


MEDUSA_END;