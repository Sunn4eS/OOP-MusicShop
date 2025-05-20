using System.Runtime.Serialization;

namespace MusicStore.Instruments.Guitars;
[DataContract]
public enum UkuleleType
{
    [EnumMember]
    Soprano,
    [EnumMember]
    Concert,
    [EnumMember]
    Tenor, 
    [EnumMember]
    Baritone
}
[DataContract]
public class Ukulele : Guitar
{
    [DataMember]
    public UkuleleType TypeOfUkulele { get; set; }

    public Ukulele(string brand, string model, uint price, ConditionTypes condition, uint stringsCount,
        UkuleleType ukuleleType) : base(brand, model, price, condition, stringsCount)
    {
        TypeOfUkulele = ukuleleType;
    }
    public Ukulele() {}

    private string TypeToString(UkuleleType ukuleleType)
    {
        return ukuleleType == UkuleleType.Soprano ? "Soprano" : ukuleleType == UkuleleType.Concert ? "Concert" : ukuleleType == UkuleleType.Baritone ? "Baritone" : "Tenor";   
    }

    public override string ToString()
    {
        return base.ToString() +"; " + $" Ukulele: {TypeToString(TypeOfUkulele)}";
    }
    public override Panel Visualize()
    {
        var table = base.Visualize();
        ((PictureBox)table.Controls[0]).Image = Image.FromFile(Condition!.Type == ConditionTypes.FactoryNew ? "../../../Instruments/Images/FactoryNewUG.png" : Condition.Type == ConditionTypes.Used ? "../../../Instruments/Images/UsedUG.png" : "../../../Instruments/Images/DamagedUG.png");
        return table;
    }
    
}