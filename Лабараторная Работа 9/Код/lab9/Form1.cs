using System;
using System.Drawing;
using System.Windows.Forms;

namespace lab9
{
    public partial class Form1 : Form
    {
        private bool isGrowing = true;
        private float scaleFactor = 1.0f;
        private const float scaleIncrement = 0.01f;
        private const float maxScale = 1.2f;
        private const float minScale = 0.8f; 

        private System.Windows.Forms.Timer timerPulse;

        public Form1()
        {
            InitializeComponent();
            InitializeHeartAnimation();
        }

        private void InitializeHeartAnimation()
        {
            
            pictureBoxHeart.Image = Properties.Resources.HeartImage;
            pictureBoxHeart.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxHeart.Size = new Size(200, 200); 

            timerPulse = new System.Windows.Forms.Timer();
            timerPulse.Interval = 100;
            timerPulse.Tick += new EventHandler(timerPulse_Tick);
            timerPulse.Start();
        }

        private void timerPulse_Tick(object? sender, EventArgs e)
        {
            if (isGrowing)
            {
                scaleFactor += scaleIncrement;
                if (scaleFactor >= maxScale)
                {
                    isGrowing = false;
                }
            }
            else
            {
                scaleFactor -= scaleIncrement;
                if (scaleFactor <= minScale)
                {
                    isGrowing = true;
                }
            }

            pictureBoxHeart.Width = (int)(200 * scaleFactor); 
            pictureBoxHeart.Height = (int)(200 * scaleFactor); 
            pictureBoxHeart.Left = (this.ClientSize.Width - pictureBoxHeart.Width) / 2;
            pictureBoxHeart.Top = (this.ClientSize.Height - pictureBoxHeart.Height) / 2;
        }

        private void pictureBoxHeart_Click(object sender, EventArgs e)
        {
            pictureBoxHeart.Image = Properties.Resources.HeartImage;
        }
    }
}
