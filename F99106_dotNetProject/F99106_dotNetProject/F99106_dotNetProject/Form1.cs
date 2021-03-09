using System;
using System.Drawing;
using System.Windows.Forms;

namespace F99106_dotNetProject
{
    public partial class SaveTheMask : Form
    {
        bool goLeft;
        bool goRight;
        int speed = 8;
        int score = 0;
        int missed = 0;
        readonly Random randomX = new Random();
        readonly Random randomY = new Random();
        PictureBox splash = new PictureBox();

        public SaveTheMask()
        {
            InitializeComponent();
            RestartGame();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            txtMasks.Text = "Saved: " + score;
            txtMissed.Text = "Missed: " + missed;

            if (goLeft == true && generalM.Left > 0)
            {
                generalM.Left -= 18;
                generalM.Image = Properties.Resources.generalM_2;
            }

            if (goRight == true && generalM.Left + generalM.Width < this.ClientSize.Width)
            {
                generalM.Left += 18;
                generalM.Image = Properties.Resources.generalM;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "masks")
                {
                    x.Top += speed;

                    if (x.Top + x.Height > this.ClientSize.Height)
                    {
                        splash.Image = Properties.Resources.virus;
                        splash.Location = x.Location;
                        splash.Height = 95;
                        splash.Width = 70;
                        splash.BackColor = Color.Transparent;

                        this.Controls.Add(splash);

                        x.Top = randomY.Next(80, 300) * -1;
                        x.Left = randomX.Next(5, this.ClientSize.Width - x.Width);
                        missed += 1;
                        generalM.Image = Properties.Resources.dead;
                    }

                    if (generalM.Bounds.IntersectsWith(x.Bounds))
                    {
                        x.Top = randomY.Next(80, 300) * -1;
                        x.Left = randomX.Next(5, this.ClientSize.Width - x.Width);
                        score += 1;
                    }
                }
            }

            if (score > 12)
            {
                speed = 10;
            }

            if (missed > 5)
            {
                GameTimer.Stop();
                MessageBox.Show("Game Over!" + Environment.NewLine
                    + "Click 'OK' to retry!");

                RestartGame();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
        }

        private void RestartGame()
        {
            foreach(Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "masks")
                {
                    x.Top = randomY.Next(80, 300) * -1;
                    x.Left = randomX.Next(5, this.ClientSize.Width - x.Width);
                }
            }

            generalM.Left = this.ClientSize.Width / 2;
            generalM.Image = Properties.Resources.generalM;

            score = 0;
            missed = 0;
            speed = 8;
            goLeft = false;
            goRight = false;

            GameTimer.Start();
        }
    }
}
