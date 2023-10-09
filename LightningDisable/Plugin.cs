using BepInEx;
using System;
using UnityEngine;
using Utilla;

namespace LightningDisable
{
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class Plugin : BaseUnityPlugin
    {
        void Awake()
        {HarmonyPatches.ApplyHarmonyPatches();}
    }
}
