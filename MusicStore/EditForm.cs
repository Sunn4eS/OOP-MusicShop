using System.Reflection;
using MusicStore.Instruments;

namespace MusicStore;

public partial class EditForm : Form
{
    private readonly MusicalInstrument _instrument;
    public EditForm(MusicalInstrument instrument)
    {
        _instrument = instrument;
        InitializeComponent();
        AddInstruments(instrument.GetType());
        
    }
    private void AddInstruments(System.Type? type)
    {
        if (type!.BaseType != typeof(Object))
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
            textBox.Size = new Size(editflowLayoutPanel.Width - 30, 40);
            textBox.TextChanged += textBox_TextChanged;

            editflowLayoutPanel.Controls.Add(textBox);
        }
    }

    private void textBox_TextChanged(Object sender, EventArgs e)
    {
        editButton.Enabled = CanAdd();
    }
    private bool CanAdd()
    {
        foreach (var control in editflowLayoutPanel.Controls)
        {
            if (((TextBox)control).Text.Length == 0)
            {
                return false;
            }
        }
        return true;
    }

    private void editButton_Click(object sender, EventArgs e)
    {
        int i = 0;

        System.Type? currentType = _instrument.GetType();
        var properties = new List<PropertyInfo>();

        while (currentType != null)
        {
            var currentProperties = currentType.GetProperties(
                BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly
            );

            properties.InsertRange(0, currentProperties);

            currentType = currentType.BaseType;
        }

        foreach (var property in properties)
        {
            if (i < editflowLayoutPanel.Controls.Count && editflowLayoutPanel.Controls[i] is TextBox textBox)
            {
                object convertedValue;
                if (property.PropertyType == typeof(Condition))
                {
                    convertedValue = textBox.Text;
                    _instrument.RepairInstrument(new Condition((ConditionTypes)Enum.Parse(typeof(ConditionTypes), ((string)convertedValue))));
                }
                else
                {
                    convertedValue = Convert.ChangeType(textBox.Text, property.PropertyType);
                    property.SetValue(_instrument, convertedValue);
                }

                i++;
            }
        }

        Program.InstrumentsData.UpdateHistory();
        Program.InstrumentsData!.UpdateView();

        this.Close();
    }
}