namespace MusicStore.Instruments.Pianos;

public class Digital : Piano
{
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
}