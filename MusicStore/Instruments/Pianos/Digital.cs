using System.Runtime.Serialization;

namespace MusicStore.Instruments.Pianos;
[DataContract]
public class Digital : Piano
{
    [DataMember]
    public bool JackForHeadphones { get; set; }
    
    public Digital(string band, string model, uint price, ConditionTypes conditionTypes, uint keyCount, bool isJack) : base(band, model, price, conditionTypes, keyCount)
    {
        JackForHeadphones = isJack;   
    }
    public Digital() {}
    public override string ToString()
    {
        return base.ToString() + "; " + $"Jack For Headphones: {JackForHeadphones}";
    }
    public override Panel Visualize()
    {
        var table = base.Visualize();
        ((PictureBox)table.Controls[0]).Image = Image.FromFile(Condition!.Type == ConditionTypes.FactoryNew ? "../../../Instruments/Images/FactoryNewDP.png" : Condition.Type == ConditionTypes.Used ? "../../../Instruments/Images/UsedDP.png" : "../../../Instruments/Images/DamagedDP.png");
        return table;
    }
}