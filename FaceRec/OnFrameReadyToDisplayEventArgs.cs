using Emgu.CV;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceRec
{

    public class OnFrameReadyToDisplayEventArgs : EventArgs
    {
        public Mat frame { get; set; }
    }
    public class OnDetectionReadyToDisplayEventArgs : EventArgs
    {
        public Rectangle rectangleBoundry { get; set; }
    }

}
