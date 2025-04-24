using System.Diagnostics.Metrics;

namespace MusicStore.Instruments.Guitars;

public abstract class Guitar : MusicalInstrument
{
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