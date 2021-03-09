using System;
using System.Drawing;
using System.Windows.Forms;

namespace F99106_dotNet_Project_Game3
{
    public partial class CounterStrike : Form
    {
        bool goUp;
        bool goDown;
        bool shot;
        bool gameOver;
        int score = 0;
        int speed = 7;
        int virusSpeed = 9;
        int generalSpeed = 11;
        int changeIndex = 0;
        Random random = new Random();


        public CounterStrike()
        {
            InitializeComponent();
        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            txtScore.Text = "Score: " + score;

            if (goUp == true && generalM.Top > 0)
            {
                generalM.Top -= generalSpeed;
            }

            if (goDown == true && generalM.Top + generalM.Height < this.ClientSize.Height)
            {
                generalM.Top += generalSpeed;
            }

            virus.Left -= virusSpeed;

            if (virus.Left + virus.Width < 0)
            {
                ChangeVirus();
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x .Tag == "wall")
                {
                    x.Left -= speed; 

                    if (x.Left < -200)
                    {
                        x.Left = 1000;
                    }

                    if (generalM.Bounds.IntersectsWith(x.Bounds))
                    {
                        GameOver();
                    }
                }

                if (x is PictureBox && (string)x.Tag == "bullet")
                {
                    x.Left += 25;

                    if (x.Left > 900)
                    {
                        RemoveBullet(((PictureBox)x));
                    }

                    if (virus.Bounds.IntersectsWith(x.Bounds))
                    {
                        RemoveBullet(((PictureBox)x));
                        score += 1;

                        ChangeVirus();
                    }
                }
            }

            if (generalM.Bounds.IntersectsWith(virus.Bounds))
            {
                GameOver();
            }

            // Level 2
            if (score > 10)
            {
                speed = 10;
                virusSpeed = 14;
            }
            // Level 3
            if (score > 20)
            {
                speed = 12;
                virusSpeed = 16;
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
            }

            if (e.KeyCode == Keys.Space && shot == false)
            {
                MakeBullet();
                shot = true;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }

            if (shot == true)
            {
                shot = false;
            }

            if (e.KeyCode == Keys.Enter && gameOver == true)
            {
                RestartGame();
            }
        }

        private void RestartGame()
        {
            goUp = false;
            goDown = false;
            shot = false;
            gameOver = false;
            score = 0;
            speed = 7;
            virusSpeed = 9;
            txtScore.Text = "Score: " + score;
            ChangeVirus();

            generalM.Top = 187;
            firstWall.Left = 604;
            secondWall.Left = 351;

            GameTimer.Start();
        }

        private void GameOver()
        {
            GameTimer.Stop();
            txtScore.Text = "Score: " + score + " Game Over! Press ENTER to retry!";
            gameOver = true;
        }

        private void RemoveBullet(PictureBox bullet)
        {
            this.Controls.Remove(bullet);
            bullet.Dispose();
        }

        private void MakeBullet()
        {
            PictureBox bullet = new PictureBox();
            bullet.BackColor = Color.Maroon;
            bullet.Height = 5;
            bullet.Width = 10;

            bullet.Left = generalM.Left + generalM.Width;
            bullet.Top = generalM.Top + (generalM.Height / 2);

            bullet.Tag = "bullet";
            this.Controls.Add(bullet);
        }

        private void ChangeVirus()
        {
            if (changeIndex > 3)
            {
                changeIndex = 1;
            }
            else
            {
                changeIndex += 1;
            }

            switch (changeIndex)
            {
                case 1: 
                    virus.Image = Properties.Resources.virus_main;
                    break;
                case 2:
                    virus.Image = Properties.Resources.virus_2;
                    break;
                case 3:
                    virus.Image = Properties.Resources.virus_3;
                    break;
            }

            virus.Left = 1000;
            virus.Top = random.Next(21, this.ClientSize.Height - virus.Height);
        }
    }
}
