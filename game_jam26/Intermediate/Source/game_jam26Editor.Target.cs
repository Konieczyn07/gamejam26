using UnrealBuildTool;

public class game_jam26EditorTarget : TargetRules
{
	public game_jam26EditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("game_jam26");
	}
}
