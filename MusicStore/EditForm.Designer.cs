using System.ComponentModel;

namespace MusicStore;

partial class EditForm
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
        editflowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
        editButton = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // editflowLayoutPanel
        // 
        editflowLayoutPanel.Location = new System.Drawing.Point(67, 111);
        editflowLayoutPanel.Name = "editflowLayoutPanel";
        editflowLayoutPanel.Size = new System.Drawing.Size(344, 423);
        editflowLayoutPanel.TabIndex = 0;
        // 
        // editButton
        // 
        editButton.Font = new System.Drawing.Font("Segoe UI", 14F);
        editButton.Location = new System.Drawing.Point(250, 566);
        editButton.Name = "editButton";
        editButton.Size = new System.Drawing.Size(170, 73);
        editButton.TabIndex = 1;
        editButton.Text = "Edit";
        editButton.UseVisualStyleBackColor = true;
        editButton.Click += editButton_Click;
        // 
        // EditForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(466, 666);
        Controls.Add(editButton);
        Controls.Add(editflowLayoutPanel);
        Text = "EditForm";
        ResumeLayout(false);
    }

    private System.Windows.Forms.FlowLayoutPanel editflowLayoutPanel;
    private System.Windows.Forms.Button editButton;

    #endregion
}