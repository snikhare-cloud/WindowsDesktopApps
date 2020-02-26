using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
namespace FaceRec
{
    public partial class FaceRec : Form
    {
        Queue<Mat> frames;
        //Queue<Rectangle> frames;
        Thread frameReadTH;
        Thread ImageProcessTH;
        Thread ImageDisplayTH;
        FrameCapturing frameCapturing;
        FrameProcessing frameProcessing;
        public FaceRec()
        {
            InitializeComponent();
            //imageSequence = new Queue<Image<Bgr, byte>>();
        }

        private void CameraStartMenuItem_Click(object sender, EventArgs e)
        {
            frameCapturing = new FrameCapturing();
            frames = new Queue<Mat>();
            frameReadTH = new Thread(frameCapturing.Begin);
            frameCapturing.frameReadyToDisplay += WriteImageInDisplayBox;
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

            frameProcessing = new FrameProcessing();
            frameProcessing.FrameReadyToDisplay += WriteDetectionsInDisplayBox;
            ImageDisplayTH.Start();
        }
        private void FrameDisplay()
        {
            while(true)
            {
                if(frames.Count>0)
                CamInput.Image = frames.Dequeue().Bitmap;
            }
        }
        private void WriteImageInDisplayBox(object sender, OnFrameReadyToDisplayEventArgs e)
        {
            frames.Enqueue(e.frame);
                //CamInput.Image = FrameCapturing._Frame.ToImage<Bgr, byte>().Bitmap;
                //imageSequence.Dequeue().Bitmap;

            
        }
        private void WriteDetectionsInDisplayBox(object sender, EventArgs e)
        {
            while (true)
            {
                using (Graphics g = CamInput.CreateGraphics())
                {
                    // Draw new lines and...
                   // g.Draw(Pens.Red, latestPoint, e.Location);

                    
                }
                //CamInput.Image. = FrameCapturing._Frame.ToImage<Bgr, byte>().Bitmap;
                //imageSequence.Dequeue().Bitmap;

            }
        }

        private void DisplayStopMenuItem_Click(object sender, EventArgs e)
        {
            ImageDisplayTH.Abort();
        }

        private void faceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bodyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lowerBodyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void smileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
