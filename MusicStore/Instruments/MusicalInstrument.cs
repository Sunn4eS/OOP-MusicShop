using MusicStore.Instruments.Visualization;

namespace MusicStore.Instruments;

public abstract class MusicalInstrument : IVisulize
{
    protected static uint count = 0;
    protected uint id;

    public string? Brand { get; set; }
    public string? Model { get; set; }
    public uint Price { get; set; }
    public Condition? Condition { get; set; }

    public MusicalInstrument(string brand, string model, uint price, ConditionTypes condition)
    {
        id = count;
        Brand = brand;
        Model = model;
        Price = price;
        Condition = new Condition(condition);
        count++;
    }
    public MusicalInstrument() {}

    public void RepairInstrument(Condition conditionSteps)
    {
        UpdatePrice(Condition!.Type, conditionSteps.Type);
    }

    public virtual void UpdatePrice(ConditionTypes oldCondition, ConditionTypes newCondition)
    {
        Price *= (uint)(Condition.PriceCoefficients[(int)newCondition] / Condition.PriceCoefficients[(int)oldCondition]);
    }

    public virtual Panel Visualize()
    {
        var table = new Panel();
        table.AutoSize = true;
        table.Location = new Point(0, 0);
        table.BackColor = Color.SlateGray;
        
        var contextMenuStrip = new ContextMenuStrip();
        var editMenuItem = new ToolStripMenuItem("Edit");
        var deleteMenuItem = new ToolStripMenuItem("Delete");
        contextMenuStrip.Items.AddRange([editMenuItem, deleteMenuItem]);
        table.ContextMenuStrip = contextMenuStrip;
        editMenuItem.Click += EditMenuItem_Click;
        deleteMenuItem.Click += DeleteMenuItem_Click;

        var photo = new PictureBox();
        photo.Location = new Point(0, 0);
        photo.Size = new Size(200, 200);
        photo.SizeMode = PictureBoxSizeMode.StretchImage;
        table.Controls.Add(photo);
        
        var infoFields  = ToString().Split("; ");
        for (int i = 0; i < infoFields.Length; i++)
        {
            var infoField = new Label();
            infoField.AutoSize = true;
            infoField.Font = new Font("Segoe UI", i == 0 ? 14.2F : 12.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            infoField.Location = new Point(0, table.Controls[^1].Location.Y + table.Controls[^1].Size.Height);
            infoField.Text = infoFields[i];
            table.Controls.Add(infoField);
        }
        return table;
    }

    public override string ToString()
    {
        return $"Brand: {Brand}; Model: {Model}; Price: {Price}; Condition: {Condition!.ToString()}";
    }

    private void EditMenuItem_Click(object? sender, EventArgs e)
    {
        new EditForm(this).ShowDialog();

    }

    private void DeleteMenuItem_Click(object? sender, EventArgs e)
    {
        Program.InstrumentsData?.RemoveInstrument(this);
    }
    public MusicalInstrument DeepCopy()
    {
        var copy = (MusicalInstrument)this.MemberwiseClone(); 
        copy.Condition = new Condition(this.Condition!.Type);
        return copy;
    }

}