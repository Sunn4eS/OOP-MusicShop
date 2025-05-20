using System.Runtime.Serialization;

namespace MusicStore.Instruments.Pianos;
[DataContract]
public class Grand : Piano
{
    [DataMember]
    public uint PedalCount { get; set; }
    public Grand(string band, string model, uint price, ConditionTypes conditionTypes, uint keyCount, uint pedalCount) : base(band, model, price, conditionTypes, keyCount)
    { 
        PedalCount = pedalCount;
    }

    public override string ToString()
    {
        return base.ToString() + "; " + $"Count Of Pedals: {PedalCount}";
    }
    public override Panel Visualize()
    {
        var table = base.Visualize();
        ((PictureBox)table.Controls[0]).Image = Image.FromFile(Condition!.Type == ConditionTypes.FactoryNew ? "../../../Instruments/Images/FactoryNewGP.png" : Condition.Type == ConditionTypes.Used ? "../../../Instruments/Images/UsedGP.png" : "../../../Instruments/Images/DamagedGP.png");
        return table;
    }
    
}