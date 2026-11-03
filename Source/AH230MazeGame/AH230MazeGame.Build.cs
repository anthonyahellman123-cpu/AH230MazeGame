// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class AH230MazeGame : ModuleRules
{
	public AH230MazeGame(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"AH230MazeGame",
			"AH230MazeGame/Variant_Platforming",
			"AH230MazeGame/Variant_Platforming/Animation",
			"AH230MazeGame/Variant_Combat",
			"AH230MazeGame/Variant_Combat/AI",
			"AH230MazeGame/Variant_Combat/Animation",
			"AH230MazeGame/Variant_Combat/Gameplay",
			"AH230MazeGame/Variant_Combat/Interfaces",
			"AH230MazeGame/Variant_Combat/UI",
			"AH230MazeGame/Variant_SideScrolling",
			"AH230MazeGame/Variant_SideScrolling/AI",
			"AH230MazeGame/Variant_SideScrolling/Gameplay",
			"AH230MazeGame/Variant_SideScrolling/Interfaces",
			"AH230MazeGame/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
