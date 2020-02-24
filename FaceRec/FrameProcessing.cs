using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceRec
{
    class FrameProcessing
    {
        private Queue<Bitmap> imageSequence;

        public FrameProcessing(Queue<Bitmap> imageSequence)
        {
            this.imageSequence = imageSequence;
        }

        private void Begin(object sender, EventArgs e)
        {
            Bitmap bt = new Bitmap(400, 320);
            //bt.

            //imageSequence.Peek().Width = (int)200;
        }

    }
}
