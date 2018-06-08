using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace EdgeDetector
{
    /// <summary>
    /// Parameters used to generate an edge transition image
    /// </summary>
    public class DetectorParams
    {
        /// <summary>
        /// Source image for edge detection
        /// </summary>
        public Bitmap SourceImage { get; set; }
        /// <summary>
        /// Image resulting from edge detection
        /// </summary>
        public Bitmap DestImage { get; set; }
        /// <summary>
        /// Edge detector class
        /// </summary>
        public IEdgeDetector Detector { get; set; }
        /// <summary>
        /// Detection threshold
        /// </summary>
        public int Threshold { get; set; }
        /// <summary>
        /// Channel to extract from the source image
        /// </summary>
        public DetectorChannel Channel { get; set; }

        public DetectorParams()
        {
            Detector = null;
            Threshold = 0;
            Channel = DetectorChannel.None;
        }
        public void StartDetection()
        {
            if (Detector != null && Channel != DetectorChannel.None)
            {
                Detector.DetectEdges(this);
            }
        }
    }
}
