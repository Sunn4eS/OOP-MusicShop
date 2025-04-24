namespace MusicStore.Instruments.Guitars;

public class Electric : Guitar
{
    public string? BridgeType { get; set; }
    public Electric(string brand, string model, uint price, ConditionTypes condition, uint countOfStrings, string bridgeType) : base(brand, model, price, condition, countOfStrings)
    {
        BridgeType = bridgeType;
    }
    public Electric() {}

    public override string ToString()
    {
        return base.ToString() + "; " + $"BridgeType: {BridgeType}";
    }
    public override Panel Visualize()
    {
        var table = base.Visualize();
        ((PictureBox)table.Controls[0]).Image = Image.FromFile(Condition!.Type == ConditionTypes.FactoryNew ? "../../../Instruments/Images/FactoryNewEG.png" : Condition.Type == ConditionTypes.Used ? "../../../Instruments/Images/UsedEG.png" : "../../../Instruments/Images/DamagedEG.png");
        return table;
    }
    
}