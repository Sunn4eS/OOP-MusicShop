using System.Reflection;
using MusicStore.Instruments;

namespace MusicStore;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
        Program.InstrumentsData = new InstrumentsData(instrumentsflowLayoutPanel);
    }

    private void addButton_Click(object sender, EventArgs e)
    {
        var addForm = new AddForm();
        addForm.ShowDialog();
    }

    private void undoButton_Click(object sender, EventArgs e)
    {
        Program.InstrumentsData!.Undo();
    }

    private void redoButton_Click(object sender, EventArgs e)
    {
        Program.InstrumentsData!.Redo();
    }

    private void importButton_Click(object sender, EventArgs e)
    {
        if (openFileDialogDll.ShowDialog() == DialogResult.OK)
        {
            Assembly.LoadFrom(openFileDialogDll.FileName);
        }
    }
}