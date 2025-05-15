using System.Diagnostics.Metrics;
using System.Reflection;
using MusicStore.Instruments;

namespace MusicStore;

public partial class AddForm : Form
{
    private List<System.Type> instrumentsTypes;
    public AddForm()
    {
        InitializeComponent();
        instrumentsTypes = new List<System.Type>();
        AddInstrumentsTypes();
        
    }

    private void AddInstrumentsTypes()
    {
        System.Type[] allTypes = Types.Type.GetTypes();
        var baseClassType = typeof(InstrumentCreator);
        foreach (var type in allTypes)
        {
            if (type != baseClassType && baseClassType.IsAssignableFrom(type))
            {
                instrumentsTypes.Add(type);
                instrumentTypeComboBox.Items.Add(type.Name);
            }
        }
    }

    private void AddInstruments(System.Type type)
    {
        if (type.BaseType != null && type!.BaseType != typeof(MusicalInstrument).BaseType)
        {
            AddInstruments(type.BaseType);
        }

        foreach (var field in type.GetProperties())
        {
            if (type.BaseType != null && type.BaseType.GetProperty(field.Name, BindingFlags.Public | BindingFlags.Instance) != null)
            {
                continue; 
            }

            var textBox = new TextBox();
            textBox.Font = new Font("Segoe UI", 13.8F);
            textBox.PlaceholderText = field.Name;
            textBox.Size = new Size(fieldsflowLayoutPanel.Width - 30, 40);
            textBox.TextChanged += textBox_TextChanged;

            fieldsflowLayoutPanel.Controls.Add(textBox);
        }
    }

    private void textBox_TextChanged(Object sender, EventArgs e)
    {
        addButton.Enabled = CanAdd();
    }
    private bool CanAdd()
    {
        foreach (var control in fieldsflowLayoutPanel.Controls)
        {
            if (((TextBox)control).Text.Length == 0)
            {
                return false;
            }
        }
        return true;
    }

    private void instrumentTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        System.Type instrumentCreatorType = instrumentsTypes.FirstOrDefault(t => t.FullName == $"MusicStore.Instruments.{instrumentTypeComboBox.SelectedItem}")!;

        if (instrumentCreatorType != null)
        {
            var instrumentCreatorInstance = Activator.CreateInstance(instrumentCreatorType);
            var instrumentTypeField = instrumentCreatorType.GetField("InstrumentType", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
            var instrumentType = instrumentTypeField!.GetValue(instrumentCreatorInstance) as System.Type;

            if (instrumentType != null)
            {
                fieldsflowLayoutPanel.Controls.Clear();
                AddInstruments(instrumentType);
            }
        }
    }

    private void addButton_Click(object sender, EventArgs e)
    {
        var fields = new object[fieldsflowLayoutPanel.Controls.Count];
        for (int i = 0; i < fields.Length; i++)
        {
            fields[i] = ((TextBox)fieldsflowLayoutPanel.Controls[i]).Text;
        }

       // System.Type instrumentCreatorType = instrumentsTypes.FirstOrDefault(t => t.FullName == $"MusicStore.Instruments.{instrumentTypeComboBox.SelectedItem}")!;
        Type instrumentCreatorType = instrumentsTypes
            .FirstOrDefault(t => t.Name.Equals(instrumentTypeComboBox.SelectedItem.ToString(), StringComparison.OrdinalIgnoreCase));
        Program.InstrumentsData!.AddInstrument((Activator.CreateInstance(instrumentCreatorType) as InstrumentCreator)!.CreateInst(fields));

        this.Close();
    }
}