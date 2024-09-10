namespace TilesModdingTool
{
    partial class FrmTileEditTool
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTileEditTool));
            tabControl1 = new TabControl();
            Overview = new TabPage();
            Settings = new TabPage();
            TileCreator = new TabPage();
            TileList = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tabControl1.SuspendLayout();
            Overview.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Overview);
            tabControl1.Controls.Add(TileList);
            tabControl1.Controls.Add(TileCreator);
            tabControl1.Controls.Add(Settings);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(5, 4, 5, 4);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Point(0, 0);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1872, 1236);
            tabControl1.TabIndex = 0;
            // 
            // Overview
            // 
            Overview.BackColor = Color.FromArgb(63, 71, 84);
            Overview.Controls.Add(tableLayoutPanel1);
            Overview.Location = new Point(10, 81);
            Overview.Margin = new Padding(5, 4, 5, 4);
            Overview.Name = "Overview";
            Overview.Padding = new Padding(5, 4, 5, 4);
            Overview.Size = new Size(1852, 1145);
            Overview.TabIndex = 0;
            Overview.Text = "Overview";
            // 
            // Settings
            // 
            Settings.BackColor = Color.FromArgb(63, 71, 84);
            Settings.Location = new Point(10, 81);
            Settings.Margin = new Padding(5, 4, 5, 4);
            Settings.Name = "Settings";
            Settings.Padding = new Padding(5, 4, 5, 4);
            Settings.Size = new Size(1852, 1145);
            Settings.TabIndex = 3;
            Settings.Text = "Settings";
            // 
            // TileCreator
            // 
            TileCreator.BackColor = Color.FromArgb(63, 71, 84);
            TileCreator.Location = new Point(10, 81);
            TileCreator.Margin = new Padding(5, 4, 5, 4);
            TileCreator.Name = "TileCreator";
            TileCreator.Padding = new Padding(5, 4, 5, 4);
            TileCreator.Size = new Size(1852, 1145);
            TileCreator.TabIndex = 4;
            TileCreator.Text = "Tile Creator";
            // 
            // TileList
            // 
            TileList.BackColor = Color.FromArgb(63, 71, 84);
            TileList.Location = new Point(10, 81);
            TileList.Margin = new Padding(5, 4, 5, 4);
            TileList.Name = "TileList";
            TileList.Padding = new Padding(5, 4, 5, 4);
            TileList.Size = new Size(1852, 1145);
            TileList.TabIndex = 5;
            TileList.Text = "Tile Editor";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(5, 4);
            tableLayoutPanel1.Margin = new Padding(5, 4, 5, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 250F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1842, 1137);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel2.Controls.Add(label1, 1, 0);
            tableLayoutPanel2.Controls.Add(label2, 2, 1);
            tableLayoutPanel2.Controls.Add(label3, 1, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(5, 4);
            tableLayoutPanel2.Margin = new Padding(5, 4, 5, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(1832, 242);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(5, 5);
            pictureBox1.Margin = new Padding(5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            tableLayoutPanel2.SetColumnSpan(label1, 2);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Arial", 36F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(165, 5);
            label1.Margin = new Padding(5);
            label1.Name = "label1";
            label1.Size = new Size(1662, 150);
            label1.TabIndex = 1;
            label1.Text = "Default Tile Pack";
            label1.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(1001, 165);
            label2.Margin = new Padding(5);
            label2.Name = "label2";
            label2.Size = new Size(826, 72);
            label2.TabIndex = 2;
            label2.Text = "Pack Version: 1.0.0";
            label2.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(165, 165);
            label3.Margin = new Padding(5);
            label3.Name = "label3";
            label3.Size = new Size(826, 72);
            label3.TabIndex = 3;
            label3.Text = "Game Version: 0.4.0";
            label3.TextAlign = ContentAlignment.BottomLeft;
            // 
            // FrmTileEditTool
            // 
            AutoScaleDimensions = new SizeF(31F, 60F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 43, 50);
            ClientSize = new Size(1872, 1236);
            Controls.Add(tabControl1);
            Font = new Font("Arial", 15.9000006F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            Name = "FrmTileEditTool";
            Text = "FrmTileEditTool";
            tabControl1.ResumeLayout(false);
            Overview.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Overview;
        private TabPage TileList;
        private TabPage TileCreator;
        private TabPage Settings;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}