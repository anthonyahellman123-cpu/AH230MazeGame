// Copyright Epic Games, Inc. All Rights Reserved.

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/GameModeBase.h"
#include "AH230MazeGameGameMode.generated.h"

/**
 *  Simple GameMode for a third person game
 */
UCLASS(abstract)
class AAH230MazeGameGameMode : public AGameModeBase
{
	GENERATED_BODY()

public:
	
	/** Constructor */
	AAH230MazeGameGameMode();
};



