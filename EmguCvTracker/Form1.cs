using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Util;

namespace EmguCvTracker
{
    public partial class Form1 : Form
    {

        //capture device
        private Emgu.CV.Capture _cameraCapture = null;


        private Hsv _targetHsv;
        private Hsv _hsvAccuracy;
        private bool _started;
        
        public Form1()
        {
            InitializeComponent();
            CvInvoke.UseOpenCL = false;

            _hsvAccuracy = new Hsv(hueAccuracy.Value/100.0, 
                saturationAccuracy.Value/100.0, 
                valueAccuracy.Value/100.0);

            hueAccuracy.ValueChanged += updateHsvAccuracy;
            hueAccuracy.ValueChanged += UpdateColorBoxes;
            saturationAccuracy.ValueChanged += updateHsvAccuracy;
            saturationAccuracy.ValueChanged += UpdateColorBoxes;
            valueAccuracy.ValueChanged += updateHsvAccuracy;
            valueAccuracy.ValueChanged += UpdateColorBoxes;

            hueTrackbar.ValueChanged += UpdateColorBoxes;
            saturationTrackbar.ValueChanged += UpdateColorBoxes;
            valueTrackbar.ValueChanged += UpdateColorBoxes;
        }

       

        private void StartCapture()
        {
            try
            {
                _cameraCapture = new Capture();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return;
            }
            if (_cameraCapture != null)
            {
                _cameraCapture.ImageGrabbed += _cameraCapture_ImageGrabbed;
                _cameraCapture.Start();

                startBtn.Text = "Stop";
            }
        }

        private void _cameraCapture_ImageGrabbed(object sender, EventArgs e)
        {
            Mat capturedImage = new Mat();

            _cameraCapture.Retrieve(capturedImage, 0);

            _webCamView.Image = capturedImage;

            Mat filteredImage = new Mat();

            IInputArray lowerArray =
                new VectorOfDouble(new double[] {_targetHsv.Hue.LowerLimit(_hsvAccuracy.Hue),
                    _targetHsv.Satuation.LowerLimit(_hsvAccuracy.Satuation)/100.0, 
                    _targetHsv.Value.LowerLimit(_hsvAccuracy.Value)/100.0});
            IInputArray upperArray =
                new VectorOfDouble(new double[] {_targetHsv.Hue.UpperLimit(_hsvAccuracy.Hue),
                    _targetHsv.Satuation.UpperLimit(_hsvAccuracy.Satuation)/100.0, 
                    _targetHsv.Value.UpperLimit(_hsvAccuracy.Value)/100.0});

            CvInvoke.InRange(capturedImage, lowerArray, upperArray, filteredImage);
            filteredImageBox.Image = filteredImage;
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if (!_started)
                StartCapture();

        }

        private void _webCamView_MouseClick_1(object sender, MouseEventArgs e)
        {
            Hsv newTarget;

            Color pixelColor = _webCamView.Image.Bitmap.GetPixel(e.X, e.Y);

            Console.WriteLine("Color selected: {0}, {1}, {2}", pixelColor.R, pixelColor.B, pixelColor.G);

            _targetHsv = HsvFromColor(pixelColor);
            Console.WriteLine("HSV value: {0}, {1}, {2}", _targetHsv.Hue, _targetHsv.Satuation, _targetHsv.Value);

            hueTrackbar.Value = (int)_targetHsv.Hue;
            saturationTrackbar.Value = (int)_targetHsv.Satuation;
            valueTrackbar.Value = (int)_targetHsv.Value;
        }

        private void hueTrackbar_ValueChanged(object sender, EventArgs e)
        {
            _targetHsv.Hue = hueTrackbar.Value;
            hueLabel.Text = "Hue: " + _targetHsv.Hue.ToString("F");
        }


        private void saturationTrackbar_ValueChanged(object sender, EventArgs e)
        {
            _targetHsv.Satuation = saturationTrackbar.Value;
            saturationLabel.Text = "Saturation: " + _targetHsv.Satuation.ToString("F");
        }


        private void valueTrackbar_ValueChanged(object sender, EventArgs e)
        {
            _targetHsv.Value = valueTrackbar.Value;
            valueLabel.Text = "Value: " + _targetHsv.Value.ToString("F");
        }


