﻿namespace MusicStore;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        instrumentsflowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
        actionsPanel = new System.Windows.Forms.Panel();
        enableEncryptionButton = new System.Windows.Forms.Button();
        importButton = new System.Windows.Forms.Button();
        redoButton = new System.Windows.Forms.Button();
        undoButton = new System.Windows.Forms.Button();
        addButton = new System.Windows.Forms.Button();
        openFileDialogDll = new System.Windows.Forms.OpenFileDialog();
        menuStrip = new System.Windows.Forms.MenuStrip();
        fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        saveEncFileDialog = new System.Windows.Forms.SaveFileDialog();
        openEncFileDialog = new System.Windows.Forms.OpenFileDialog();
        actionsPanel.SuspendLayout();
        menuStrip.SuspendLayout();
        SuspendLayout();
        // 
        // instrumentsflowLayoutPanel
        // 
        instrumentsflowLayoutPanel.AutoScroll = true;
        instrumentsflowLayoutPanel.Location = new System.Drawing.Point(202, 94);
        instrumentsflowLayoutPanel.Name = "instrumentsflowLayoutPanel";
        instrumentsflowLayoutPanel.Size = new System.Drawing.Size(813, 554);
        instrumentsflowLayoutPanel.TabIndex = 0;
        // 
        // actionsPanel
        // 
        actionsPanel.Controls.Add(enableEncryptionButton);
        actionsPanel.Controls.Add(importButton);
        actionsPanel.Controls.Add(redoButton);
        actionsPanel.Controls.Add(undoButton);
        actionsPanel.Controls.Add(addButton);
        actionsPanel.Location = new System.Drawing.Point(1, 93);
        actionsPanel.Name = "actionsPanel";
        actionsPanel.Size = new System.Drawing.Size(201, 554);
        actionsPanel.TabIndex = 1;
        // 
        // enableEncryptionButton
        // 
        enableEncryptionButton.Location = new System.Drawing.Point(35, 395);
        enableEncryptionButton.Name = "enableEncryptionButton";
        enableEncryptionButton.Size = new System.Drawing.Size(128, 59);
        enableEncryptionButton.TabIndex = 4;
        enableEncryptionButton.Text = "Enable Encryption";
        enableEncryptionButton.UseVisualStyleBackColor = true;
        enableEncryptionButton.Click += enableEncryptionButton_Click;
        // 
        // importButton
        // 
        importButton.Location = new System.Drawing.Point(32, 301);
        importButton.Name = "importButton";
        importButton.Size = new System.Drawing.Size(132, 67);
        importButton.TabIndex = 3;
        importButton.Text = "Import class";
        importButton.UseVisualStyleBackColor = true;
        importButton.Click += importButton_Click;
        // 
        // redoButton
        // 
        redoButton.Location = new System.Drawing.Point(32, 204);
        redoButton.Name = "redoButton";
        redoButton.Size = new System.Drawing.Size(130, 65);
        redoButton.TabIndex = 2;
        redoButton.Text = "Redo";
        redoButton.UseVisualStyleBackColor = true;
        redoButton.Click += redoButton_Click;
        // 
        // undoButton
        // 
        undoButton.Location = new System.Drawing.Point(30, 114);
        undoButton.Name = "undoButton";
        undoButton.Size = new System.Drawing.Size(133, 60);
        undoButton.TabIndex = 1;
        undoButton.Text = "Undo";
        undoButton.UseVisualStyleBackColor = true;
        undoButton.Click += undoButton_Click;
        // 
        // addButton
        // 
        addButton.Location = new System.Drawing.Point(26, 31);
        addButton.Name = "addButton";
        addButton.Size = new System.Drawing.Size(138, 57);
        addButton.TabIndex = 0;
        addButton.Text = "Add";
        addButton.UseVisualStyleBackColor = true;
        addButton.Click += addButton_Click;
        // 
        // openFileDialogDll
        // 
        openFileDialogDll.Filter = "(*.dll)|*.dll";
        // 
        // menuStrip
        // 
        menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
        menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem });
        menuStrip.Location = new System.Drawing.Point(0, 0);
        menuStrip.Name = "menuStrip";
        menuStrip.Size = new System.Drawing.Size(1016, 33);
        menuStrip.TabIndex = 0;
        menuStrip.Text = "menuStrip";
        // 
        // fileToolStripMenuItem
        // 
        fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem });
        fileToolStripMenuItem.Name = "fileToolStripMenuItem";
        fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
        fileToolStripMenuItem.Text = "File";
        // 
        // openToolStripMenuItem
        // 
        openToolStripMenuItem.Name = "openToolStripMenuItem";
        openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O));
        openToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
        openToolStripMenuItem.Text = "Open";
        openToolStripMenuItem.Click += openToolStripMenuItem_Click;
        // 
        // saveToolStripMenuItem
        // 
        saveToolStripMenuItem.Name = "saveToolStripMenuItem";
        saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
        saveToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
        saveToolStripMenuItem.Text = "Save";
        saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
        // 
        // saveEncFileDialog
        // 
        saveEncFileDialog.Filter = " (*.enc)|*.enc";
        // 
        // openEncFileDialog
        // 
        openEncFileDialog.Filter = " (*.enc)|*.enc";
        // 
        // MainForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1016, 649);
        Controls.Add(actionsPanel);
        Controls.Add(instrumentsflowLayoutPanel);
        Controls.Add(menuStrip);
        MainMenuStrip = menuStrip;
        Text = "MainForm";
        actionsPanel.ResumeLayout(false);
        menuStrip.ResumeLayout(false);
        menuStrip.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.SaveFileDialog saveEncFileDialog;
    private System.Windows.Forms.OpenFileDialog openEncFileDialog;

    private System.Windows.Forms.MenuStrip menuStrip;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    

    private System.Windows.Forms.Button enableEncryptionButton;

    private System.Windows.Forms.OpenFileDialog openFileDialogDll;

    private System.Windows.Forms.Button importButton;

    private System.Windows.Forms.FlowLayoutPanel instrumentsflowLayoutPanel;
    private System.Windows.Forms.Panel actionsPanel;
    private System.Windows.Forms.Button addButton;
    private System.Windows.Forms.Button undoButton;
    private System.Windows.Forms.Button redoButton;
    

    #endregion
}