using System.Runtime.Serialization;
using MusicStore.Instruments.Guitars;

namespace MusicStore.Instruments.Pianos;

[DataContract]
[KnownType(typeof(Grand))]
[KnownType(typeof(Digital))]
[KnownType(typeof(MIDI))]
public abstract class Piano : MusicalInstrument
{
    [DataMember]
    public uint KeyCount { get; set; }

    public Piano(string band, string model, uint price, ConditionTypes conditionTypes, uint keyCount) : base(band, model, price, conditionTypes)
    {
        KeyCount = keyCount;
    }
    public Piano() {}
    public override string ToString()
    {
        return base.ToString() + "; " + $"Key Count: {KeyCount}";
    }
}