        void updateHsvAccuracy(object sender, EventArgs e)
        {
            _hsvAccuracy = new Hsv(hueAccuracy.Value / 180,
                saturationAccuracy.Value / 100.0,
                valueAccuracy.Value / 100.0);
        }

        private void UpdateColorBoxes(object sender, EventArgs e)
        {
            selectedMax.BackColor = ColorFromHSV(_targetHsv.Hue.UpperLimit(_hsvAccuracy.Hue, 180) * 2,
                _targetHsv.Satuation.UpperLimit(_hsvAccuracy.Satuation, 100)/100,
                _targetHsv.Value.UpperLimit(_hsvAccuracy.Value, 100)/ 100);

            selectedMin.BackColor = ColorFromHSV(_targetHsv.Hue.LowerLimit(_hsvAccuracy.Hue, 0) * 2,
                _targetHsv.Satuation.LowerLimit(_hsvAccuracy.Satuation, 0)/ 100,
                _targetHsv.Value.LowerLimit(_hsvAccuracy.Value, 0)/ 100);
        }


        public static Hsv HsvFromColor(Color color)
        {
            return HsvFromColor(color.R, color.B, color.G);
        }
        /// <summary>
        /// http://www.javascripter.net/faq/rgb2hsv.htm
        /// </summary>
        /// <param name="r"></param>
        /// <param name="g"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static Hsv HsvFromColor(double r, double g, double b)
        {
            Hsv hsv = new Hsv();
            double tolerance = .001;
            r = r/255.0;
            g = g/255.0;
            b = b/255.0;

            double min = Math.Min(Math.Min(r, g), b);
            double max = Math.Max(Math.Max(r, g), b);

            //black-gray-white
            if (Math.Abs(min - max) < tolerance)
            {
                hsv.Value = min*100;
                hsv.Hue = 0;
                hsv.Satuation = 0;
                return hsv;
            }

            var d = (Math.Abs(r - min) < tolerance) ? g - b : ((Math.Abs(b - min) < tolerance) ? r - g : b - r);
            var h = (Math.Abs(r - min) < tolerance) ? 3 : ((Math.Abs(b - min) < tolerance) ? 1 : 5);

            hsv.Hue = 180 - 30*(h - d/(max - min)); //30 instead of 60 b/c emgu uses 0-180
            hsv.Satuation = (max - min)/max*100;
            hsv.Value = max*100;


            return hsv;
        }
        /// <summary>
        /// http://stackoverflow.com/questions/359612/how-to-change-rgb-color-to-hsv
        /// </summary>
        /// <param name="hue"></param>
        /// <param name="saturation"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Color ColorFromHSV(double hue, double saturation, double value)
        {
            int hi = Convert.ToInt32(Math.Floor(hue / 60)) % 6;
            double f = hue / 60 - Math.Floor(hue / 60);

            value = value * 255;
            int v = Convert.ToInt32(value);
            int p = Convert.ToInt32(value * (1 - saturation));
            int q = Convert.ToInt32(value * (1 - f * saturation));
            int t = Convert.ToInt32(value * (1 - (1 - f) * saturation));

            if (hi == 0)
                return Color.FromArgb(255, v, t, p);
            else if (hi == 1)
                return Color.FromArgb(255, q, v, p);
            else if (hi == 2)
                return Color.FromArgb(255, p, v, t);
            else if (hi == 3)
                return Color.FromArgb(255, p, q, v);
            else if (hi == 4)
                return Color.FromArgb(255, t, p, v);
            else
                return Color.FromArgb(255, v, p, q);
        }

        }

    public static class ExtensionMethods
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="accuracy">As a percent</param>
        /// <returns></returns>
        public  static double LowerLimit(this double value, double accuracy)
        {
                return value - accuracy*value;
        }

        public static double UpperLimit(this double value, double accuracy)
        {
            return value + accuracy*value;
        }

        public static double UpperLimit(this double value, double accuracy, double max)
        {
            return (value + accuracy * value > max) ? max : value + accuracy * value;
        }

        public static double LowerLimit(this double value, double accuracy, double min)
        {
            return (value + accuracy * value < min) ?  min :  value + accuracy * value;
        }
    }
}
