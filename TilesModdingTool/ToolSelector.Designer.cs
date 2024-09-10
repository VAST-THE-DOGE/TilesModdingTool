namespace TilesModdingTool;

partial class ToolSelector
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolSelector));
        tableLayoutPanel1 = new TableLayoutPanel();
        label2 = new Label();
        label1 = new Label();
        tableLayoutPanel2 = new TableLayoutPanel();
        buttonSkinEdit = new Button();
        buttonMusicEdit = new Button();
        buttonTileEdit = new Button();
        buttonLeaderEdit = new Button();
        buttonUpdateInfo = new Button();
        buttonResearchEdit = new Button();
        tableLayoutPanel1.SuspendLayout();
        tableLayoutPanel2.SuspendLayout();
        SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 1;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 36F));
        tableLayoutPanel1.Controls.Add(label1, 0, 0);
        tableLayoutPanel1.Controls.Add(label2, 0, 1);
        tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(0, 0);
        tableLayoutPanel1.Margin = new Padding(5, 4, 5, 4);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 3;
        tableLayoutPanel1.RowStyles.Add(new RowStyle());
        tableLayoutPanel1.RowStyles.Add(new RowStyle());
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        tableLayoutPanel1.Size = new Size(2278, 1233);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Dock = DockStyle.Fill;
        label2.Font = new Font("Arial", 14.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label2.ForeColor = SystemColors.ButtonHighlight;
        label2.Location = new Point(5, 122);
        label2.Margin = new Padding(5, 0, 5, 50);
        label2.Name = "label2";
        label2.Size = new Size(2268, 53);
        label2.TabIndex = 1;
        label2.Text = "Please select the tool that you would like to use:";
        label2.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Dock = DockStyle.Fill;
        label1.Font = new Font("Arial", 26.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label1.ForeColor = SystemColors.ButtonHighlight;
        label1.Location = new Point(5, 25);
        label1.Margin = new Padding(5, 25, 5, 0);
        label1.Name = "label1";
        label1.Size = new Size(2268, 97);
        label1.TabIndex = 0;
        label1.Text = "Welcome to Tiles Modding Tool";
        label1.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.ColumnCount = 2;
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
        tableLayoutPanel2.Controls.Add(buttonMusicEdit, 1, 0);
        tableLayoutPanel2.Controls.Add(buttonTileEdit, 0, 1);
        tableLayoutPanel2.Controls.Add(buttonLeaderEdit, 1, 1);
        tableLayoutPanel2.Controls.Add(buttonResearchEdit, 0, 2);
        tableLayoutPanel2.Controls.Add(buttonUpdateInfo, 1, 2);
        tableLayoutPanel2.Controls.Add(buttonSkinEdit, 0, 0);
        tableLayoutPanel2.Dock = DockStyle.Fill;
        tableLayoutPanel2.Location = new Point(3, 228);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 3;
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
        tableLayoutPanel2.Size = new Size(2272, 1002);
        tableLayoutPanel2.TabIndex = 2;
        // 
        // buttonSkinEdit
        // 
        buttonSkinEdit.BackColor = Color.FromArgb(37, 43, 50);
        buttonSkinEdit.Cursor = Cursors.Hand;
        buttonSkinEdit.Dock = DockStyle.Fill;
        buttonSkinEdit.FlatAppearance.BorderColor = Color.Yellow;
        buttonSkinEdit.FlatAppearance.BorderSize = 5;
        buttonSkinEdit.FlatAppearance.MouseDownBackColor = Color.Red;
        buttonSkinEdit.FlatAppearance.MouseOverBackColor = Color.Yellow;
        buttonSkinEdit.FlatStyle = FlatStyle.Flat;
        buttonSkinEdit.Font = new Font("Arial", 20.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
        buttonSkinEdit.ForeColor = SystemColors.ButtonHighlight;
        buttonSkinEdit.Location = new Point(25, 25);
        buttonSkinEdit.Margin = new Padding(25);
        buttonSkinEdit.Name = "buttonSkinEdit";
        buttonSkinEdit.Size = new Size(1085, 284);
        buttonSkinEdit.TabIndex = 0;
        buttonSkinEdit.Text = "Skin Pack Editor";
        buttonSkinEdit.UseVisualStyleBackColor = false;
        // 
        // buttonMusicEdit
        // 
        buttonMusicEdit.BackColor = Color.FromArgb(37, 43, 50);
        buttonMusicEdit.Cursor = Cursors.Hand;
        buttonMusicEdit.Dock = DockStyle.Fill;
        buttonMusicEdit.FlatAppearance.BorderColor = Color.Yellow;
        buttonMusicEdit.FlatAppearance.BorderSize = 5;
        buttonMusicEdit.FlatAppearance.MouseDownBackColor = Color.Red;
        buttonMusicEdit.FlatAppearance.MouseOverBackColor = Color.Yellow;
        buttonMusicEdit.FlatStyle = FlatStyle.Flat;
        buttonMusicEdit.Font = new Font("Arial", 20.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
        buttonMusicEdit.ForeColor = SystemColors.ButtonHighlight;
        buttonMusicEdit.Location = new Point(1160, 25);
        buttonMusicEdit.Margin = new Padding(25);
        buttonMusicEdit.Name = "buttonMusicEdit";
        buttonMusicEdit.Size = new Size(1087, 284);
        buttonMusicEdit.TabIndex = 1;
        buttonMusicEdit.Text = "Music Pack Editor";
        buttonMusicEdit.UseVisualStyleBackColor = false;
        // 
        // buttonTileEdit
        // 
        buttonTileEdit.BackColor = Color.FromArgb(37, 43, 50);
        buttonTileEdit.Cursor = Cursors.Hand;
        buttonTileEdit.Dock = DockStyle.Fill;
        buttonTileEdit.FlatAppearance.BorderColor = Color.Yellow;
        buttonTileEdit.FlatAppearance.BorderSize = 5;
        buttonTileEdit.FlatAppearance.MouseDownBackColor = Color.Red;
        buttonTileEdit.FlatAppearance.MouseOverBackColor = Color.Yellow;
        buttonTileEdit.FlatStyle = FlatStyle.Flat;
        buttonTileEdit.Font = new Font("Arial", 20.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
        buttonTileEdit.ForeColor = SystemColors.ButtonHighlight;
        buttonTileEdit.Location = new Point(25, 359);
        buttonTileEdit.Margin = new Padding(25);
        buttonTileEdit.Name = "buttonTileEdit";
        buttonTileEdit.Size = new Size(1085, 284);
        buttonTileEdit.TabIndex = 2;
        buttonTileEdit.Text = "Tile Editor ";
        buttonTileEdit.UseVisualStyleBackColor = false;
        // 
        // buttonLeaderEdit
        // 
        buttonLeaderEdit.BackColor = Color.FromArgb(37, 43, 50);
        buttonLeaderEdit.Cursor = Cursors.Hand;
        buttonLeaderEdit.Dock = DockStyle.Fill;
        buttonLeaderEdit.FlatAppearance.BorderColor = Color.Yellow;
        buttonLeaderEdit.FlatAppearance.BorderSize = 5;
        buttonLeaderEdit.FlatAppearance.MouseDownBackColor = Color.Red;
        buttonLeaderEdit.FlatAppearance.MouseOverBackColor = Color.Yellow;
        buttonLeaderEdit.FlatStyle = FlatStyle.Flat;
        buttonLeaderEdit.Font = new Font("Arial", 20.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
        buttonLeaderEdit.ForeColor = SystemColors.ButtonHighlight;
        buttonLeaderEdit.Location = new Point(1160, 359);
        buttonLeaderEdit.Margin = new Padding(25);
        buttonLeaderEdit.Name = "buttonLeaderEdit";
        buttonLeaderEdit.Size = new Size(1087, 284);
        buttonLeaderEdit.TabIndex = 3;
        buttonLeaderEdit.Text = "Leader Pack Editor";
        buttonLeaderEdit.UseVisualStyleBackColor = false;
        // 
        // buttonUpdateInfo
        // 
        buttonUpdateInfo.BackColor = Color.FromArgb(37, 43, 50);
        buttonUpdateInfo.Cursor = Cursors.Hand;
        buttonUpdateInfo.Dock = DockStyle.Fill;
        buttonUpdateInfo.FlatAppearance.BorderColor = Color.Yellow;
        buttonUpdateInfo.FlatAppearance.BorderSize = 5;
        buttonUpdateInfo.FlatAppearance.MouseDownBackColor = Color.Red;
        buttonUpdateInfo.FlatAppearance.MouseOverBackColor = Color.Yellow;
        buttonUpdateInfo.FlatStyle = FlatStyle.Flat;
        buttonUpdateInfo.Font = new Font("Arial", 20.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
        buttonUpdateInfo.ForeColor = SystemColors.ButtonHighlight;
        buttonUpdateInfo.Location = new Point(1160, 693);
        buttonUpdateInfo.Margin = new Padding(25);
        buttonUpdateInfo.Name = "buttonUpdateInfo";
        buttonUpdateInfo.Size = new Size(1087, 284);
        buttonUpdateInfo.TabIndex = 5;
        buttonUpdateInfo.Text = "Updates / Info";
        buttonUpdateInfo.UseVisualStyleBackColor = false;
        // 
        // buttonResearchEdit
        // 
        buttonResearchEdit.BackColor = Color.FromArgb(37, 43, 50);
        buttonResearchEdit.Cursor = Cursors.Hand;
        buttonResearchEdit.Dock = DockStyle.Fill;
        buttonResearchEdit.FlatAppearance.BorderColor = Color.Yellow;
        buttonResearchEdit.FlatAppearance.BorderSize = 5;
        buttonResearchEdit.FlatAppearance.MouseDownBackColor = Color.Red;
        buttonResearchEdit.FlatAppearance.MouseOverBackColor = Color.Yellow;
        buttonResearchEdit.FlatStyle = FlatStyle.Flat;
        buttonResearchEdit.Font = new Font("Arial", 20.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
        buttonResearchEdit.ForeColor = SystemColors.ButtonHighlight;
        buttonResearchEdit.Location = new Point(25, 693);
        buttonResearchEdit.Margin = new Padding(25);
        buttonResearchEdit.Name = "buttonResearchEdit";
        buttonResearchEdit.Size = new Size(1085, 284);
        buttonResearchEdit.TabIndex = 4;
        buttonResearchEdit.Text = "Research Pack Editor";
        buttonResearchEdit.UseVisualStyleBackColor = false;
        // 
        // ToolSelector
        // 
        AutoScaleDimensions = new SizeF(31F, 60F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(63, 71, 84);
        ClientSize = new Size(2278, 1233);
        Controls.Add(tableLayoutPanel1);
        Font = new Font("Arial", 15.9000006F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(5, 4, 5, 4);
        Name = "ToolSelector";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Tiles Modding Tool";
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel1.PerformLayout();
        tableLayoutPanel2.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel tableLayoutPanel1;
    private Label label2;
    private Label label1;
    private TableLayoutPanel tableLayoutPanel2;
    private Button buttonSkinEdit;
    private Button buttonMusicEdit;
    private Button buttonTileEdit;
    private Button buttonLeaderEdit;
    private Button buttonResearchEdit;
    private Button buttonUpdateInfo;
}