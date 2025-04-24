using System.ComponentModel;

namespace MusicStore;

partial class AddForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        addButton = new System.Windows.Forms.Button();
        instrumentTypeComboBox = new System.Windows.Forms.ComboBox();
        fieldsflowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
        SuspendLayout();
        // 
        // addButton
        // 
        addButton.Font = new System.Drawing.Font("Segoe UI", 12F);
        addButton.Location = new System.Drawing.Point(390, 615);
        addButton.Name = "addButton";
        addButton.Size = new System.Drawing.Size(172, 82);
        addButton.TabIndex = 0;
        addButton.Text = "Add";
        addButton.UseVisualStyleBackColor = true;
        addButton.Click += addButton_Click;
        // 
        // instrumentTypeComboBox
        // 
        instrumentTypeComboBox.Font = new System.Drawing.Font("Segoe UI", 13F);
        instrumentTypeComboBox.FormattingEnabled = true;
        instrumentTypeComboBox.Location = new System.Drawing.Point(86, 106);
        instrumentTypeComboBox.Name = "instrumentTypeComboBox";
        instrumentTypeComboBox.Size = new System.Drawing.Size(444, 44);
        instrumentTypeComboBox.TabIndex = 1;
        instrumentTypeComboBox.SelectedIndexChanged += instrumentTypeComboBox_SelectedIndexChanged;
        // 
        // fieldsflowLayoutPanel
        // 
        fieldsflowLayoutPanel.Location = new System.Drawing.Point(99, 186);
        fieldsflowLayoutPanel.Name = "fieldsflowLayoutPanel";
        fieldsflowLayoutPanel.Size = new System.Drawing.Size(430, 392);
        fieldsflowLayoutPanel.TabIndex = 2;
        // 
        // AddForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(601, 728);
        Controls.Add(fieldsflowLayoutPanel);
        Controls.Add(instrumentTypeComboBox);
        Controls.Add(addButton);
        Text = "AddForm";
        ResumeLayout(false);
    }

    private System.Windows.Forms.FlowLayoutPanel fieldsflowLayoutPanel;

    private System.Windows.Forms.Button addButton;
    private System.Windows.Forms.ComboBox instrumentTypeComboBox;

    #endregion
}