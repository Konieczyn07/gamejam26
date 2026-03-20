using UnrealBuildTool;

public class game_jam26ClientTarget : TargetRules
{
	public game_jam26ClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("game_jam26");
	}
}
