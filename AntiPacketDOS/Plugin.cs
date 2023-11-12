using Exiled.API.Features;
using HarmonyLib;
using System;

namespace AntiPacketDOS
{
    public class Plugin : Plugin<Config>
    {
        public override string Prefix => "OnlySkyboxHubert";
        public override string Name => "OnlySkyboxHubert";
        public override string Author => "Rysik5318";
        public override Version Version => new Version(1, 0, 0);
        internal Harmony harmony;

        public override void OnEnabled()
        {
            harmony = new Harmony($"OnlySkyboxHubert - {DateTime.Now}");
            harmony.PatchAll();
            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            harmony.UnpatchAll();
            base.OnDisabled();
        }
    }
}
