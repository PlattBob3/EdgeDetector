using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace EdgeDetector
{
    /// <summary>
    /// Interface for edge detector algorythms
    /// </summary>
    public interface IEdgeDetector
    {
        /// <summary>
        /// Name of the detector
        /// </summary>
        string Name { get; }
        /// <summary>
        /// Execute detection on an image
        /// </summary>
        /// <param name="parms">Detection parameters, source and destination images</param>
        void DetectEdges(DetectorParams parms);
        /// <summary>
        /// Get: activity state
        /// Set: abort current activity
        /// </summary>
        DetectorState State { get; set; }
        /// <summary>
        /// Injector for progress updates
        /// </summary>
        FrmMain.UpdateUi UpdateUi { get; set; }
        /// <summary>
        /// Injector for process completion
        /// </summary>
        FrmMain.EndUpdate EndUpdate { get; set; }
    }

    /// <summary>
    /// Execution state
    /// </summary>
    public enum DetectorState
    {
        Ready,
        Processing,
        Abort
    }

    /// <summary>
    /// Channel(s) to use for detection
    /// </summary>
    public enum DetectorChannel
    {
        None,
        Brightness,
        Red,
        Green,
        Blue,
        RedGreen,
        RedBlue,
        GreenBlue,
        Hue
    }
}
