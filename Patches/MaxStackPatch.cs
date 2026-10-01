using HarmonyLib;
using Items.Model;

namespace ExpandedStacks.Patches
{
    [HarmonyPatch(typeof(ItemSettingsList), "ResetDict")]
    public static class MaxStackPatch
    {
        private static void Postfix(ItemSettings[] ___items)
        {
            foreach (ItemSettings itemSettings in ___items)
            {
                itemSettings.maxStackSize = 255;
            }
        }
    }
}