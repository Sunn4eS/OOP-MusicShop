using System.Runtime.Serialization;

namespace MusicStore.Instruments;

[DataContract]
public enum ConditionTypes
{
    [EnumMember]
    FactoryNew,
    [EnumMember]
    Used,
    [EnumMember]
    Damaged,
    
}

[DataContract]
public class Condition
{
    public static int[] PriceCoefficients = [3, 2, 1];
    [DataMember]
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