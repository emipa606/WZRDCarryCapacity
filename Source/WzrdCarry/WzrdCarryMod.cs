using System;
using System.Linq;
using Mlie;
using RimWorld;
using UnityEngine;
using Verse;

namespace WzrdCarry;

public class WzrdCarryMod : Mod
{
    public static WzrdCarrySettings settings;
    public static string currentVersion;

    public WzrdCarryMod(ModContentPack content) : base(content)
    {
        Log.Message($"[WzrdCarry] - Init @ {DateTime.Now}");
        settings = GetSettings<WzrdCarrySettings>();
        LongEventHandler.QueueLongEvent(Go, "WzrdCarry_Init", false, null);
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
        Go();
    }

    private void Go()
    {
        var named = DefDatabase<ThingDef>.GetNamed("TransportPod");
        if (named.comps.Single(properties =>
                properties is CompProperties_Transporter) is CompProperties_Transporter compProperties_Transporter)
        {
            compProperties_Transporter.massCapacity = settings.transportPodCapacity;
        }

        var named2 = DefDatabase<StatDef>.GetNamed("CarryingCapacity");
        named2.defaultBaseValue = settings.carryCapacity;
    }
}