namespace SimonSays
{
    partial class Highscores
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
            lEasy = new ListBox();
            lNormal = new ListBox();
            lHard = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // lEasy
            // 
            lEasy.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lEasy.FormattingEnabled = true;
            lEasy.ItemHeight = 20;
            lEasy.Location = new Point(2, 30);
            lEasy.Name = "lEasy";
            lEasy.Size = new Size(146, 184);
            lEasy.TabIndex = 0;
            // 
            // lNormal
            // 
            lNormal.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lNormal.FormattingEnabled = true;
            lNormal.ItemHeight = 20;
            lNormal.Location = new Point(154, 30);
            lNormal.Name = "lNormal";
            lNormal.Size = new Size(150, 184);
            lNormal.TabIndex = 1;
            // 
            // lHard
            // 
            lHard.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lHard.FormattingEnabled = true;
            lHard.ItemHeight = 20;
            lHard.Location = new Point(310, 30);
            lHard.Name = "lHard";
            lHard.Size = new Size(146, 184);
            lHard.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(44, 3);
            label1.Name = "label1";
            label1.Size = new Size(41, 21);
            label1.TabIndex = 3;
            label1.Text = "Easy";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(194, 3);
            label2.Name = "label2";
            label2.Size = new Size(64, 21);
            label2.TabIndex = 4;
            label2.Text = "Normal";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.Location = new Point(360, 3);
            label3.Name = "label3";
            label3.Size = new Size(46, 21);
            label3.TabIndex = 5;
            label3.Text = "Hard";
            // 
            // Highscores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 216);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lHard);
            Controls.Add(lNormal);
            Controls.Add(lEasy);
            Name = "Highscores";
            Text = "Highscores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lEasy;
        private ListBox lNormal;
        private ListBox lHard;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}