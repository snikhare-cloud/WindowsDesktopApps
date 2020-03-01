using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
namespace FaceRec
{
    public partial class FaceRec : Form
    {
        ConcurrentQueue<Mat> frames;
        //Queue<Rectangle> frames;
        Thread frameReadTH;
        Thread imageDisplayTH;
        Thread faceDetectTH;
        FrameCapturing frameCapturing;
        FrameProcessing frameProcessing;
        public FaceRec()
        {
            InitializeComponent();
            //imageSequence = new Queue<Image<Bgr, byte>>();
        }
        private void CameraStartMenuItem_Click(object sender, EventArgs e)
        {
            frameProcessing = new FrameProcessing();
            frameCapturing = new FrameCapturing();
            frames = new ConcurrentQueue<Mat>();
            frameReadTH = new Thread(frameCapturing.Begin);
            frameCapturing.frameReadyToDisplay += WriteImageInDisplayBox;
            frameReadTH.Start();
        }
        private void CameraStopMenuItem_Click(object sender, EventArgs e)
        {
            if (frameCapturing != null)
                frameCapturing.End();
            if (frameReadTH != null)
                frameReadTH.Abort();
        }
        private void DisplayStartMenuItem_Click(object sender, EventArgs e)
        {
            imageDisplayTH = new Thread(FrameDisplay);
            imageDisplayTH.Start();
        }

        private async void faceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (faceToolStripMenuItem.Checked)
                {
                    frameProcessing = new FrameProcessing();
                    //frameProcessing.detectionReadyToDisplay += WriteDetectionsInDisplayBox;   
                    faceDetectTH = new Thread(FaceDetectionLoop);
                    faceDetectTH.Start();
                }
                else
                {
                    faceDetectTH.Abort();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
        private void FrameDisplay()
        {
            try
            {
                while (true)
                {
                    Mat topFrame;
                    if (frames.TryPeek(out topFrame))
                    {
                        Bitmap localFrameBitmap = topFrame.Bitmap;
                        CamInput.Image = localFrameBitmap;
                        Thread.Sleep(10);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void WriteImageInDisplayBox(object sender, OnFrameReadyToDisplayEventArgs e)
        {
            try
            {
                if (frames.Count >= 10)
                {
                    Mat topFrame;
                    if (frames.TryDequeue(out topFrame))
                    {
                        frames.Enqueue(e.frame);
                    }
                }
                else
                {
                    frames.Enqueue(e.frame);
                }
                //CamInput.Image = e.frame.Bitmap;
                //imageSequence.Dequeue().Bitmap;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void WriteDetectionsInDisplayBox(object sender, EventArgs e)
        {
            //while (true)
            //{
            //    using (Graphics g = CamInput.CreateGraphics())
            //    {
            //        // Draw new lines and...
            //        // g.Draw(Pens.Red, latestPoint, e.Location);                    
            //    }
            //    //CamInput.Image. = FrameCapturing._Frame.ToImage<Bgr, byte>().Bitmap;
            //    //imageSequence.Dequeue().Bitmap;
            //}
        }
        private void DisplayStopMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (imageDisplayTH != null)
                    imageDisplayTH.Abort();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private async void FaceDetectionLoop()
        {
            Rectangle[] rectangles;
            try
            {
                while (true)
                {
                    if (frames.Count > 0)
                    {
                        Mat topFrame;
                        if (frames.TryPeek(out topFrame))
                        {
                            //CamInput.Image = topFrame.Bitmap;

                            rectangles = frameProcessing.DetectHaar(topFrame);


                            //CamInput.Image = topFrame.Bitmap;

                            if (rectangles.Length > 0)
                            {
                                using (Graphics g = CamInput.CreateGraphics())
                                {
                                    // Draw new lines and...
                                    g.DrawRectangles(Pens.Red, rectangles);
                                }
                            }
                        }
                        Thread.Sleep(10);
                    }
                }
            }
            catch (Exception ex)
            {
                //throw ex;
            }
        }
    }
}
