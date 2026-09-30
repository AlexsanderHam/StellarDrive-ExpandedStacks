using MelonLoader;
using HarmonyLib;
using Items.Model;

[assembly: MelonInfo(typeof(ExpandedStacks.ExpandedStacksMod), "Expanded Stacks", "1.0.0", "AlexsanderHam", null)]
[assembly: MelonGame("CuriousOwlGames", "StellarDrive")]

namespace ExpandedStacks
{
    public class ExpandedStacksMod : MelonMod
    {
    }

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