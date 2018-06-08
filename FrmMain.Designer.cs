namespace EdgeDetector
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            this.PbImage = new System.Windows.Forms.PictureBox();
            this.BtnDetect = new System.Windows.Forms.Button();
            this.TbThreshold = new System.Windows.Forms.TextBox();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.DetectProgress = new System.Windows.Forms.ProgressBar();
            this.CmbEdgeDector = new System.Windows.Forms.ComboBox();
            this.CmbChannel = new System.Windows.Forms.ComboBox();
            this.TbImageAlg = new System.Windows.Forms.TextBox();
            this.TbImageThreshold = new System.Windows.Forms.TextBox();
            this.TbImageChannel = new System.Windows.Forms.TextBox();
            this.TbImageIndex = new System.Windows.Forms.TextBox();
            this.TbTotalImages = new System.Windows.Forms.TextBox();
            this.TbImageSize = new System.Windows.Forms.TextBox();
            this.BtnOpenFile = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(13, 68);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(72, 17);
            label1.TabIndex = 4;
            label1.Text = "Threshold";
            // 
            // label2
            // 
            label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(268, 421);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(32, 17);
            label2.TabIndex = 9;
            label2.Text = "Alg:";
            // 
            // label3
            // 
            label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(421, 421);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(76, 17);
            label3.TabIndex = 9;
            label3.Text = "Threshold:";
            // 
            // label4
            // 
            label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(605, 421);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(64, 17);
            label4.TabIndex = 11;
            label4.Text = "Channel:";
            // 
            // label5
            // 
            label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(48, 421);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(20, 17);
            label5.TabIndex = 9;
            label5.Text = "of";
            // 
            // label6
            // 
            label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(108, 421);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(39, 17);
            label6.TabIndex = 9;
            label6.Text = "Size:";
            // 
            // PbImage
            // 
            this.PbImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PbImage.Location = new System.Drawing.Point(111, 6);
            this.PbImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PbImage.Name = "PbImage";
            this.PbImage.Size = new System.Drawing.Size(684, 402);
            this.PbImage.TabIndex = 0;
            this.PbImage.TabStop = false;
            // 
            // BtnDetect
            // 
            this.BtnDetect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDetect.Location = new System.Drawing.Point(11, 209);
            this.BtnDetect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDetect.Name = "BtnDetect";
            this.BtnDetect.Size = new System.Drawing.Size(76, 26);
            this.BtnDetect.TabIndex = 4;
            this.BtnDetect.Text = "Detect";
            this.BtnDetect.UseVisualStyleBackColor = true;
            this.BtnDetect.Click += new System.EventHandler(this.BtnDetect_Click);
            // 
            // TbThreshold
            // 
            this.TbThreshold.Location = new System.Drawing.Point(13, 91);
            this.TbThreshold.Margin = new System.Windows.Forms.Padding(4);
            this.TbThreshold.Name = "TbThreshold";
            this.TbThreshold.Size = new System.Drawing.Size(72, 22);
            this.TbThreshold.TabIndex = 1;
            this.TbThreshold.Text = "100";
            // 
            // BtnBack
            // 
            this.BtnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnBack.Location = new System.Drawing.Point(13, 380);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(32, 28);
            this.BtnBack.TabIndex = 5;
            this.BtnBack.Text = "-";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnNext.Location = new System.Drawing.Point(55, 380);
            this.BtnNext.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(32, 28);
            this.BtnNext.TabIndex = 6;
            this.BtnNext.Text = "+";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // DetectProgress
            // 
            this.DetectProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DetectProgress.Location = new System.Drawing.Point(199, 218);
            this.DetectProgress.Margin = new System.Windows.Forms.Padding(4);
            this.DetectProgress.Name = "DetectProgress";
            this.DetectProgress.Size = new System.Drawing.Size(496, 28);
            this.DetectProgress.TabIndex = 6;
            this.DetectProgress.Visible = false;
            // 
            // CmbEdgeDector
            // 
            this.CmbEdgeDector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEdgeDector.FormattingEnabled = true;
            this.CmbEdgeDector.Location = new System.Drawing.Point(12, 133);
            this.CmbEdgeDector.Margin = new System.Windows.Forms.Padding(4);
            this.CmbEdgeDector.Name = "CmbEdgeDector";
            this.CmbEdgeDector.Size = new System.Drawing.Size(88, 24);
            this.CmbEdgeDector.TabIndex = 2;
            // 
            // CmbChannel
            // 
            this.CmbChannel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbChannel.FormattingEnabled = true;
            this.CmbChannel.Location = new System.Drawing.Point(11, 165);
            this.CmbChannel.Margin = new System.Windows.Forms.Padding(4);
            this.CmbChannel.Name = "CmbChannel";
            this.CmbChannel.Size = new System.Drawing.Size(88, 24);
            this.CmbChannel.TabIndex = 3;
            // 
            // TbImageAlg
            // 
            this.TbImageAlg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TbImageAlg.Location = new System.Drawing.Point(306, 418);
            this.TbImageAlg.Name = "TbImageAlg";
            this.TbImageAlg.ReadOnly = true;
            this.TbImageAlg.Size = new System.Drawing.Size(100, 22);
            this.TbImageAlg.TabIndex = 10;
            this.TbImageAlg.TabStop = false;
            this.TbImageAlg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TbImageThreshold
            // 
            this.TbImageThreshold.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TbImageThreshold.Location = new System.Drawing.Point(503, 418);
            this.TbImageThreshold.Name = "TbImageThreshold";
            this.TbImageThreshold.ReadOnly = true;
            this.TbImageThreshold.Size = new System.Drawing.Size(87, 22);
            this.TbImageThreshold.TabIndex = 10;
            this.TbImageThreshold.TabStop = false;
            this.TbImageThreshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TbImageChannel
            // 
            this.TbImageChannel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TbImageChannel.Location = new System.Drawing.Point(675, 418);
            this.TbImageChannel.Name = "TbImageChannel";
            this.TbImageChannel.ReadOnly = true;
            this.TbImageChannel.Size = new System.Drawing.Size(88, 22);
            this.TbImageChannel.TabIndex = 12;
            this.TbImageChannel.TabStop = false;
            this.TbImageChannel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TbImageIndex
            // 
            this.TbImageIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TbImageIndex.Location = new System.Drawing.Point(13, 418);
            this.TbImageIndex.Name = "TbImageIndex";
            this.TbImageIndex.ReadOnly = true;
            this.TbImageIndex.Size = new System.Drawing.Size(29, 22);
            this.TbImageIndex.TabIndex = 10;
            this.TbImageIndex.TabStop = false;
            this.TbImageIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TbTotalImages
            // 
            this.TbTotalImages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TbTotalImages.Location = new System.Drawing.Point(74, 418);
            this.TbTotalImages.Name = "TbTotalImages";
            this.TbTotalImages.ReadOnly = true;
            this.TbTotalImages.Size = new System.Drawing.Size(29, 22);
            this.TbTotalImages.TabIndex = 10;
            this.TbTotalImages.TabStop = false;
            this.TbTotalImages.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TbImageSize
            // 
            this.TbImageSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TbImageSize.Location = new System.Drawing.Point(153, 418);
            this.TbImageSize.Name = "TbImageSize";
            this.TbImageSize.ReadOnly = true;
            this.TbImageSize.Size = new System.Drawing.Size(100, 22);
            this.TbImageSize.TabIndex = 10;
            this.TbImageSize.TabStop = false;
            this.TbImageSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnOpenFile
            // 
            this.BtnOpenFile.Location = new System.Drawing.Point(13, 12);
            this.BtnOpenFile.Name = "BtnOpenFile";
            this.BtnOpenFile.Size = new System.Drawing.Size(75, 25);
            this.BtnOpenFile.TabIndex = 0;
            this.BtnOpenFile.Text = "Open";
            this.BtnOpenFile.UseVisualStyleBackColor = true;
            this.BtnOpenFile.Click += new System.EventHandler(this.BtnOpenFile_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnOpenFile);
            this.Controls.Add(this.TbImageChannel);
            this.Controls.Add(label4);
            this.Controls.Add(this.TbImageThreshold);
            this.Controls.Add(label3);
            this.Controls.Add(this.TbTotalImages);
            this.Controls.Add(this.TbImageIndex);
            this.Controls.Add(this.TbImageSize);
            this.Controls.Add(this.TbImageAlg);
            this.Controls.Add(label6);
            this.Controls.Add(label5);
            this.Controls.Add(label2);
            this.Controls.Add(this.CmbChannel);
            this.Controls.Add(this.CmbEdgeDector);
            this.Controls.Add(this.DetectProgress);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(label1);
            this.Controls.Add(this.TbThreshold);
            this.Controls.Add(this.BtnDetect);
            this.Controls.Add(this.PbImage);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmMain";
            this.Text = "Edge Detect";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.PbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PbImage;
        private System.Windows.Forms.Button BtnDetect;
        private System.Windows.Forms.TextBox TbThreshold;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.ProgressBar DetectProgress;
        private System.Windows.Forms.ComboBox CmbEdgeDector;
        private System.Windows.Forms.ComboBox CmbChannel;
        private System.Windows.Forms.TextBox TbImageAlg;
        private System.Windows.Forms.TextBox TbImageThreshold;
        private System.Windows.Forms.TextBox TbImageChannel;
        private System.Windows.Forms.TextBox TbImageIndex;
        private System.Windows.Forms.TextBox TbTotalImages;
        private System.Windows.Forms.TextBox TbImageSize;
        private System.Windows.Forms.Button BtnOpenFile;
    }
}

