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

        public event EventHandler<OnFrameReadyToDisplayEventArgs> frameReadyToDisplay;
        protected virtual void OnFrameReadyToDisplay(OnFrameReadyToDisplayEventArgs e)
        {
            EventHandler< OnFrameReadyToDisplayEventArgs> handler = frameReadyToDisplay;
            handler?.Invoke(this, e);
        }
        //public static Mat _Frame { get; set; }

        public FrameCapturing()
        {
            _Capture = new VideoCapture(0);
        }
        private void GetCameraFrame(object sender, EventArgs e)
        {
            Mat localFrame = new Mat();
            if (_Capture != null && _Capture.Ptr != IntPtr.Zero && _Capture.IsOpened)
            {
                _Capture.Retrieve(localFrame, 0);
                //_Frame = localFrame;
                OnFrameReadyToDisplayEventArgs args = new OnFrameReadyToDisplayEventArgs();
                args.frame = localFrame;
                OnFrameReadyToDisplay(args);
            }
        }
        public void Begin()
        {
            if (_Capture == null) _Capture = new VideoCapture(0);
            _Capture.ImageGrabbed += GetCameraFrame;
            //_Frame = new Mat();
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

    public class OnFrameReadyToDisplayEventArgs : EventArgs
    {
        public Mat frame { get; set; }
    }

}
