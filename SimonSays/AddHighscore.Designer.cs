namespace SimonSays
{
    partial class AddHighscore
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
            playerNameBox = new TextBox();
            bAddScore = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(132, 25);
            label1.TabIndex = 0;
            label1.Text = "Enter a name: ";
            // 
            // playerNameBox
            // 
            playerNameBox.Location = new Point(139, 12);
            playerNameBox.Name = "playerNameBox";
            playerNameBox.Size = new Size(147, 23);
            playerNameBox.TabIndex = 1;
            // 
            // bAddScore
            // 
            bAddScore.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            bAddScore.Location = new Point(211, 47);
            bAddScore.Name = "bAddScore";
            bAddScore.Size = new Size(75, 31);
            bAddScore.TabIndex = 2;
            bAddScore.Text = "Add";
            bAddScore.UseVisualStyleBackColor = true;
            bAddScore.Click += bAddScore_Click;
            // 
            // AddHighscore
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(298, 82);
            Controls.Add(bAddScore);
            Controls.Add(playerNameBox);
            Controls.Add(label1);
            Name = "AddHighscore";
            Text = "Add Score";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox playerNameBox;
        private Button bAddScore;
    }
}