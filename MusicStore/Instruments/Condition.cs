namespace MusicStore.Instruments;

public enum ConditionTypes
{
    FactoryNew,
    Used,
    Damaged,
    
}

public class Condition
{
    public static int[] PriceCoefficients = [3, 2, 1];
    public ConditionTypes Type { get; set; }

    public Condition(ConditionTypes type)
    {
        Type = type;
    }

    public override string ToString()
    {
        return Type == ConditionTypes.FactoryNew ? "FactoryNew" : Type == ConditionTypes.Used ? "Used" : "Damaged";
    }
}