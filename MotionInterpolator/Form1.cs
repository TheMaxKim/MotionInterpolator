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
                int frameMultiplier = 2;

                if (!String.IsNullOrEmpty(frameRateMultiplierTextBox.Text))
                {
                    frameMultiplier = int.Parse(frameRateMultiplierTextBox.Text);
                }

                frameInterpolator.setMultiplier(frameMultiplier);

                videoInfoTextBox.Text = "Processing...";
                frameInterpolator.setSender(this);
                frameInterpolator.interpolateFrames(outputNameTextBox.Text);
                videoInfoTextBox.Text = "Done!";
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

        public void updateCurrentFrameDisplay(int currentFrame, int totalFrames)
        {
            videoInfoTextBox.Text = "Working..." + Environment.NewLine;
            videoInfoTextBox.Text += "Processing Frame " + currentFrame + " of " + totalFrames;
            Refresh();
        }

        public void updatePreviewBox(Bitmap picture)
        {
            if (previewBox.Image != null)
            {
                previewBox.Image.Dispose();
            }

            previewBox.Image = picture;
        }

        private void frameRateMultiplierTextBoxLabel_Click(object sender, EventArgs e)
        {

        }

        private void outputNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
