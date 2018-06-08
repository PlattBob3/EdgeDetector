using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace EdgeDetector
{
    public partial class FrmMain : Form
    {
        #region Private Fields
        private List<DetectorParams> _images = new List<DetectorParams>();
        //private List<Bitmap> _images = new List<Bitmap>();
        private int _imageIndex = 0;
        private DetectorParams _currentParams;
        #endregion Private Fields
        #region Public Delegates
        public delegate void UpdateUi(int completion);
        public delegate void EndUpdate(Bitmap result);
        #endregion Public Delegates
        #region Constructor / Form Closing
        public FrmMain()
        {
            InitializeComponent();

            foreach (IEdgeDetector detector in DetectorHelper.Detectors)
            {
                detector.UpdateUi = DetectUpdateUI;
                detector.EndUpdate = DetectUpdateEnd;
                CmbEdgeDector.Items.Add(detector);
            }

            CmbEdgeDector.SelectedIndex = 0;

            CmbChannel.Items.AddRange(Enum.GetNames(typeof(DetectorChannel)));
            CmbChannel.SelectedIndex = 0;
        }
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_currentParams != null)
            {
                if (_currentParams.Detector.State == DetectorState.Processing)
                {
                    _currentParams.Detector.State = DetectorState.Abort;
                }

                while (_currentParams.Detector.State != DetectorState.Ready)
                {
                    Thread.Sleep(200);
                }
            }
        }
        #endregion Constructor / Closing
        #region View Logic
        private void BtnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.InitialDirectory = Directory.GetCurrentDirectory();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Stream fs = null;
                try
                {
                    fs = ofd.OpenFile();

                    Image img = Image.FromStream(fs);
                    DetectorParams parm = new DetectorParams();
                    parm.DestImage = new Bitmap(img);

                    _images.Add(parm);
                    _imageIndex = _images.Count - 1;

                    UpdateDetails();
                    PbImage.Image = img;
                    PbImage.SizeMode = PictureBoxSizeMode.Zoom;

                    Text = string.Format("Edge Detect - {0} ({1},{2})",
                            Path.GetFileName(ofd.FileName),
                            img.Width,
                            img.Height);
                }
                finally
                {
                    if (fs != null)
                        fs.Dispose();
                }
            }
        }
        /// <summary>
        /// User clicked [Detect] button.  If active, stop the detection process.  Otherwise start a new detection thread.
        /// </summary>
        private void BtnDetect_Click(object sender, EventArgs e)
        {
            if (_currentParams != null && _currentParams.Detector.State == DetectorState.Processing)
            {
                _currentParams.Detector.State = DetectorState.Abort;
            }
            else
            {
                DetectProgress.Value = 0;
                DetectProgress.Visible = true;
                CmbEdgeDector.Enabled = false;
                CmbChannel.Enabled = false;
                BtnDetect.Text = "Stop";

                _currentParams = new DetectorParams();
                _currentParams.Detector = CmbEdgeDector.SelectedItem as IEdgeDetector;
                _currentParams.SourceImage = _images[_imageIndex].DestImage;
                _currentParams.Threshold = int.Parse(TbThreshold.Text);
                _currentParams.Channel = (DetectorChannel) CmbChannel.SelectedIndex;

                Thread thd = new Thread(StartDetect);
                thd.Start();
            }
        }
        private void BtnBack_Click(object sender, EventArgs e)
        {
            if (_imageIndex > 0)
            {
                _imageIndex--;

                PbImage.Image = _images[_imageIndex].DestImage;
                UpdateDetails();
            }
        }
        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (_imageIndex < _images.Count - 1)
            {
                _imageIndex++;

                PbImage.Image = _images[_imageIndex].DestImage;
                UpdateDetails();
            }
        }
        /// <summary>
        /// Update the image details for the current image
        /// </summary>
        private void UpdateDetails()
        {
            DetectorParams parms = _images[_imageIndex];

            TbImageIndex.Text = (_imageIndex + 1).ToString();
            TbTotalImages.Text = _images.Count.ToString();

            if (parms.DestImage != null)
            {
                TbImageSize.Text = string.Format("{0} x {1}", parms.DestImage.Width, parms.DestImage.Height);
            }
            else
            {
                TbImageSize.Text = "";
            }

            if (parms.Detector != null)
            {
                TbImageAlg.Text = parms.Detector.Name;
                TbImageThreshold.Text = parms.Threshold.ToString();
                TbImageChannel.Text = parms.Channel.ToString();
            }
            else
            {
                TbImageAlg.Text = "";
                TbImageThreshold.Text = "";
                TbImageChannel.Text = "";
            }
        }
        #endregion View Logic
        #region Edge Detection Progress Logic
        /// <summary>
        /// Edge detection thread
        /// Progress is reported via delegate callback
        /// </summary>
        private void StartDetect()
        {
            if (_currentParams != null)
            {
                _currentParams.StartDetection();
            }
        }
        /// <summary>
        /// Called while processing to show progress
        /// </summary>
        /// <param name="completion">percent complete (0-100)</param>
        void DetectUpdateUI(int completion)
        {
            if (InvokeRequired)
                Invoke((MethodInvoker)delegate { DetectProgress.Value = completion; });
            else
                DetectProgress.Value = completion;
        }
        /// <summary>
        /// Called when detection is complete
        /// </summary>
        /// <param name="result">Image created from edge detection</param>
        void DetectUpdateEnd(Bitmap result)
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)delegate { DetectUpdateEnd(result); });
            }
            else
            {
                // Update current then add to the list
                _currentParams.DestImage = result;
                _images.Add(_currentParams);
                _imageIndex = _images.Count - 1;
                _currentParams = null;

                CmbChannel.Enabled = true;
                CmbEdgeDector.Enabled = true;
                BtnDetect.Text = "Detect";
                DetectProgress.Visible = false;

                UpdateDetails();
                PbImage.Image = result;
                PbImage.Invalidate();
            }
        }
        #endregion Process Logic
    }
}
