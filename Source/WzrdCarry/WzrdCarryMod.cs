using System.Linq;
using Mlie;
using RimWorld;
using UnityEngine;
using Verse;

namespace WzrdCarry;

public class WzrdCarryMod : Mod
{
    private static WzrdCarrySettings settings;
    public static string currentVersion;

    public WzrdCarryMod(ModContentPack content) : base(content)
    {
        settings = GetSettings<WzrdCarrySettings>();
        LongEventHandler.QueueLongEvent(go, "WzrdCarry_Init", false, null);
        currentVersion =
            VersionFromManifest.GetVersionFromModMetaData(content.ModMetaData);
    }

    public override string SettingsCategory()
    {
        return "[WZRD] Carry Capacity";
    }

    public override void DoSettingsWindowContents(Rect inRect)
    {
        settings.Draw(inRect);
        go();
    }

    private static void go()
    {
        var named = DefDatabase<ThingDef>.GetNamed("TransportPod");
        if (named.comps.Single(properties =>
                properties is CompProperties_Transporter) is CompProperties_Transporter compProperties_Transporter)
        {
            compProperties_Transporter.massCapacity = settings.TransportPodCapacity;
        }

        var named2 = DefDatabase<StatDef>.GetNamed("CarryingCapacity");
        named2.defaultBaseValue = settings.CarryCapacity;
    }
}