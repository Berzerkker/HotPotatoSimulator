

using UnrealBuildTool;
using System.Collections.Generic;

public class HotPotatoSimulatorTarget : TargetRules
{
	public HotPotatoSimulatorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "HotPotatoSimulator" } );
	}
}
