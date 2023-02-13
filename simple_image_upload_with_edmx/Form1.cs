using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace latihan_smk_restaurant
{
    public partial class Form1 : Form
    {
        Image img;

        cobaEntities dbentities = new cobaEntities();
        
        public Form1()
        {
            InitializeComponent();
            showImages();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            submitImage.Enabled = true;
            var pic_filename = openFileDialog.FileName;
            this.img = Image.FromFile(pic_filename);
            imgPicBox.Image = img;

        }

        private void imgPicBox_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void submitImage_Click(object sender, EventArgs e)
        {
            ImageConverter converter = new ImageConverter();
            byte[] imgDataToUpload = (byte[])converter.ConvertTo(this.img, typeof(byte[]));

            gambarGambar dataModel = new gambarGambar(
                
                );
            dataModel.nama = "image";
            dataModel.content = imgDataToUpload;

            dbentities.gambarGambars.Add(dataModel);
            dbentities.SaveChanges();

            imgPicBox.Image = null; // clear image

            showImages();
        }

        private void showImages()
        {
            
            List<gambarGambar> listImage = dbentities.gambarGambars.ToList();
            showImagePanel.Controls.Clear();
            foreach (gambarGambar listImageItem in listImage)
            {
                PictureBox imageToShow = new PictureBox();
                imageToShow.SizeMode = PictureBoxSizeMode.Zoom;

                MemoryStream imgStream = new MemoryStream(listImageItem.content);

                imageToShow.Image = Image.FromStream(imgStream); //4listImageItem//.content;
                showImagePanel.Controls.Add(imageToShow);
            }
            
        }
    }
}
