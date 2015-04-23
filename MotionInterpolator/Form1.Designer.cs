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
            this.processVideoButton = new System.Windows.Forms.Button();
            this.frameRateMultiplierTextBox = new System.Windows.Forms.TextBox();
            this.frameRateMultiplierTextBoxLabel = new System.Windows.Forms.Label();
            this.outputNameTextBoxLabel = new System.Windows.Forms.Label();
            this.outputNameTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.videoInfoTextBox = new System.Windows.Forms.TextBox();
            this.previewBox = new System.Windows.Forms.PictureBox();
            this.formButtonTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).BeginInit();
            this.SuspendLayout();
            // 
            // formButtonTableLayoutPanel
            // 
            this.formButtonTableLayoutPanel.ColumnCount = 4;
            this.formButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.15094F));
            this.formButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.84906F));
            this.formButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.formButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.formButtonTableLayoutPanel.Controls.Add(this.openFileButton, 3, 0);
            this.formButtonTableLayoutPanel.Controls.Add(this.processVideoButton, 3, 1);
            this.formButtonTableLayoutPanel.Controls.Add(this.frameRateMultiplierTextBox, 1, 0);
            this.formButtonTableLayoutPanel.Controls.Add(this.frameRateMultiplierTextBoxLabel, 0, 0);
            this.formButtonTableLayoutPanel.Controls.Add(this.outputNameTextBoxLabel, 0, 1);
            this.formButtonTableLayoutPanel.Controls.Add(this.outputNameTextBox, 1, 1);
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
            this.openFileButton.Location = new System.Drawing.Point(364, 3);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(98, 23);
            this.openFileButton.TabIndex = 0;
            this.openFileButton.Text = "Select Video";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // processVideoButton
            // 
            this.processVideoButton.Location = new System.Drawing.Point(364, 53);
            this.processVideoButton.Name = "processVideoButton";
            this.processVideoButton.Size = new System.Drawing.Size(98, 24);
            this.processVideoButton.TabIndex = 1;
            this.processVideoButton.Text = "Process Video";
            this.processVideoButton.UseVisualStyleBackColor = true;
            this.processVideoButton.Click += new System.EventHandler(this.processVideoButton_Click);
            // 
            // frameRateMultiplierTextBox
            // 
            this.frameRateMultiplierTextBox.Location = new System.Drawing.Point(86, 3);
            this.frameRateMultiplierTextBox.Name = "frameRateMultiplierTextBox";
            this.frameRateMultiplierTextBox.Size = new System.Drawing.Size(89, 20);
            this.frameRateMultiplierTextBox.TabIndex = 2;
            // 
            // frameRateMultiplierTextBoxLabel
            // 
            this.frameRateMultiplierTextBoxLabel.AutoSize = true;
            this.frameRateMultiplierTextBoxLabel.Location = new System.Drawing.Point(3, 0);
            this.frameRateMultiplierTextBoxLabel.Name = "frameRateMultiplierTextBoxLabel";
            this.frameRateMultiplierTextBoxLabel.Size = new System.Drawing.Size(74, 13);
            this.frameRateMultiplierTextBoxLabel.TabIndex = 3;
            this.frameRateMultiplierTextBoxLabel.Text = "FPS Multiplier:";
            this.frameRateMultiplierTextBoxLabel.Click += new System.EventHandler(this.frameRateMultiplierTextBoxLabel_Click);
            // 
            // outputNameTextBoxLabel
            // 
            this.outputNameTextBoxLabel.AutoSize = true;
            this.outputNameTextBoxLabel.Location = new System.Drawing.Point(3, 50);
            this.outputNameTextBoxLabel.Name = "outputNameTextBoxLabel";
            this.outputNameTextBoxLabel.Size = new System.Drawing.Size(73, 13);
            this.outputNameTextBoxLabel.TabIndex = 4;
            this.outputNameTextBoxLabel.Text = "Output Name:";
            // 
            // outputNameTextBox
            // 
            this.outputNameTextBox.Location = new System.Drawing.Point(86, 53);
            this.outputNameTextBox.Name = "outputNameTextBox";
            this.outputNameTextBox.Size = new System.Drawing.Size(89, 20);
            this.outputNameTextBox.TabIndex = 5;
            this.outputNameTextBox.TextChanged += new System.EventHandler(this.outputNameTextBox_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // videoInfoTextBox
            // 
            this.videoInfoTextBox.Enabled = false;
            this.videoInfoTextBox.Location = new System.Drawing.Point(61, 39);
            this.videoInfoTextBox.Multiline = true;
            this.videoInfoTextBox.Name = "videoInfoTextBox";
            this.videoInfoTextBox.Size = new System.Drawing.Size(467, 105);
            this.videoInfoTextBox.TabIndex = 1;
            // 
            // previewBox
            // 
            this.previewBox.Location = new System.Drawing.Point(61, 183);
            this.previewBox.Name = "previewBox";
            this.previewBox.Size = new System.Drawing.Size(467, 233);
            this.previewBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.previewBox.TabIndex = 2;
            this.previewBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 554);
            this.Controls.Add(this.previewBox);
            this.Controls.Add(this.videoInfoTextBox);
            this.Controls.Add(this.formButtonTableLayoutPanel);
            this.Name = "MainForm";
            this.Text = "Video Motion Interpolator";
            this.formButtonTableLayoutPanel.ResumeLayout(false);
            this.formButtonTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel formButtonTableLayoutPanel;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button processVideoButton;
        private System.Windows.Forms.TextBox videoInfoTextBox;
        private System.Windows.Forms.TextBox frameRateMultiplierTextBox;
        private System.Windows.Forms.Label frameRateMultiplierTextBoxLabel;
        private System.Windows.Forms.Label outputNameTextBoxLabel;
        private System.Windows.Forms.TextBox outputNameTextBox;
        private System.Windows.Forms.PictureBox previewBox;

    }
}
