namespace MotionInterpolator
{
    partial class MainForm
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
            this.formButtonTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.openFileButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.processVideoButton = new System.Windows.Forms.Button();
            this.videoInfoTextBox = new System.Windows.Forms.TextBox();
            this.frameRateTextBox = new System.Windows.Forms.TextBox();
            this.formButtonTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // formButtonTableLayoutPanel
            // 
            this.formButtonTableLayoutPanel.ColumnCount = 2;
            this.formButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.formButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.formButtonTableLayoutPanel.Controls.Add(this.openFileButton, 1, 0);
            this.formButtonTableLayoutPanel.Controls.Add(this.processVideoButton, 1, 1);
            this.formButtonTableLayoutPanel.Controls.Add(this.frameRateTextBox, 0, 0);
            this.formButtonTableLayoutPanel.Location = new System.Drawing.Point(61, 442);
            this.formButtonTableLayoutPanel.Name = "formButtonTableLayoutPanel";
            this.formButtonTableLayoutPanel.RowCount = 2;
            this.formButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.formButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.formButtonTableLayoutPanel.Size = new System.Drawing.Size(467, 100);
            this.formButtonTableLayoutPanel.TabIndex = 0;
            this.formButtonTableLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(236, 3);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(75, 23);
            this.openFileButton.TabIndex = 0;
            this.openFileButton.Text = "Select Video";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // processVideoButton
            // 
            this.processVideoButton.Location = new System.Drawing.Point(236, 53);
            this.processVideoButton.Name = "processVideoButton";
            this.processVideoButton.Size = new System.Drawing.Size(98, 24);
            this.processVideoButton.TabIndex = 1;
            this.processVideoButton.Text = "Process Video";
            this.processVideoButton.UseVisualStyleBackColor = true;
            this.processVideoButton.Click += new System.EventHandler(this.processVideoButton_Click);
            // 
            // videoInfoTextBox
            // 
            this.videoInfoTextBox.Enabled = false;
            this.videoInfoTextBox.Location = new System.Drawing.Point(61, 39);
            this.videoInfoTextBox.Multiline = true;
            this.videoInfoTextBox.Name = "videoInfoTextBox";
            this.videoInfoTextBox.Size = new System.Drawing.Size(466, 200);
            this.videoInfoTextBox.TabIndex = 1;
            // 
            // frameRateTextBox
            // 
            this.frameRateTextBox.Location = new System.Drawing.Point(3, 3);
            this.frameRateTextBox.Name = "frameRateTextBox";
            this.frameRateTextBox.Size = new System.Drawing.Size(31, 20);
            this.frameRateTextBox.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 554);
            this.Controls.Add(this.videoInfoTextBox);
            this.Controls.Add(this.formButtonTableLayoutPanel);
            this.Name = "MainForm";
            this.Text = "Video Motion Interpolator";
            this.formButtonTableLayoutPanel.ResumeLayout(false);
            this.formButtonTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel formButtonTableLayoutPanel;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button processVideoButton;
        private System.Windows.Forms.TextBox videoInfoTextBox;
        private System.Windows.Forms.TextBox frameRateTextBox;

    }
}
