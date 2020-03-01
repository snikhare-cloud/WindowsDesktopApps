using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.Structure;

namespace FaceRec
{
    class FrameProcessing
    {
        public event EventHandler<OnDetectionReadyToDisplayEventArgs> detectionReadyToDisplay;
        protected virtual void OnFrameReadyToDisplay(OnDetectionReadyToDisplayEventArgs e)
        {
            EventHandler<OnDetectionReadyToDisplayEventArgs> handler = detectionReadyToDisplay;
            handler?.Invoke(this, e);
        }
        public async Task<Rectangle[]> DetectHaar(Mat frame)
        {
            try
            {
                string facePath = Path.GetFullPath(AppContext.BaseDirectory + @"..\..\xml\haarcascade_eye.xml");
                CascadeClassifier faceClassifier = new CascadeClassifier(facePath);
                //var processingImage = frame;
                //var imageGray = processingImage.Convert<Gray, byte>().Clone();
                var imageGray =  frame.ToImage<Gray, byte>().Clone();
                Rectangle[] faces =  faceClassifier.DetectMultiScale(imageGray, 1.1, 4);
                //foreach (var face in faces)
                //{
                //    processingImage.Draw(face, new Bgr(100, 100, 100), 1);
                //}
                //return processingImage.Bitmap;
                await delay();
                return  faces;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private Task delay()
        {
            throw new NotImplementedException();
        }
    }
}
