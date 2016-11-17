using System.Windows.Forms;
using Emgu.CV.Structure;

namespace EmguCvTracker
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this._webCamGroupBox = new System.Windows.Forms.GroupBox();
            this._webCamView = new Emgu.CV.UI.ImageBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.hueTrackbar = new System.Windows.Forms.TrackBar();
            this.valueTrackbar = new System.Windows.Forms.TrackBar();
            this.saturationTrackbar = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.selectedMax = new System.Windows.Forms.PictureBox();
            this.selectedMin = new System.Windows.Forms.PictureBox();
            this.hueAccuracy = new System.Windows.Forms.TrackBar();
            this.valueAccuracy = new System.Windows.Forms.TrackBar();
            this.saturationAccuracy = new System.Windows.Forms.TrackBar();
            this.saturationLabel = new System.Windows.Forms.Label();
            this.valueLabel = new System.Windows.Forms.Label();
            this.hueLabel = new System.Windows.Forms.Label();
            this.filteredGroupBox = new System.Windows.Forms.GroupBox();
            this.filteredImageBox = new Emgu.CV.UI.ImageBox();
            this._webCamGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._webCamView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hueTrackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueTrackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saturationTrackbar)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hueAccuracy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueAccuracy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saturationAccuracy)).BeginInit();
            this.filteredGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filteredImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // _webCamGroupBox
            // 
            this._webCamGroupBox.Controls.Add(this._webCamView);
            this._webCamGroupBox.Location = new System.Drawing.Point(12, 12);
            this._webCamGroupBox.Name = "_webCamGroupBox";
            this._webCamGroupBox.Size = new System.Drawing.Size(305, 304);
            this._webCamGroupBox.TabIndex = 0;
            this._webCamGroupBox.TabStop = false;
            this._webCamGroupBox.Text = "Web Cam";
            // 
            // _webCamView
            // 
            this._webCamView.Location = new System.Drawing.Point(6, 19);
            this._webCamView.Name = "_webCamView";
            this._webCamView.Size = new System.Drawing.Size(293, 279);
            this._webCamView.TabIndex = 2;
            this._webCamView.TabStop = false;
            this._webCamView.MouseClick += new System.Windows.Forms.MouseEventHandler(this._webCamView_MouseClick_1);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(13, 395);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 1;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // hueTrackbar
            // 
            this.hueTrackbar.LargeChange = 10;
            this.hueTrackbar.Location = new System.Drawing.Point(79, 19);
            this.hueTrackbar.Maximum = 180;
            this.hueTrackbar.Name = "hueTrackbar";
            this.hueTrackbar.Size = new System.Drawing.Size(104, 45);
            this.hueTrackbar.SmallChange = 2;
            this.hueTrackbar.TabIndex = 2;
            this.hueTrackbar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.hueTrackbar.ValueChanged += new System.EventHandler(this.hueTrackbar_ValueChanged);
            // 
            // valueTrackbar
            // 
            this.valueTrackbar.LargeChange = 10;
            this.valueTrackbar.Location = new System.Drawing.Point(79, 121);
            this.valueTrackbar.Maximum = 100;
            this.valueTrackbar.Name = "valueTrackbar";
            this.valueTrackbar.Size = new System.Drawing.Size(104, 45);
            this.valueTrackbar.SmallChange = 2;
            this.valueTrackbar.TabIndex = 3;
            this.valueTrackbar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.valueTrackbar.ValueChanged += new System.EventHandler(this.valueTrackbar_ValueChanged);
            // 
            // saturationTrackbar
            // 
            this.saturationTrackbar.LargeChange = 10;
            this.saturationTrackbar.Location = new System.Drawing.Point(79, 70);
            this.saturationTrackbar.Maximum = 100;
            this.saturationTrackbar.Name = "saturationTrackbar";
            this.saturationTrackbar.Size = new System.Drawing.Size(104, 45);
            this.saturationTrackbar.SmallChange = 2;
            this.saturationTrackbar.TabIndex = 4;
            this.saturationTrackbar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.saturationTrackbar.ValueChanged += new System.EventHandler(this.saturationTrackbar_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.selectedMax);
            this.groupBox1.Controls.Add(this.selectedMin);
            this.groupBox1.Controls.Add(this.hueAccuracy);
            this.groupBox1.Controls.Add(this.valueAccuracy);
            this.groupBox1.Controls.Add(this.saturationAccuracy);
            this.groupBox1.Controls.Add(this.saturationLabel);
            this.groupBox1.Controls.Add(this.valueLabel);
            this.groupBox1.Controls.Add(this.hueLabel);
            this.groupBox1.Controls.Add(this.valueTrackbar);
            this.groupBox1.Controls.Add(this.hueTrackbar);
            this.groupBox1.Controls.Add(this.saturationTrackbar);
            this.groupBox1.Location = new System.Drawing.Point(117, 322);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 192);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color Picker";
            // 
            // selectedMax
            // 
            this.selectedMax.Location = new System.Drawing.Point(116, 148);
            this.selectedMax.Name = "selectedMax";
            this.selectedMax.Size = new System.Drawing.Size(47, 38);
            this.selectedMax.TabIndex = 11;
            this.selectedMax.TabStop = false;
            // 
            // selectedMin
            // 
            this.selectedMin.Location = new System.Drawing.Point(63, 148);
            this.selectedMin.Name = "selectedMin";
            this.selectedMin.Size = new System.Drawing.Size(47, 38);
            this.selectedMin.TabIndex = 10;
            this.selectedMin.TabStop = false;
            // 
            // hueAccuracy
            // 
            this.hueAccuracy.LargeChange = 10;
            this.hueAccuracy.Location = new System.Drawing.Point(183, 19);
            this.hueAccuracy.Maximum = 180;
            this.hueAccuracy.Name = "hueAccuracy";
            this.hueAccuracy.Size = new System.Drawing.Size(104, 45);
            this.hueAccuracy.SmallChange = 2;
            this.hueAccuracy.TabIndex = 8;
            this.hueAccuracy.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // valueAccuracy
            // 
            this.valueAccuracy.LargeChange = 10;
            this.valueAccuracy.Location = new System.Drawing.Point(183, 121);
            this.valueAccuracy.Maximum = 100;
            this.valueAccuracy.Name = "valueAccuracy";
            this.valueAccuracy.Size = new System.Drawing.Size(104, 45);
            this.valueAccuracy.SmallChange = 2;
            this.valueAccuracy.TabIndex = 9;
            this.valueAccuracy.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // saturationAccuracy
            // 
            this.saturationAccuracy.LargeChange = 10;
            this.saturationAccuracy.Location = new System.Drawing.Point(183, 70);
            this.saturationAccuracy.Maximum = 100;
            this.saturationAccuracy.Name = "saturationAccuracy";
            this.saturationAccuracy.Size = new System.Drawing.Size(104, 45);
            this.saturationAccuracy.SmallChange = 2;
            this.saturationAccuracy.TabIndex = 8;
            this.saturationAccuracy.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // saturationLabel
            // 
            this.saturationLabel.AutoSize = true;
            this.saturationLabel.Location = new System.Drawing.Point(6, 70);
            this.saturationLabel.Name = "saturationLabel";
            this.saturationLabel.Size = new System.Drawing.Size(55, 13);
            this.saturationLabel.TabIndex = 7;
            this.saturationLabel.Text = "Saturation";
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Location = new System.Drawing.Point(6, 121);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(34, 13);
            this.valueLabel.TabIndex = 6;
            this.valueLabel.Text = "Value";
            // 
            // hueLabel
            // 
            this.hueLabel.AutoSize = true;
            this.hueLabel.Location = new System.Drawing.Point(6, 19);
            this.hueLabel.Name = "hueLabel";
            this.hueLabel.Size = new System.Drawing.Size(27, 13);
            this.hueLabel.TabIndex = 5;
            this.hueLabel.Text = "Hue";
            // 
            // filteredGroupBox
            // 
            this.filteredGroupBox.Controls.Add(this.filteredImageBox);
            this.filteredGroupBox.Location = new System.Drawing.Point(323, 12);
            this.filteredGroupBox.Name = "filteredGroupBox";
            this.filteredGroupBox.Size = new System.Drawing.Size(305, 304);
            this.filteredGroupBox.TabIndex = 3;
            this.filteredGroupBox.TabStop = false;
            this.filteredGroupBox.Text = "Filtered";
            // 
            // filteredImageBox
            // 
            this.filteredImageBox.Location = new System.Drawing.Point(6, 19);
            this.filteredImageBox.Name = "filteredImageBox";
            this.filteredImageBox.Size = new System.Drawing.Size(293, 279);
            this.filteredImageBox.TabIndex = 2;
            this.filteredImageBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 526);
            this.Controls.Add(this.filteredGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this._webCamGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this._webCamGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._webCamView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hueTrackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueTrackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saturationTrackbar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hueAccuracy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueAccuracy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saturationAccuracy)).EndInit();
            this.filteredGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.filteredImageBox)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.GroupBox _webCamGroupBox;
        private System.Windows.Forms.Button startBtn;
        private Emgu.CV.UI.ImageBox _webCamView;
        private System.Windows.Forms.TrackBar hueTrackbar;
        private TrackBar valueTrackbar;
        private TrackBar saturationTrackbar;
        private GroupBox groupBox1;
        private Label saturationLabel;
        private Label valueLabel;
        private Label hueLabel;
        private GroupBox filteredGroupBox;
        private Emgu.CV.UI.ImageBox filteredImageBox;
        private TrackBar hueAccuracy;
        private TrackBar valueAccuracy;
        private TrackBar saturationAccuracy;
        private PictureBox selectedMax;
        private PictureBox selectedMin;
    }
}

