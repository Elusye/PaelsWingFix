using HarmonyLib;
using MegaCrit.Sts2.Core.Modding;

namespace PaelsWingFix;

[ModInitializer(nameof(Init))]
public static class Entry
{
    public static void Init() =>
        new Harmony("PaelsWingFix").CreateClassProcessor(typeof(PaelsWingDuplicateAlternativePatch)).Patch();
}
