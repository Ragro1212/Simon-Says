namespace SimonSays
{
    partial class SimonSays
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
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            pb_0 = new PictureBox();
            pb_1 = new PictureBox();
            pb_2 = new PictureBox();
            pb_3 = new PictureBox();
            tScore = new Label();
            bStart = new Button();
            bHighscores = new Button();
            bMenu = new Button();
            tDifficulty = new Label();
            hardTimer = new System.Windows.Forms.Timer(components);
            tTimer = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_0).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_3).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(pb_0, 0, 0);
            tableLayoutPanel1.Controls.Add(pb_1, 1, 0);
            tableLayoutPanel1.Controls.Add(pb_2, 0, 1);
            tableLayoutPanel1.Controls.Add(pb_3, 1, 1);
            tableLayoutPanel1.Location = new Point(46, 124);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(310, 270);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pb_0
            // 
            pb_0.Dock = DockStyle.Fill;
            pb_0.Image = SimonSaysProject.Properties.Resources.Green;
            pb_0.Location = new Point(3, 3);
            pb_0.Name = "pb_0";
            pb_0.Size = new Size(149, 129);
            pb_0.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_0.TabIndex = 0;
            pb_0.TabStop = false;
            pb_0.MouseDown += pGreen_MouseDown;
            pb_0.MouseUp += pGreen_MouseUp;
            // 
            // pb_1
            // 
            pb_1.Dock = DockStyle.Fill;
            pb_1.Image = SimonSaysProject.Properties.Resources.Red;
            pb_1.Location = new Point(158, 3);
            pb_1.Name = "pb_1";
            pb_1.Size = new Size(149, 129);
            pb_1.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_1.TabIndex = 1;
            pb_1.TabStop = false;
            pb_1.MouseDown += pRed_MouseDown;
            pb_1.MouseUp += pRed_MouseUp;
            // 
            // pb_2
            // 
            pb_2.Dock = DockStyle.Fill;
            pb_2.Image = SimonSaysProject.Properties.Resources.Yellow;
            pb_2.Location = new Point(3, 138);
            pb_2.Name = "pb_2";
            pb_2.Size = new Size(149, 129);
            pb_2.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_2.TabIndex = 2;
            pb_2.TabStop = false;
            pb_2.MouseDown += pYellow_MouseDown;
            pb_2.MouseUp += pYellow_MouseUp;
            // 
            // pb_3
            // 
            pb_3.Dock = DockStyle.Fill;
            pb_3.Image = SimonSaysProject.Properties.Resources.Blue;
            pb_3.Location = new Point(158, 138);
            pb_3.Name = "pb_3";
            pb_3.Size = new Size(149, 129);
            pb_3.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_3.TabIndex = 3;
            pb_3.TabStop = false;
            pb_3.MouseDown += pBlue_MouseDown;
            pb_3.MouseUp += pBlue_MouseUp;
            // 
            // tScore
            // 
            tScore.AutoSize = true;
            tScore.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            tScore.Location = new Point(123, 45);
            tScore.Name = "tScore";
            tScore.Size = new Size(160, 50);
            tScore.TabIndex = 1;
            tScore.Text = "Score: 0";
            // 
            // bStart
            // 
            bStart.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            bStart.Location = new Point(82, 409);
            bStart.Name = "bStart";
            bStart.Size = new Size(240, 51);
            bStart.TabIndex = 3;
            bStart.Text = "New Round";
            bStart.UseVisualStyleBackColor = true;
            bStart.Click += bStart_Click;
            // 
            // bHighscores
            // 
            bHighscores.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            bHighscores.Location = new Point(285, 12);
            bHighscores.Name = "bHighscores";
            bHighscores.Size = new Size(113, 26);
            bHighscores.TabIndex = 4;
            bHighscores.Text = "See Highscores";
            bHighscores.UseVisualStyleBackColor = true;
            bHighscores.Click += bHighscores_Click;
            // 
            // bMenu
            // 
            bMenu.Location = new Point(347, 45);
            bMenu.Name = "bMenu";
            bMenu.Size = new Size(51, 23);
            bMenu.TabIndex = 5;
            bMenu.Text = "Menu";
            bMenu.UseVisualStyleBackColor = true;
            bMenu.Click += bMenu_Click;
            // 
            // tDifficulty
            // 
            tDifficulty.AutoSize = true;
            tDifficulty.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 238);
            tDifficulty.Location = new Point(137, 95);
            tDifficulty.Name = "tDifficulty";
            tDifficulty.Size = new Size(133, 21);
            tDifficulty.TabIndex = 6;
            tDifficulty.Text = "Difficulty: Normal";
            // 
            // hardTimer
            // 
            hardTimer.Interval = 1000;
            hardTimer.Tick += hardTimer_Tick;
            // 
            // tTimer
            // 
            tTimer.AutoSize = true;
            tTimer.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            tTimer.Location = new Point(276, 98);
            tTimer.Name = "tTimer";
            tTimer.Size = new Size(0, 17);
            tTimer.TabIndex = 7;
            // 
            // SimonSays
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 472);
            Controls.Add(tTimer);
            Controls.Add(tDifficulty);
            Controls.Add(bMenu);
            Controls.Add(bHighscores);
            Controls.Add(bStart);
            Controls.Add(tScore);
            Controls.Add(tableLayoutPanel1);
            Name = "SimonSays";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pb_0).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pb_0;
        private PictureBox pb_1;
        private PictureBox pb_2;
        private PictureBox pb_3;
        private Label tScore;
        private Button bStart;
        private Button bHighscores;
        private Button bMenu;
        private Label tDifficulty;
        private System.Windows.Forms.Timer hardTimer;
        private Label tTimer;
    }
}
