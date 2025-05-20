using System.Diagnostics.Metrics;
using System.Runtime.Serialization;
using MusicStore.Instruments.Pianos;

namespace MusicStore.Instruments.Guitars;

[DataContract]
[KnownType(typeof(Acoustic))]
[KnownType(typeof(Electric))]
[KnownType(typeof(Ukulele))]
public abstract class Guitar : MusicalInstrument
{
    [DataMember]
    public uint StringsCount { get; set; }

    public Guitar(string brand, string model, uint price, ConditionTypes condition, uint stringsCount) : base(brand, model, price, condition)
    {
        StringsCount = stringsCount;
    }
    public Guitar() {}

    public override string ToString()
    {
        return base.ToString() + "; " + $"Count of strings: {StringsCount}";
    }
}