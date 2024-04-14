// 注释此代码以防止在加入SaveOurShip2Experimental后导致生成问题，会产生什么影响需要进行具体的测试才可以知晓

/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;
using RimWorld;
using Verse;
using System.Reflection;

namespace Planets_Code.Patches.SaveOurShip
{
	[HarmonyPatch(MethodType.Normal)]
	public static class WorldSwitchUtility_SwitchToNewWorld
	{
		private static ModMethodData modMethodData = new ModMethodData(
				packageId: "kentington.saveourship2",
				typeName: "SaveOurShip2.WorldSwitchUtility",
				methodName: "SwitchToNewWorld");

		[HarmonyPrepare]
		public static bool Prepare()
		{
			return modMethodData.ModIsLoaded();
		}

		[HarmonyTargetMethod]
		public static MethodBase TargetMethod()
		{
			return modMethodData.GetMethodIfLoaded();
		}

		[HarmonyTranspiler]
		public static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
		{
			var page_CreateWorldParams_ctor = AccessTools.Constructor(typeof(Page_CreateWorldParams));
			var planets_CreateWorldParams_ctor = AccessTools.Constructor(typeof(Planets_CreateWorldParams));

			return Transpilers.MethodReplacer(instructions, from: page_CreateWorldParams_ctor, to: planets_CreateWorldParams_ctor);
		}
	}
}
*/