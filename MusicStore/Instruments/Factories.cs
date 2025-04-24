using System.Diagnostics.Metrics;
using MusicStore.Instruments.Guitars;
using MusicStore.Instruments.Pianos;

namespace MusicStore.Instruments;

public abstract class InstrumentCreator
{
    public readonly Type InstrumentType = typeof(MusicalInstrument);
    public abstract MusicalInstrument CreateInst(params object[] infoFields);
}

internal class AcousticGuitarCreator : InstrumentCreator
{
    public new readonly Type InstrumentType = typeof(Acoustic);
    public override MusicalInstrument CreateInst(params object[] infoFields)
    {
        return new Acoustic((string)infoFields[0], (string)infoFields[1], Convert.ToUInt32((string)infoFields[2]), (ConditionTypes)Enum.Parse(typeof(ConditionTypes), (string)infoFields[3]), Convert.ToUInt32((string)infoFields[4]), (string)infoFields[5]);
    }
}

internal class ElectricGuitarCreator : InstrumentCreator
{
    public new readonly Type InstrumentType = typeof(Electric);
    public override MusicalInstrument CreateInst(params object[] infoFields)
    {
        return new Electric((string)infoFields[0], (string)infoFields[1], Convert.ToUInt32((string)infoFields[2]), (ConditionTypes)Enum.Parse(typeof(ConditionTypes), (string)infoFields[3]), Convert.ToUInt32((string)infoFields[4]), (string)infoFields[5]);
    }
}
internal class UkuleleCreator : InstrumentCreator
{
    public new readonly Type InstrumentType = typeof(Ukulele);
    public override MusicalInstrument CreateInst(params object[] infoFields)
    {
        return new Ukulele((string)infoFields[0], (string)infoFields[1], Convert.ToUInt32((string)infoFields[2]), (ConditionTypes)Enum.Parse(typeof(ConditionTypes), (string)infoFields[3]), Convert.ToUInt32((string)infoFields[4]), (UkuleleType)Enum.Parse(typeof(UkuleleType), (string)infoFields[5]));
    }
}

internal class DigitalPianoCreator : InstrumentCreator
{
    public new readonly Type InstrumentType = typeof(Digital);
    public override MusicalInstrument CreateInst(params object[] infoFields)
    {
        return new Digital((string)infoFields[0], (string)infoFields[1], Convert.ToUInt32((string)infoFields[2]), (ConditionTypes)Enum.Parse(typeof(ConditionTypes), (string)infoFields[3]), Convert.ToUInt32((string)infoFields[4]), Convert.ToBoolean((string)infoFields[5]));
    }
}
internal class GrandPianoCreator : InstrumentCreator
{
    public new readonly Type InstrumentType = typeof(Grand);
    public override MusicalInstrument CreateInst(params object[] infoFields)
    {
        return new Grand((string)infoFields[0], (string)infoFields[1], Convert.ToUInt32((string)infoFields[2]), (ConditionTypes)Enum.Parse(typeof(ConditionTypes), (string)infoFields[3]), Convert.ToUInt32((string)infoFields[4]), Convert.ToUInt32((string)infoFields[5]));
    }
}
internal class MidiCreator : InstrumentCreator
{
    public new readonly Type InstrumentType = typeof(MIDI);
    public override MusicalInstrument CreateInst(params object[] infoFields)
    {
        return new MIDI((string)infoFields[0], (string)infoFields[1], Convert.ToUInt32((string)infoFields[2]), (ConditionTypes)Enum.Parse(typeof(ConditionTypes), (string)infoFields[3]), Convert.ToUInt32((string)infoFields[4]), Convert.ToUInt32((string)infoFields[5]));
    }
}