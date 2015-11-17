// Copyright (c) 2015 fjz13. All rights reserved.
// Use of this source code is governed by a MIT-style
// license that can be found in the LICENSE file.
#pragma  once

#include "MedusaCorePreDeclares.h"
#include "Core/Pattern/Delegate.h"


MEDUSA_BEGIN;
class StaticConstructor
{
public:
	StaticConstructor(const Delegate<void()>& callback)
	{
		callback();
	}

	StaticConstructor(Delegate<void()>&& callback)
	{
		callback();
	}
};

#define MEDUSA_DECLARE_STATIC_CONSTRUCTOR() private:const static StaticConstructor mStaticConstructor;
#define MEDUSA_IMPLEMENT_STATIC_CONSTRUCTOR(className,callback) const StaticConstructor className::mStaticConstructor(callback);

MEDUSA_END;