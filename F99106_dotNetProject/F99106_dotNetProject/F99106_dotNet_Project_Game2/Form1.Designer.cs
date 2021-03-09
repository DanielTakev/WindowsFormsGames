namespace F99106_dotNet_Project_Game2
{
    partial class FormCorona
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCorona));
            this.ground = new System.Windows.Forms.PictureBox();
            this.virusTwo = new System.Windows.Forms.PictureBox();
            this.virusOne = new System.Windows.Forms.PictureBox();
            this.generalM = new System.Windows.Forms.PictureBox();
            this.txtScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.virusTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.virusOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalM)).BeginInit();
            this.SuspendLayout();
            // 
            // ground
            // 
            this.ground.Image = ((System.Drawing.Image)(resources.GetObject("ground.Image")));
            this.ground.Location = new System.Drawing.Point(-11, 346);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(1072, 113);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 0;
            this.ground.TabStop = false;
            // 
            // virusTwo
            // 
            this.virusTwo.Image = ((System.Drawing.Image)(resources.GetObject("virusTwo.Image")));
            this.virusTwo.Location = new System.Drawing.Point(887, 312);
            this.virusTwo.Name = "virusTwo";
            this.virusTwo.Size = new System.Drawing.Size(50, 41);
            this.virusTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.virusTwo.TabIndex = 1;
            this.virusTwo.TabStop = false;
            this.virusTwo.Tag = "viruses";
            // 
            // virusOne
            // 
            this.virusOne.Image = ((System.Drawing.Image)(resources.GetObject("virusOne.Image")));
            this.virusOne.Location = new System.Drawing.Point(574, 312);
            this.virusOne.Name = "virusOne";
            this.virusOne.Size = new System.Drawing.Size(55, 41);
            this.virusOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.virusOne.TabIndex = 1;
            this.virusOne.TabStop = false;
            this.virusOne.Tag = "viruses";
            // 
            // generalM
            // 
            this.generalM.Image = ((System.Drawing.Image)(resources.GetObject("generalM.Image")));
            this.generalM.Location = new System.Drawing.Point(179, 312);
            this.generalM.Name = "generalM";
            this.generalM.Size = new System.Drawing.Size(54, 41);
            this.generalM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.generalM.TabIndex = 2;
            this.generalM.TabStop = false;
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtScore.Location = new System.Drawing.Point(38, 27);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(119, 38);
            this.txtScore.TabIndex = 3;
            this.txtScore.Text = "Score: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.MainGameTimerEvent);
            // 
            // FormCorona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1040, 450);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.generalM);
            this.Controls.Add(this.virusOne);
            this.Controls.Add(this.virusTwo);
            this.Controls.Add(this.ground);
            this.Name = "FormCorona";
            this.Text = "Escape Corona";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.virusTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.virusOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox virusTwo;
        private System.Windows.Forms.PictureBox virusOne;
        private System.Windows.Forms.PictureBox generalM;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Timer gameTimer;
    }
}

