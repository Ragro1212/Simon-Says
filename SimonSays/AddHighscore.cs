using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SimonSays
{
    public partial class AddHighscore : Form
    {
        int addedScore;
        string aDifficulty;
        public AddHighscore(int score, string difficulty)
        {
            addedScore=score;
            aDifficulty = difficulty;
            InitializeComponent();
        }

        private void bAddScore_Click(object sender, EventArgs e)
        {
            if (playerNameBox.Text != "")
            {
                string difficultyFile = "scoresNormal.txt"; // Default value in case aDifficulty doesn't match any case
                switch (aDifficulty)
                {
                    case "Easy":
                        difficultyFile = "scoresEasy.txt";
                        break;
                    case "Normal":
                        difficultyFile = "scoresNormal.txt";
                        break;
                    case "Hard":
                        difficultyFile = "scoresHard.txt";
                        break;
                }

                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, difficultyFile);
                Debug.WriteLine(filePath);

                string scoreEntry = $"{playerNameBox.Text},{addedScore}";
                Debug.WriteLine(scoreEntry);

                // Read existing scores
                List<string> scores = new List<string>();
                if (File.Exists(filePath))
                {
                    scores.AddRange(File.ReadAllLines(filePath));
                }

                // Add the new score
                scores.Add(scoreEntry);

                // Sort scores in descending order
                var sortedScores = scores
                    .Select(s => new { Score = int.Parse(s.Split(',')[1]), Entry = s })
                    .OrderByDescending(s => s.Score)
                    .Select(s => s.Entry)
                    .Take(10)
                    .ToList();

                // Write the top 10 scores back to the file
                using (StreamWriter sw = new StreamWriter(filePath, false)) // 'false' to overwrite the file
                {
                    foreach (var score in sortedScores)
                    {
                        sw.WriteLine(score);
                    }
                }

                this.Hide();
            }
        }
    }
}
