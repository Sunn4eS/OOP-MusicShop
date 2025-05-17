using System.Reflection;
using MusicStore.Encrypt;
using MusicStore.Instruments;

namespace MusicStore;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
        Program.InstrumentsData = new InstrumentsData(instrumentsflowLayoutPanel);
        fileToolStripMenuItem.Enabled = false;
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

    private void openToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ;
    }
    private IPluginCipher _cipherPlugin;

    private void saveToolStripMenuItem_Click(object sender, EventArgs e)
    {
        string key = Microsoft.VisualBasic.Interaction.InputBox(
            "Введите ключ:", 
            "Ввод ключа", 
            ""
        );
        // byte[] keyBytes = Encryption.BinaryStringToBytes(key);
        byte[] keyBytes = key.Select(c => (byte)(c - '0')).ToArray(); 
        if (saveEncFileDialog.ShowDialog() == DialogResult.OK)
        {
            
            using FileStream fs = File.Create(saveEncFileDialog.FileName);
            _cipherPlugin.Encrypt(Program.InstrumentsData!, fs, keyBytes);
            
        }
        
        
    }
    private void enableEncryptionButton_Click(object sender, EventArgs e)
    {
        if (openFileDialogDll.ShowDialog() == DialogResult.OK)
        {
            _cipherPlugin = Encryption.LoadCipher(openFileDialogDll.FileName);
            fileToolStripMenuItem.Enabled = true;
        }
    }
}