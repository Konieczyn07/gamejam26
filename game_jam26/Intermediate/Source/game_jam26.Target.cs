using UnrealBuildTool;

public class game_jam26Target : TargetRules
{
	public game_jam26Target(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("game_jam26");
	}
}
