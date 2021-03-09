namespace F99106_dotNet_Project_Game3
{
    partial class CounterStrike
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CounterStrike));
            this.generalM = new System.Windows.Forms.PictureBox();
            this.secondWall = new System.Windows.Forms.PictureBox();
            this.firstWall = new System.Windows.Forms.PictureBox();
            this.virus = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.txtScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.generalM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.virus)).BeginInit();
            this.SuspendLayout();
            // 
            // generalM
            // 
            this.generalM.Image = ((System.Drawing.Image)(resources.GetObject("generalM.Image")));
            this.generalM.Location = new System.Drawing.Point(36, 187);
            this.generalM.Name = "generalM";
            this.generalM.Size = new System.Drawing.Size(85, 72);
            this.generalM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.generalM.TabIndex = 0;
            this.generalM.TabStop = false;
            // 
            // secondWall
            // 
            this.secondWall.Image = ((System.Drawing.Image)(resources.GetObject("secondWall.Image")));
            this.secondWall.Location = new System.Drawing.Point(351, 1);
            this.secondWall.Name = "secondWall";
            this.secondWall.Size = new System.Drawing.Size(64, 175);
            this.secondWall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.secondWall.TabIndex = 1;
            this.secondWall.TabStop = false;
            this.secondWall.Tag = "wall";
            // 
            // firstWall
            // 
            this.firstWall.Image = ((System.Drawing.Image)(resources.GetObject("firstWall.Image")));
            this.firstWall.Location = new System.Drawing.Point(604, 287);
            this.firstWall.Name = "firstWall";
            this.firstWall.Size = new System.Drawing.Size(64, 175);
            this.firstWall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.firstWall.TabIndex = 1;
            this.firstWall.TabStop = false;
            this.firstWall.Tag = "wall";
            // 
            // virus
            // 
            this.virus.Image = ((System.Drawing.Image)(resources.GetObject("virus.Image")));
            this.virus.Location = new System.Drawing.Point(691, 108);
            this.virus.Name = "virus";
            this.virus.Size = new System.Drawing.Size(88, 68);
            this.virus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.virus.TabIndex = 2;
            this.virus.TabStop = false;
            this.virus.Tag = "virus";
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.MainGameTimerEvent);
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtScore.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtScore.Location = new System.Drawing.Point(15, 11);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(119, 38);
            this.txtScore.TabIndex = 3;
            this.txtScore.Text = "Score: 0";
            // 
            // CounterStrike
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(919, 461);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.virus);
            this.Controls.Add(this.firstWall);
            this.Controls.Add(this.secondWall);
            this.Controls.Add(this.generalM);
            this.Name = "CounterStrike";
            this.Text = "Mutafchiyski Counter-Strike";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.generalM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.virus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox generalM;
        private System.Windows.Forms.PictureBox secondWall;
        private System.Windows.Forms.PictureBox firstWall;
        private System.Windows.Forms.PictureBox virus;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label txtScore;
    }
}

