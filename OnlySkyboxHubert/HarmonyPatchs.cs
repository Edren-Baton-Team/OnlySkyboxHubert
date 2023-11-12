using Exiled.API.Features;
using HarmonyLib;
using Mirror;

namespace OnlySkyboxHubert
{
    public static class HarmonyPatchs
    {
        [HarmonyPatch(typeof(SkyboxHubert), nameof(SkyboxHubert.SerializeSyncVars))]
        internal static class SkyboxHubertSerializeSyncVars
        {
            private static bool Prefix(NetworkWriter writer, bool forceAll)
            {
                writer.WriteBool(true);
                return false;
            }
        }
    }
}
