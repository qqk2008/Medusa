// Copyright (c) 2015 fjz13. All rights reserved.
// Use of this source code is governed by a MIT-style
// license that can be found in the LICENSE file.
#pragma once
#include "Core/String/StringRef.h"
#include "Core/Pattern/Singleton.h"
#include "Graphics/GraphicsTypes.h"
#include "Resource/BaseResourceFactory.h"
#include "Resource/Material/IMaterial.h"
#include "Core/Collection/SortedDictionary.h"

MEDUSA_BEGIN;

class MaterialFactory :public Singleton<MaterialFactory>, public BaseResourceFactory<IMaterial>
{
	friend class Singleton<MaterialFactory>;
public:
	MaterialFactory();
	~MaterialFactory();
public:
	virtual StringRef Name()const override { return "MaterialFactory"; }

	virtual bool Initialize();
	virtual bool Uninitialize();
public:
	Share<IMaterial> CreateSingleTexture(const FileIdRef& textureFileId,ResourceShareType shareType = ResourceShareType::Share);
	Share<IMaterial> CreateSingleTexture(const Share<ITexture>& texture, ResourceShareType shareType = ResourceShareType::Share);

	Share<IMaterial> CreateCustom(const FileIdRef& fileId, const Share<ITexture>& texture, const Share<IEffect>& effect, GraphicsDrawMode drawMode, ResourceShareType shareType = ResourceShareType::Share);

	Share<IMaterial> CreateEmpty(const FileIdRef& fileId, ResourceShareType shareType = ResourceShareType::Share);
	Share<IMaterial> CreateShape(const FileIdRef& fileId, ResourceShareType shareType = ResourceShareType::Share);

	bool CreateTextures(SortedDictionary<uint, Share<IMaterial>>& outMaterials, const StringRef& textureNamePattern);

};

MEDUSA_END;