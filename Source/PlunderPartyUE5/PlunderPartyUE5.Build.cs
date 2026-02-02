// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class PlunderPartyUE5 : ModuleRules
{
	public PlunderPartyUE5(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"NavigationSystem",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"Niagara",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"PlunderPartyUE5",
			"PlunderPartyUE5/Variant_Strategy",
			"PlunderPartyUE5/Variant_Strategy/UI",
			"PlunderPartyUE5/Variant_TwinStick",
			"PlunderPartyUE5/Variant_TwinStick/AI",
			"PlunderPartyUE5/Variant_TwinStick/Gameplay",
			"PlunderPartyUE5/Variant_TwinStick/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
