using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimonSays
{
    public partial class Highscores : Form
    {
        public Highscores()
        {
            InitializeComponent();
            LoadScores();
        }

        private void LoadScores()
        {
            LoadScoresFromFile("scoresEasy.txt", lEasy);
            LoadScoresFromFile("scoresNormal.txt", lNormal);
            LoadScoresFromFile("scoresHard.txt", lHard);
        }

        private void LoadScoresFromFile(string fileName, ListBox listBox)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

            if (File.Exists(filePath))
            {
                var scores = File.ReadAllLines(filePath)
                                 .Select(s => s.Replace(",", ": "))
                                 .ToList();

                listBox.Items.Clear();
                listBox.Items.AddRange(scores.ToArray());
            }
            else
            {
                listBox.Items.Clear();
                listBox.Items.Add("No scores available.");
            }
        }
    }
}
