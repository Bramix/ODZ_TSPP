using System.ComponentModel;

namespace ODZ_TSPP
{
    partial class UploadOrDownLoadForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.uploadBox = new System.Windows.Forms.PictureBox();
            this.downLoadBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize) (this.uploadBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.downLoadBox)).BeginInit();
            this.SuspendLayout();
            // 
            // uploadBox
            // 
            this.uploadBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uploadBox.Image = global::ODZ_TSPP.Properties.Resources.Download;
            this.uploadBox.Location = new System.Drawing.Point(182, 6);
            this.uploadBox.Name = "uploadBox";
            this.uploadBox.Size = new System.Drawing.Size(110, 93);
            this.uploadBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.uploadBox.TabIndex = 0;
            this.uploadBox.TabStop = false;
            this.uploadBox.Click += new System.EventHandler(this.download_Click);
            // 
            // downLoadBox
            // 
            this.downLoadBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.downLoadBox.Image = global::ODZ_TSPP.Properties.Resources.upload;
            this.downLoadBox.Location = new System.Drawing.Point(37, 6);
            this.downLoadBox.Name = "downLoadBox";
            this.downLoadBox.Size = new System.Drawing.Size(101, 93);
            this.downLoadBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.downLoadBox.TabIndex = 1;
            this.downLoadBox.TabStop = false;
            this.downLoadBox.Click += new System.EventHandler(this.upload_Click);
            // 
            // UploadOrDownLoadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(328, 101);
            this.ControlBox = false;
            this.Controls.Add(this.downLoadBox);
            this.Controls.Add(this.uploadBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UploadOrDownLoadForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize) (this.uploadBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.downLoadBox)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox downLoadBox;
        private System.Windows.Forms.PictureBox uploadBox;

        #endregion
    }
}