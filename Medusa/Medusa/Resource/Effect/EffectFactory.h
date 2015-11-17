// Copyright (c) 2015 fjz13. All rights reserved.
// Use of this source code is governed by a MIT-style
// license that can be found in the LICENSE file.
#pragma once
#include "Core/String/StringRef.h"
#include "Core/Pattern/Singleton.h"
#include "Resource/BaseResourceFactory.h"
#include "Resource/Effect/IEffect.h"
MEDUSA_BEGIN;

class EffectFactory :public Singleton<EffectFactory>, public BaseResourceFactory<IEffect>
{
	friend class Singleton<EffectFactory>;
public:
	EffectFactory();
	~EffectFactory();
public:
	virtual bool Initialize();
	virtual bool Uninitialize();
public:
	IEffect* CreateEmpty(const FileIdRef& fileId, ResourceShareType shareType = ResourceShareType::Share);
	IEffect* CreateFromFile(const FileIdRef& fileId, ResourceShareType shareType = ResourceShareType::Share);

	IEffect* CreateSinglePassDefault(const FileIdRef& fileId, ResourceShareType shareType = ResourceShareType::Share);
	IEffect* CreateSinglePass(const FileIdRef& fileId, const FileIdRef& passFileId, ResourceShareType shareType = ResourceShareType::Share);
	IEffect* CreateSinglePass(const FileIdRef& fileId, IRenderPass* renderPass, ResourceShareType shareType = ResourceShareType::Share);

	IEffect* CreateMultiplePasses(const FileIdRef& fileId, const List<FileIdRef>& renderPasses, ResourceShareType shareType = ResourceShareType::Share);
	IEffect* CreateMultiplePasses(const FileIdRef& fileId, List<IRenderPass*>& renderPasses, ResourceShareType shareType = ResourceShareType::Share);

};

MEDUSA_END;