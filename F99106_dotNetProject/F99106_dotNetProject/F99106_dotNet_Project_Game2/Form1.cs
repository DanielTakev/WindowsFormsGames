using System;
using System.Windows.Forms;

namespace F99106_dotNet_Project_Game2
{
    public partial class FormCorona : Form
    {
        bool jumping = false;
        int jumpSpeed;
        int force = 20;
        int score = 0;
        int viruseSpeed = 10;
        readonly Random random = new Random();
        int position;
        bool isGameOver = false;

        public FormCorona()
        {
            InitializeComponent();
            GameReset();
        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            generalM.Top += jumpSpeed;

            txtScore.Text = "Score: " + score;

            if (jumping == true && force < 0)
            {
                jumping = false;
            }

            if (jumping == true)
            {
                jumpSpeed = -12;
                force -= 1;
            }
            else
            {
                jumpSpeed = 12;
            }

            if (generalM.Top > 311 && jumping == false)
            {
                force = 20;
                generalM.Top = 312;
                jumpSpeed = 0;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "viruses")
                {
                    x.Left -= viruseSpeed;
                    if (x.Left < -100)
                    {
                        x.Left = this.ClientSize.Width + random.Next(200, 650) + (x.Width + 15);
                        score++;
                    }

                    if (generalM.Bounds.IntersectsWith(x.Bounds))
                    {
                        gameTimer.Stop();
                        generalM.Image = Properties.Resources.dead;
                        txtScore.Text += " Press 'R' to restart the game.";
                        isGameOver = true;
                    }
                }
            }

            if (score > 6)
            {
                viruseSpeed = 12;
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && jumping == false)
            {
                jumping = true;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (jumping == true)
            {
                jumping = false;
            }

            if (e.KeyCode == Keys.R && isGameOver == true)
            {
                GameReset();
            }
        }

        private void GameReset()
        {
            force = 20;
            jumpSpeed = 0;
            jumping = false;
            score = 0;
            viruseSpeed = 10;
            txtScore.Text = "Score: " + score;
            generalM.Image = Properties.Resources.generalM;
            isGameOver = false;
            generalM.Top = 312;

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "viruses")
                {
                    position = this.ClientSize.Width + random.Next(400, 900) + (x.Width * 10);

                    x.Left = position;
                }
            }

            gameTimer.Start();
        }
    }
}
