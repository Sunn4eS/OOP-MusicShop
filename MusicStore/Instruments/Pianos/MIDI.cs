using System.Diagnostics.Metrics;

namespace MusicStore.Instruments.Pianos;

public class MIDI : Piano
{
    public uint ModeCount { get; set; }

    public MIDI(string band, string model, uint price, ConditionTypes conditionTypes, uint keyCount, uint modeCount) : base(band, model, price, conditionTypes, keyCount)
    {
        ModeCount = modeCount;   
    }
    public MIDI(){}
    public override string ToString()
    {
        return base.ToString() + "; " + $"Count of Modes: {ModeCount}";
    }
    public override Panel Visualize()
    {
        var table = base.Visualize();
        ((PictureBox)table.Controls[0]).Image = Image.FromFile(Condition!.Type == ConditionTypes.FactoryNew ? "../../../Instruments/Images/FactoryNewMP.png" : Condition.Type == ConditionTypes.Used ? "../../../Instruments/Images/UsedMP.png" : "../../../Instruments/Images/DamagedMP.png");
        return table;
    }
}