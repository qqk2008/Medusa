// Copyright (c) 2015 fjz13. All rights reserved.
// Use of this source code is governed by a MIT-style
// license that can be found in the LICENSE file.
#pragma once
#include "Medusa.h"
USING_MEDUSA;

class HelloWorldGame:public IGame
{
	MEDUSA_DECLARE_GAME();
public:
	HelloWorldGame();
	virtual ~HelloWorldGame();

	virtual bool Initialize();
	virtual bool Uninitialize();

	virtual bool Start();
private:

};
