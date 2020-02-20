using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
namespace FaceRec
{
    public partial class FaceRec : Form
    {
        VideoCapture videoCapture;
        public FaceRec()
        {
            InitializeComponent();
        }

        private void FaceRec_Load(object sender, EventArgs e)
        {
        }

        private void VideoCapture_ImageGrabbed(object sender, EventArgs e)
        {
            if (videoCapture.IsOpened)
            {
                Mat mat = new Mat();
                videoCapture.Retrieve(mat);
                Image image = mat.ToImage<Bgr,byte>().Bitmap;

                CamInput.Image = image;
            }
        }

        private void CamInput_Click(object sender, EventArgs e)
        {

        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {

                if (videoCapture == null)
                {
                    videoCapture = new Emgu.CV.VideoCapture(0);
                }
                videoCapture.ImageGrabbed += VideoCapture_ImageGrabbed;
                videoCapture.Start();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
