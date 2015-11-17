// Copyright (c) 2015 fjz13. All rights reserved.
// Use of this source code is governed by a MIT-style
// license that can be found in the LICENSE file.
#include "MedusaPreCompiled.h"
#include "ParticleSystem.h"

MEDUSA_BEGIN;

ParticleSystem::ParticleSystem(StringRef name/*=StringRef::Empty*/):INode(name)
{
}


ParticleSystem::~ParticleSystem(void)
{
}

bool ParticleSystem::Initialize()
{
	return true;
}


MEDUSA_END;
