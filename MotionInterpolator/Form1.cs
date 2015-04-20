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
                        MessageBox.Show("File Selected", "Error Title", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + exception.Message);
                }
            }


        }
    }
}
