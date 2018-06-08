using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace EdgeDetector
{
    /// <summary>
    /// Detect edge transitions comparing the current value to the next value to the right and below.
    /// </summary>
    public class DetectSingleStep : IEdgeDetector
    {
        public string Name { get { return "Single Step"; } }
        public FrmMain.UpdateUi UpdateUi { get; set; }
        public FrmMain.EndUpdate EndUpdate { get; set; }
        public DetectorState State { get; set; }

        public DetectSingleStep()
        {
            State = DetectorState.Ready;
        }

        public override string ToString()
        {
            return "1 Step";
        }
        /// <summary>
        /// Detect edge transitions using value deltas
        /// </summary>
        /// <param name="parms">Detection parameters</param>
        public void DetectEdges(DetectorParams parms)
        {
            Bitmap srcImg = parms.SourceImage;
            int threshold = parms.Threshold;
            Bitmap destImg = new Bitmap(srcImg.Width, srcImg.Height);
            float step = 100f / (float)(srcImg.Height + 1);

            State = DetectorState.Processing;

            int[,] levels = DetectorHelper.GetChannel(srcImg, parms.Channel, UpdateUi);

            for (int y = 0; y < destImg.Height - 1 && State == DetectorState.Processing; y++)
            {
                for (int x = 0; x < destImg.Width - 1; x++)
                {
                    int dx = levels[x + 1, y] - levels[x, y];
                    int dy = levels[x, y + 1] - levels[x, y];

                    Color rgb = (dx > threshold || dy > threshold) ? Color.White : Color.Black;

                    destImg.SetPixel(x, y, rgb);
                }

                UpdateUi(50 + y * 50 / destImg.Height);
            }

            EndUpdate(destImg);
            State = DetectorState.Ready;
        }
    }
}
