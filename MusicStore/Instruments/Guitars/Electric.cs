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
    
}