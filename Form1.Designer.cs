namespace DescripeImagesUsingAPIs
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
			this.uploadButton = new System.Windows.Forms.Button();
			this.descriptionLabel = new System.Windows.Forms.Label();
			this.imagePictureBox = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// uploadButton
			// 
			this.uploadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.uploadButton.Location = new System.Drawing.Point(11, 329);
			this.uploadButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.uploadButton.Name = "uploadButton";
			this.uploadButton.Size = new System.Drawing.Size(156, 38);
			this.uploadButton.TabIndex = 0;
			this.uploadButton.Text = "Upload";
			this.uploadButton.UseVisualStyleBackColor = true;
			this.uploadButton.Click += new System.EventHandler(this.Button1_Click);
			// 
			// descriptionLabel
			// 
			this.descriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.descriptionLabel.AutoSize = true;
			this.descriptionLabel.Location = new System.Drawing.Point(186, 340);
			this.descriptionLabel.Name = "descriptionLabel";
			this.descriptionLabel.Size = new System.Drawing.Size(0, 17);
			this.descriptionLabel.TabIndex = 1;
			// 
			// imagePictureBox
			// 
			this.imagePictureBox.Location = new System.Drawing.Point(11, 4);
			this.imagePictureBox.Name = "imagePictureBox";
			this.imagePictureBox.Size = new System.Drawing.Size(599, 319);
			this.imagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.imagePictureBox.TabIndex = 2;
			this.imagePictureBox.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(622, 379);
			this.Controls.Add(this.imagePictureBox);
			this.Controls.Add(this.descriptionLabel);
			this.Controls.Add(this.uploadButton);
			this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uploadButton;
		private System.Windows.Forms.Label descriptionLabel;
		private System.Windows.Forms.PictureBox imagePictureBox;
	}
}

