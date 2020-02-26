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
        public event EventHandler FrameReadyToDisplay;
        protected virtual void ToFrameReadyToDisplay(EventArgs e)
        {
            EventHandler handler = FrameReadyToDisplay;
            handler?. Invoke(this,e);
        }
        public Rectangle[] DetectHaar(Image<Bgr, byte> frame)
        {
            try
            {

                string facePath = Path.GetFullPath(AppContext.BaseDirectory + @"..\..\xml\haarcascade_eye.xml");
                CascadeClassifier faceClassifier = new CascadeClassifier(facePath);
                //var processingImage = frame;
                //var imageGray = processingImage.Convert<Gray, byte>().Clone();
                var imageGray = frame.Convert<Gray, byte>().Clone();
                Rectangle[] faces = faceClassifier.DetectMultiScale(imageGray, 1.1, 4);
                //foreach (var face in faces)
                //{
                //    processingImage.Draw(face, new Bgr(100, 100, 100), 1);
                //}
                //return processingImage.Bitmap;
                return faces;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
