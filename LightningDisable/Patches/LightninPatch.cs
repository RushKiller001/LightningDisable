using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace LightningDisable.Patches
{
    [HarmonyPatch(typeof(LightningManager))]
    [HarmonyPatch("DoLightningStrike", MethodType.Normal)]
    internal class LightninPatch
    {
        private static bool Prefix(LightningManager __instance)
        {
            __instance.enabled = false;
            __instance.StopCoroutine("LightningEffectRunner");
            Component.Destroy(__instance);
            return false;
        }
    }
    [HarmonyPatch(typeof(LightningManager))]
    [HarmonyPatch("Start", MethodType.Normal)]
    internal class LightninPatch2
    {
        private static bool Prefix(LightningManager __instance)
        {
            __instance.enabled = false;
            __instance.StopCoroutine("LightningEffectRunner");
            Component.Destroy(__instance);
            return false;
        }
    }
}
