using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace EdgeDetector
{
    /// <summary>
    /// Helper class for Edge Detectors
    /// </summary>
    class DetectorHelper
    {
        public static List<IEdgeDetector> Detectors = new List<IEdgeDetector>()
        {
            new DetectSingleStep(),
            new DetectMultiStep()
        };

        /// <summary>
        /// Retrieve all values from an image based on channel
        /// </summary>
        /// <param name="img">Image to analyze</param>
        /// <param name="channel">Color channel to extract</param>
        /// <param name="updateUi">Callback to monitor progress</param>
        /// <returns></returns>
        public static int[,] GetChannel(Bitmap img, DetectorChannel channel, FrmMain.UpdateUi updateUi)
        {
            int[,] levels = new int[img.Width, img.Height];
            int rx = 299;
            int gx = 587;
            int bx = 114;

            switch (channel)
            {
                case DetectorChannel.None:
                    // Invalid setting!
                    return null;
                case DetectorChannel.Brightness:
                    break;
                case DetectorChannel.Red:
                    rx = 1000;
                    gx = 0;
                    bx = 0;
                    break;
                case DetectorChannel.Green:
                    rx = 0;
                    gx = 1000;
                    bx = 0;
                    break;
                case DetectorChannel.Blue:
                    rx = 0;
                    gx = 0;
                    bx = 1000;
                    break;
                case DetectorChannel.RedGreen:
                    rx = 400;
                    gx = 600;
                    bx = 0;
                    break;
                case DetectorChannel.RedBlue:
                    rx = 700;
                    gx = 0;
                    bx = 300;
                    break;
                case DetectorChannel.GreenBlue:
                    rx = 0;
                    gx = 700;
                    bx = 300;
                    break;
                case DetectorChannel.Hue:
                    for (int y = 0; y < img.Height; y++)
                    {
                        for (int x = 0; x < img.Width; x++)
                        {
                            Color rgb = img.GetPixel(x, y);

                            levels[x, y] = (int)(rgb.GetHue() * 10000f);
                        }

                        updateUi(y * 50 / img.Height);
                    }

                    return levels;
            }

            // Generic transform (all except hue)
            for (int y = 0; y < img.Height; y++)
            {
                for (int x = 0; x < img.Width; x++)
                {
                    Color rgb = img.GetPixel(x, y);

                    levels[x, y] = rx * rgb.R + gx * rgb.G + bx * rgb.B;
                }

                updateUi(y * 50 / img.Height);
            }

            return levels;
        }
    }
}
