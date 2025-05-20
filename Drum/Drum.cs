using System.Runtime.Serialization;

namespace MusicStore.Instruments.Drum
{
    [DataContract]
    public class Drum : MusicalInstrument
    {
        [DataMember]
        public uint Size { get; set; }

        public Drum(string brand, string model, uint price, ConditionTypes condition, uint size) : base(brand, model,
            price, condition)
        {
            Size = size;
        }

        public Drum()
        {
        }

        public override Panel Visualize()
        {
            var table = base.Visualize();
            ((PictureBox)table.Controls[0]).Image = Image.FromFile(Condition!.Type == ConditionTypes.FactoryNew
                ?
                "../../../Instruments/Images/FactoryNewD.png"
                : Condition.Type == ConditionTypes.Used
                    ? "../../../Instruments/Images/UsedD.png"
                    : "../../../Instruments/Images/DamagedD.png");
            return table;
        }

        public override string ToString()
        {
            return base.ToString() + $", Size: {Size}";
        }
    }
}

namespace MusicStore.Instruments
{
    internal class DrumCreator : InstrumentCreator
    {
        public new readonly System.Type InstrumentType = typeof(Drum.Drum);

        public override MusicalInstrument CreateInst(params object[] infoFields)
        {
            return new Drum.Drum((string)infoFields[0], (string)infoFields[1], Convert.ToUInt32((string)infoFields[2]),
                (ConditionTypes)Enum.Parse(typeof(ConditionTypes), (string)infoFields[3]),
                Convert.ToUInt32((string)infoFields[4]));
        }
    }
}