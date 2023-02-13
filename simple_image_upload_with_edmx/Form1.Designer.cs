
namespace latihan_smk_restaurant
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.imgPicBox = new System.Windows.Forms.PictureBox();
            this.submitImage = new System.Windows.Forms.Button();
            this.showImagePanel = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.imgPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // imgPicBox
            // 
            this.imgPicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgPicBox.Location = new System.Drawing.Point(402, 27);
            this.imgPicBox.Name = "imgPicBox";
            this.imgPicBox.Size = new System.Drawing.Size(264, 234);
            this.imgPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPicBox.TabIndex = 0;
            this.imgPicBox.TabStop = false;
            this.imgPicBox.Click += new System.EventHandler(this.imgPicBox_Click);
            // 
            // submitImage
            // 
            this.submitImage.Enabled = false;
            this.submitImage.Location = new System.Drawing.Point(537, 291);
            this.submitImage.Name = "submitImage";
            this.submitImage.Size = new System.Drawing.Size(75, 23);
            this.submitImage.TabIndex = 1;
            this.submitImage.Text = "submit";
            this.submitImage.UseVisualStyleBackColor = true;
            this.submitImage.Click += new System.EventHandler(this.submitImage_Click);
            // 
            // showImagePanel
            // 
            this.showImagePanel.Location = new System.Drawing.Point(12, 12);
            this.showImagePanel.Name = "showImagePanel";
            this.showImagePanel.Size = new System.Drawing.Size(350, 399);
            this.showImagePanel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showImagePanel);
            this.Controls.Add(this.submitImage);
            this.Controls.Add(this.imgPicBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imgPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.PictureBox imgPicBox;
        private System.Windows.Forms.Button submitImage;
        private System.Windows.Forms.FlowLayoutPanel showImagePanel;
    }
}

