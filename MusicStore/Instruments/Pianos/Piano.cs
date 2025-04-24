namespace MusicStore.Instruments.Pianos;

public abstract class Piano : MusicalInstrument
{
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