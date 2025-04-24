namespace MusicStore.Instruments.Pianos;

public class Grand : Piano
{
    public uint PedalCount { get; set; }
    public Grand(string band, string model, uint price, ConditionTypes conditionTypes, uint keyCount, uint pedalCount) : base(band, model, price, conditionTypes, keyCount)
    { 
        PedalCount = pedalCount;
    }

    public override string ToString()
    {
        return base.ToString() + "; " + $"Count Of Pedals: {PedalCount}";
    }
    
}