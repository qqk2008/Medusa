// Copyright (c) 2015 fjz13. All rights reserved.
// Use of this source code is governed by a MIT-style
// license that can be found in the LICENSE file.
#include "TestPreCompiled.h"
#include "AtlasSpriteLayer.h"


AtlasSpriteLayer::AtlasSpriteLayer(StringRef name/*=StringRef::Empty*/, const IEventArg& e/*=IEventArg::Empty*/) :BaseCaseLayer(name, e)
{
}

AtlasSpriteLayer::~AtlasSpriteLayer(void)
{
}

bool AtlasSpriteLayer::Initialize()
{
	RETURN_FALSE_IF_FALSE(BaseCaseLayer::Initialize());

	TextureAtlasFactory::Instance().Create("spineboy.atlas", TextureAtlasFileFormat::Spine, 1, ResourceShareType::ShareAndCache);
	Sprite* sprite = NodeFactory::Instance().CreateSpriteFromAtlasRegion("torso", "spineboy.atlas");
	sprite->SetDock(DockPoint::MiddleCenter);
	sprite->SetAnchor(0.5f,0.5f);
	AddChild(sprite);

	return true;
}




MEDUSA_IMPLEMENT_LAYER(AtlasSpriteLayer, BaseCaseLayer, StringRef::Empty);

