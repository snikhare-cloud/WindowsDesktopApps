using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.Structure;

namespace FaceRec
{
    class FrameCapturing
    {
        private VideoCapture _Capture;
        private Mat _Frame;
        private Queue<Bitmap> imageSequence;
        protected virtual void OnFirstFrameAdded(EventArgs e)
        {
            FirstFrameAdded?.Invoke(this, e);
        }

        public event EventHandler FirstFrameAdded;
        public FrameCapturing(Queue<Bitmap> imageSequence)
        {
            _Capture = new VideoCapture(0);
            this.imageSequence = imageSequence;
        }
        private void GetCameraFrame(object sender, EventArgs e)
        {
            if (_Capture != null && _Capture.Ptr != IntPtr.Zero && _Capture.IsOpened)
            {

                if (this.imageSequence.Count < 200)
                {
                    _Capture.Retrieve(_Frame, 0);
                    this.imageSequence.Enqueue(_Frame.Bitmap);
                }

                if (this.imageSequence.Count > 1 && this.imageSequence.Count <= 2)
                    OnFirstFrameAdded(EventArgs.Empty);
            }
        }
        public void Begin()
        {
            if (_Capture == null) _Capture = new VideoCapture(0);            
            _Capture.ImageGrabbed += GetCameraFrame;
            _Frame = new Mat();
            Mat mat = new Mat();
            try
            {
                _Capture.Start();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }
        public void End()
        {
            try
            {
                if (_Capture != null)
                    _Capture.Stop();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }
    }



}
