using Exiled.API.Features;
using HarmonyLib;
using Mirror;

namespace AntiPacketDOS
{
    public static class HarmonyPatchs
    {
        [HarmonyPatch(typeof(SkyboxHubert), nameof(SkyboxHubert.SerializeSyncVars))]
        internal static class NetManagerNativeReceiveFrom
        {
            private static bool Prefix(NetworkWriter writer, bool forceAll)
            {
                writer.WriteBool(true);
                return false;
            }
        }
    }
}