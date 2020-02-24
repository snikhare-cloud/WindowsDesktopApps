using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
namespace FaceRec
{
    public partial class FaceRec : Form
    {
        static Queue<Bitmap> imageSequence;
        Thread frameReadTH;
        Thread ImageProcessTH;
        Thread ImageDisplayTH;
        FrameCapturing frameCapturing;
        FrameProcessing frameProcessing;
        public FaceRec()
        {
            InitializeComponent();
            imageSequence = new Queue<Bitmap>();

        }

        [Obsolete]
        private void startToolStripMenuItem2_Click(object sender, EventArgs e)
        {
        }

        private void CameraStartMenuItem_Click(object sender, EventArgs e)
        {
            frameCapturing = new FrameCapturing(imageSequence);
            frameProcessing = new FrameProcessing(imageSequence);
            frameReadTH = new Thread(frameCapturing.Begin);
            //frameCapturing.FirstFrameAdded += FrameDisplay;
            frameReadTH.Start();


        }

        private void CameraStopMenuItem_Click(object sender, EventArgs e)
        {
            frameCapturing.End();
            frameReadTH.Abort();
        }

        private void DisplayStartMenuItem_Click(object sender, EventArgs e)
        {
            ImageDisplayTH = new Thread(FrameDisplay);
            ImageDisplayTH.Start();
        }

        private void FrameDisplay()
        {
            while(true)
            {
                if(imageSequence.Count>0)
                {
                    CamInput.Image = imageSequence.Dequeue();
                }
            }
        }

        private void DisplayStopMenuItem_Click(object sender, EventArgs e)
        {
            ImageDisplayTH.Abort();
        }
    }
}
