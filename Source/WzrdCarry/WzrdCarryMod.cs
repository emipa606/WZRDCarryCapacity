using System;
using System.Linq;
using RimWorld;
using UnityEngine;
using Verse;

namespace WzrdCarry
{
    // Token: 0x02000002 RID: 2
    public class WzrdCarryMod : Mod
    {
        // Token: 0x04000001 RID: 1
        public static WzrdCarrySettings settings;

        // Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
        public WzrdCarryMod(ModContentPack content) : base(content)
        {
            Log.Message("[WzrdCarry] - Init @ " + DateTime.Now);
            settings = GetSettings<WzrdCarrySettings>();
            LongEventHandler.QueueLongEvent(Go, "WzrdCarry_Init", false, null);
        }

        // Token: 0x06000002 RID: 2 RVA: 0x000020A8 File Offset: 0x000002A8
        public override string SettingsCategory()
        {
            return "[WZRD] Carry Capacity";
        }

        // Token: 0x06000003 RID: 3 RVA: 0x000020BF File Offset: 0x000002BF
        public override void DoSettingsWindowContents(Rect inRect)
        {
            settings.Draw(inRect);
            Go();
        }

        // Token: 0x06000004 RID: 4 RVA: 0x000020D8 File Offset: 0x000002D8
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
}