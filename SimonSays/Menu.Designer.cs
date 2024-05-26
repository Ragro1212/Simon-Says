namespace SimonSays
{
    partial class Menu
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
            label1 = new Label();
            bPlay = new Button();
            bHighscores = new Button();
            bExit = new Button();
            difficultyBox = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SuperFrench", 27.7499962F, FontStyle.Italic, GraphicsUnit.Point, 2);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(22, 9);
            label1.Name = "label1";
            label1.Size = new Size(189, 38);
            label1.TabIndex = 0;
            label1.Text = "Simon Says";
            // 
            // bPlay
            // 
            bPlay.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bPlay.Location = new Point(22, 56);
            bPlay.Name = "bPlay";
            bPlay.Size = new Size(189, 35);
            bPlay.TabIndex = 1;
            bPlay.Text = "Play";
            bPlay.UseVisualStyleBackColor = true;
            bPlay.Click += bPlay_Click;
            // 
            // bHighscores
            // 
            bHighscores.Location = new Point(22, 126);
            bHighscores.Name = "bHighscores";
            bHighscores.Size = new Size(189, 35);
            bHighscores.TabIndex = 2;
            bHighscores.Text = "Highscores";
            bHighscores.UseVisualStyleBackColor = true;
            bHighscores.Click += bHighscores_Click;
            // 
            // bExit
            // 
            bExit.Location = new Point(22, 182);
            bExit.Name = "bExit";
            bExit.Size = new Size(189, 38);
            bExit.TabIndex = 3;
            bExit.Text = "Exit";
            bExit.UseVisualStyleBackColor = true;
            bExit.Click += bExit_Click;
            // 
            // difficultyBox
            // 
            difficultyBox.FormattingEnabled = true;
            difficultyBox.Items.AddRange(new object[] { "Easy", "Normal", "Hard" });
            difficultyBox.Location = new Point(22, 97);
            difficultyBox.Name = "difficultyBox";
            difficultyBox.Size = new Size(75, 23);
            difficultyBox.TabIndex = 4;
            difficultyBox.Text = "Normal";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(232, 232);
            Controls.Add(difficultyBox);
            Controls.Add(bExit);
            Controls.Add(bHighscores);
            Controls.Add(bPlay);
            Controls.Add(label1);
            Name = "Menu";
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button bPlay;
        private Button bHighscores;
        private Button bExit;
        private ComboBox difficultyBox;
    }
}