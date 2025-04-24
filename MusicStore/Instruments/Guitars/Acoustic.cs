namespace MusicStore.Instruments.Guitars;

public class Acoustic : Guitar
{
    public string? HousingType { get; set; }
    public Acoustic(string brand, string model, uint price, ConditionTypes condition,uint countOfStrings, string housingType) : base(brand, model, price, condition, countOfStrings)
    {
        HousingType = housingType;
    }
    public Acoustic() { }

    public override string ToString()
    {
        return base.ToString() + "; " + $"HousingType: {HousingType}";
    }

    public override Panel Visualize()
    {
        var table = base.Visualize();
        ((PictureBox)table.Controls[0]).Image = Image.FromFile(Condition!.Type == ConditionTypes.FactoryNew ? "../../../Instruments/Images/FactoryNewAG.png" : Condition.Type == ConditionTypes.Used ? "../../../Instruments/Images/UsedAG.png" : "../../../Instruments/Images/DamagedAG.png");
        return table;
    }
}