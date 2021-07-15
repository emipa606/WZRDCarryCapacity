using UnityEngine;
using Verse;

namespace WzrdCarry
{
    // Token: 0x02000003 RID: 3
    public class WzrdCarrySettings : ModSettings
    {
        // Token: 0x04000002 RID: 2
        public int carryCapacity = 150;

        // Token: 0x04000003 RID: 3
        public int transportPodCapacity = 300;

        // Token: 0x06000006 RID: 6 RVA: 0x00002159 File Offset: 0x00000359
        public override void ExposeData()
        {
            base.ExposeData();
            Scribe_Values.Look(ref carryCapacity, "carryCapacity", 300, true);
            Scribe_Values.Look(ref transportPodCapacity, "transportPodCapacity", 150, true);
        }

        // Token: 0x06000007 RID: 7 RVA: 0x00002194 File Offset: 0x00000394
        public void Draw(Rect inRect)
        {
            var text = carryCapacity.ToString();
            var text2 = transportPodCapacity.ToString();
            var listing_Standard = new Listing_Standard(GameFont.Small)
            {
                ColumnWidth = inRect.width
            };
            listing_Standard.Begin(inRect);
            listing_Standard.TextFieldNumericLabeled("Pawn Carrying Capacity", ref carryCapacity, ref text);
            listing_Standard.TextFieldNumericLabeled("Transport Pod Capacity", ref transportPodCapacity, ref text2);
            listing_Standard.End();
            Write();
        }
    }
}