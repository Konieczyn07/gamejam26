using UnrealBuildTool;

public class game_jam26ServerTarget : TargetRules
{
	public game_jam26ServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("game_jam26");
	}
}
