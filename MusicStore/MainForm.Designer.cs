namespace MusicStore;

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
        redoButton = new System.Windows.Forms.Button();
        undoButton = new System.Windows.Forms.Button();
        addButton = new System.Windows.Forms.Button();
        actionsPanel.SuspendLayout();
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
        actionsPanel.Controls.Add(redoButton);
        actionsPanel.Controls.Add(undoButton);
        actionsPanel.Controls.Add(addButton);
        actionsPanel.Location = new System.Drawing.Point(1, 93);
        actionsPanel.Name = "actionsPanel";
        actionsPanel.Size = new System.Drawing.Size(201, 554);
        actionsPanel.TabIndex = 1;
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
        // MainForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1016, 649);
        Controls.Add(actionsPanel);
        Controls.Add(instrumentsflowLayoutPanel);
        Text = "MainForm";
        actionsPanel.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.FlowLayoutPanel instrumentsflowLayoutPanel;
    private System.Windows.Forms.Panel actionsPanel;
    private System.Windows.Forms.Button addButton;
    private System.Windows.Forms.Button undoButton;
    private System.Windows.Forms.Button redoButton;

    #endregion
}