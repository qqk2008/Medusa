// Copyright (c) 2015 fjz13. All rights reserved.
// Use of this source code is governed by a MIT-style
// license that can be found in the LICENSE file.
#pragma  once
#include "Graphics/State/IRenderState.h"
#include "Core/Geometry/Rect2.h"


MEDUSA_BEGIN;

class ScissorRenderState:public IRenderState
{
	MEDUSA_DECLARE_RTTI;

public:
	ScissorRenderState(const Rect2F& scissorBox = Rect2F::Zero, bool isScissorEnabled = false);
	virtual ~ScissorRenderState();
	virtual void Apply()const override;

	virtual ScissorRenderState* Clone()const override;
	virtual bool Equals(const IRenderState& state)const override;
	virtual RenderStateType Type()const override {return GetTypeIdStatic();}
	static RenderStateType GetTypeIdStatic(){return RenderStateType::Scissor;}

	bool IsEnabled() const { return mEnabled; }
	bool Enable(bool val);

	const Rect2F& ScissorBox() const { return mScissorBox; }
	bool SetScissorBox(const Rect2F& val);

	void Tansform(const Matrix& matrix);

	static ScissorRenderState* Current();
	virtual intp HashCode() const override;

protected:
	Rect2F mScissorBox;	// in window coordinates
	bool mEnabled=false;	//default: false

};


MEDUSA_END;