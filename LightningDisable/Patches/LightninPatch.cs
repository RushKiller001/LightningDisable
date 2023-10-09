using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace LightningDisable.Patches
{
    [HarmonyPatch(typeof(LightningManager))]
    [HarmonyPatch("DoLightningStrike", MethodType.Normal)]
    internal class LightninPatch
    {
        private static void Prefix(LightningManager __instance)
        {
            __instance.enabled = false;
            __instance.StopCoroutine("LightningEffectRunner");
        }
    }
    [HarmonyPatch(typeof(LightningManager))]
    [HarmonyPatch("Start", MethodType.Normal)]
    internal class LightninPatch2
    {
        private static void Prefix(LightningManager __instance)
        {
            __instance.enabled = false;
            __instance.StopCoroutine("LightningEffectRunner");
        }
    }
}
