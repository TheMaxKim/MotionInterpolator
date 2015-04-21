using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotionInterpolator
{
    public partial class MainForm : Form
    {

        string videoFileName;

        FrameInterpolator frameInterpolator;

        public MainForm()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog videoOpenFileDialog = new OpenFileDialog();

            videoOpenFileDialog.Filter = "Video Files|*.avi;*.mp4";
            videoOpenFileDialog.FilterIndex = 1;

            videoOpenFileDialog.Multiselect = false;

            

            if (videoOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    System.IO.Stream fileStream;

                    if ((fileStream = videoOpenFileDialog.OpenFile()) != null)
                    {
                        setVideoFileName(videoOpenFileDialog.FileName);
                        frameInterpolator = new FrameInterpolator(getVideoFileName());

                        frameInterpolator.loadReader();

                        videoInfoTextBox.Text = "Height: " + frameInterpolator.getVideoHeight() + Environment.NewLine;
                        videoInfoTextBox.Text += "Width: " + frameInterpolator.getVideoWidth() + Environment.NewLine;
                        videoInfoTextBox.Text += "Frame Rate: " + frameInterpolator.getVideoFrameRate() + Environment.NewLine;
                        videoInfoTextBox.Text += "Codec: " + frameInterpolator.getVideoCodec() + Environment.NewLine;

                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + exception.Message);
                }
            }


        }

        private void processVideoButton_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(getVideoFileName()))
            {

                frameInterpolator.interpolateFrames();

            }
            else
            {
                MessageBox.Show("Error: A valid file was not selected!");
            }

            
        }


        public string getVideoFileName()
        {
            return videoFileName;
        }

        public void setVideoFileName(string name)
        {
            videoFileName = name;
        }

    }
}
