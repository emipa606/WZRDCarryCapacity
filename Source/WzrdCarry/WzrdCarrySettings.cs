using UnityEngine;
using Verse;

namespace WzrdCarry;

public class WzrdCarrySettings : ModSettings
{
    public int carryCapacity = 150;

    public int transportPodCapacity = 300;

    public override void ExposeData()
    {
        base.ExposeData();
        Scribe_Values.Look(ref carryCapacity, "carryCapacity", 300, true);
        Scribe_Values.Look(ref transportPodCapacity, "transportPodCapacity", 150, true);
    }

    public void Draw(Rect inRect)
    {
        var text = carryCapacity.ToString();
        var text2 = transportPodCapacity.ToString();
        var listing_Standard = new Listing_Standard(GameFont.Small)
        {
            ColumnWidth = inRect.width
        };
        listing_Standard.Begin(inRect);
        listing_Standard.TextFieldNumericLabeled("WZRD.CarryCapacity".Translate(), ref carryCapacity, ref text);
        listing_Standard.TextFieldNumericLabeled("WZRD.TransportCapacity".Translate(), ref transportPodCapacity,
            ref text2);
        if (WzrdCarryMod.currentVersion != null)
        {
            listing_Standard.Gap();
            GUI.contentColor = Color.gray;
            listing_Standard.Label("WZRD.CurrentModVersion".Translate(WzrdCarryMod.currentVersion));
            GUI.contentColor = Color.white;
        }

        listing_Standard.End();
        Write();
    }
}