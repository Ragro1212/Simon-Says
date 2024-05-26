using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SimonSays
{
    public partial class SimonSays : Form
    {
        int score = 0;
        Random r;

        bool talk = false;
        List<int> simonSequence;
        List<int> userSequence;
        int currentIndex = 0;
        int timeDelay;
        bool timer = false;
        int timeRemaining, startingTime=5;
        int timeAdditionAfter = 0;
        string sDifficulty;

        public SimonSays(string difficulty)
        {
            sDifficulty = difficulty;
            r = new Random();
            simonSequence = new List<int>();
            userSequence = new List<int>();
            InitializeComponent();
            switch (difficulty)
            {
                case "Easy":
                    timeDelay = 400;
                    break;

                case "Normal":
                    timeDelay = 200;
                    break;

                case "Hard":
                    timeDelay = 125;
                    timer = true;
                    timeRemaining = startingTime;
                    tTimer.Text = "Time remaining: "+timeRemaining+"s";
                    break;
            }

            tDifficulty.Text = "Difficulty: " + difficulty;

        }

        private async Task Simon_Talk()
        {
            talk = true;
            await Task.Delay(timeDelay);

            foreach (int x in simonSequence)
            {
                switch (x)
                {
                    case 0:
                        pb_0.Image = SimonSaysProject.Properties.Resources.GreenDark;
                        await Task.Delay(timeDelay);
                        pb_0.Image = SimonSaysProject.Properties.Resources.Green;
                        break;

                    case 1:
                        pb_1.Image = SimonSaysProject.Properties.Resources.RedDark;
                        await Task.Delay(timeDelay);
                        pb_1.Image = SimonSaysProject.Properties.Resources.Red;
                        break;

                    case 2:
                        pb_2.Image = SimonSaysProject.Properties.Resources.YellowDark;
                        await Task.Delay(timeDelay);
                        pb_2.Image = SimonSaysProject.Properties.Resources.Yellow;
                        break;

                    case 3:
                        pb_3.Image = SimonSaysProject.Properties.Resources.BlueDark;
                        await Task.Delay(timeDelay);
                        pb_3.Image = SimonSaysProject.Properties.Resources.Blue;
                        break;
                }
                await Task.Delay(timeDelay);
            }

            talk = false;
            userSequence.Clear();
            currentIndex = 0;
            if (timer)
            {
                if (timeAdditionAfter == 3)
                {
                    startingTime++;
                    timeAdditionAfter = 0;
                }
                timeRemaining = startingTime;
                tTimer.Text = "Time remaining: "+timeRemaining+"s";
                timeAdditionAfter++;
                hardTimer.Start();
            }
        }

        private void verify_Sequence(int bPressed)
        {
            if (!talk && simonSequence.Count > 0)
            {
                userSequence.Add(bPressed);

                if (userSequence[currentIndex] == simonSequence[currentIndex])
                {
                    currentIndex++;
                    if (currentIndex == simonSequence.Count)
                    {
                        score++;
                        tScore.Text = "Score: " + score;
                        hardTimer.Stop();
                        MessageBox.Show("Correct sequence! Your score is now: " + score);
                        AddNewColorToSequence();
                        _ = Simon_Talk();
                    }
                }
                else
                {
                    if (timer)
                    {
                        hardTimer.Stop();
                        tTimer.Text = "Time remaining: 0s";
                    }
                    var saveScore = MessageBox.Show("Game Over! Wrong color picked!\nDo you want to save your score?", "", MessageBoxButtons.YesNo);
                    if (saveScore == DialogResult.Yes)
                    {
                        AddHighscore();
                    }
                    ResetGame();
                }
            }
        }

        private void AddNewColorToSequence()
        {
            simonSequence.Add(r.Next(0, 4));
        }

        private void AddHighscore()
        {
            AddHighscore addHighscore = new AddHighscore(score, sDifficulty);
            addHighscore.ShowDialog();
        }

        private void ResetGame()
        {
            score = 0;
            simonSequence.Clear();
            userSequence.Clear();
            currentIndex = 0;
            tScore.Text = "Score: 0";
            startingTime = 5;
        }

        private async void bStart_Click(object sender, EventArgs e)
        {
            ResetGame();
            AddNewColorToSequence();
            await Simon_Talk();
        }

        private void pGreen_MouseDown(object sender, MouseEventArgs e)
        {
            pb_0.Image = SimonSaysProject.Properties.Resources.GreenDark;
        }

        private void pGreen_MouseUp(object sender, MouseEventArgs e)
        {
            pb_0.Image = SimonSaysProject.Properties.Resources.Green;
            verify_Sequence(0);
        }

        private void pRed_MouseDown(object sender, MouseEventArgs e)
        {
            pb_1.Image = SimonSaysProject.Properties.Resources.RedDark;
        }

        private void pRed_MouseUp(object sender, MouseEventArgs e)
        {
            pb_1.Image = SimonSaysProject.Properties.Resources.Red;
            verify_Sequence(1);
        }

        private void pYellow_MouseDown(object sender, MouseEventArgs e)
        {
            pb_2.Image = SimonSaysProject.Properties.Resources.YellowDark;
        }

        private void pYellow_MouseUp(object sender, MouseEventArgs e)
        {
            pb_2.Image = SimonSaysProject.Properties.Resources.Yellow;
            verify_Sequence(2);
        }

        private void pBlue_MouseDown(object sender, MouseEventArgs e)
        {
            pb_3.Image = SimonSaysProject.Properties.Resources.BlueDark;
        }

        private void pBlue_MouseUp(object sender, MouseEventArgs e)
        {
            pb_3.Image = SimonSaysProject.Properties.Resources.Blue;
            verify_Sequence(3);
        }

        private void bHighscores_Click(object sender, EventArgs e)
        {
            Highscores highscores = new Highscores();
            highscores.ShowDialog();
        }

        private void bMenu_Click(object sender, EventArgs e)
        {
            hardTimer.Stop();
            Menu menu = new Menu();
            this.Hide();
            menu.ShowDialog();
        }

        private void hardTimer_Tick(object sender, EventArgs e)
        {
            timeRemaining--;
            if (timeRemaining <= 0)
            {


                hardTimer.Stop();
                tTimer.Text = "Time remaining: 0s";
                var saveScore = MessageBox.Show("Game Over! The timer has elapsed!\nDo you want to save your score?", "", MessageBoxButtons.YesNo);
                if (saveScore == DialogResult.Yes)
                {
                    AddHighscore();
                }
                ResetGame();
            }
            else
            {
                tTimer.Text = "Time remaining: " + timeRemaining + "s";
            }
        }
    }
}