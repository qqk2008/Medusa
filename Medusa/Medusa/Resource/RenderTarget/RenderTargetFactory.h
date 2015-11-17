// Copyright (c) 2015 fjz13. All rights reserved.
// Use of this source code is governed by a MIT-style
// license that can be found in the LICENSE file.
#pragma once
#include "Core/String/StringRef.h"
#include "Core/Pattern/Singleton.h"
#include "Resource/BaseResourceFactory.h"
#include "Resource/RenderTarget/IRenderTarget.h"

MEDUSA_BEGIN;

class RenderTargetFactory:public Singleton<RenderTargetFactory>,public BaseResourceFactory<IRenderTarget>
{
	friend class Singleton<RenderTargetFactory>;
public:
	RenderTargetFactory();
	~RenderTargetFactory();
public:
	virtual bool Initialize();
	virtual bool Uninitialize();
	virtual void Clear();
public:
	void ResetToDefault();

	IRenderTarget* Default() const { return mDefault; }

	void SetCurrent(const FileIdRef& fileId);
	IRenderTarget* Current() const { return mCurrent; }
	void SetCurrent(IRenderTarget* val) { mCurrent = val; }
	void ResetCurrentToDefault(){mCurrent=(IRenderTarget*)mDefault;}

	CustomRenderTarget* CreateCustom(const FileIdRef& fileId,bool setCurrent=true,ResourceShareType shareType = ResourceShareType::Share);
	void Resize(const Size2F& newSize);

private:
	IRenderTarget* mCurrent;
	IRenderTarget* mDefault;
	const static StringRef mDefaultRenderTargetName;
};

MEDUSA_END;