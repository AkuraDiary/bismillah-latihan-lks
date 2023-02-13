using laithan_smk_restaurant.data.source.edm;
using laithan_smk_restaurant.ui.notifier;
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

namespace laithan_smk_restaurant.ui.pages
{
    public partial class FragmentManageMenu : UserControl
    {
        private msmenu selectedMenu = null;
        //Image selectedImgFromFile;
        public FragmentManageMenu()
        {
            InitializeComponent();
        }


        private void setupDataGridView()
        {
            menuDataGridView.Refresh();
            menuDataGridView.ClearSelection();

            AdminNotifier.getAllMenuData();
            menuDataGridView.DataSource = AdminNotifier.listMenu;
         

        }

        private void bindSelectedMenuData()
        {
            if (selectedMenu != null)
            {
                edtMenuId.Text = selectedMenu.menu_id.ToString();
                edtMenuName.Text = selectedMenu.name;
                edtMenuPrice.Value = selectedMenu.price;
                edtMenuImgName.Text = selectedMenu.img_name;
                
            }
        }

        private bool formIsValid() { 
            
            if (string.IsNullOrEmpty(edtMenuPrice.Text))
            {
                MessageBox.Show("Harga Boleh Kosong");
                return false;
            }
            else if (string.IsNullOrEmpty(edtMenuImgName.Text))
            {
                MessageBox.Show("Gambar Tidak Boleh Kosong");
                return false;
            }
            else if (picBoxMenu.Image == null)
            {
                MessageBox.Show("Image Tidak Boleh Kosong");
                return false;
            }
            else
            {
                return true;
            }
        }


        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (formIsValid())
            {
                msmenu menuModel = new msmenu();

                ImageConverter imgConverter = new ImageConverter();

                menuModel.name = edtMenuName.Text;
                menuModel.price = (int)edtMenuPrice.Value;
                menuModel.photo = (byte[]) imgConverter.ConvertTo(picBoxMenu.Image, typeof(byte[]));
                menuModel.img_name = edtMenuImgName.Text; // default pass
                AdminNotifier.addMenu(menuModel);

                setupDataGridView(); // refresh the data grid view
            }
            clearField();
        }

  

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (selectedMenu != null)
            {
                selectedMenu.name = edtMenuName.Text;
                selectedMenu.price = (int)edtMenuPrice.Value;
                selectedMenu.img_name = edtMenuImgName.Text;

                ImageConverter imgConverter = new ImageConverter();
                selectedMenu.photo = (byte[])imgConverter.ConvertTo(picBoxMenu.Image, typeof(byte[]));

                AdminNotifier.updateMenu(selectedMenu);

                setupDataGridView(); // refresh the data grid view
            }

            clearField();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedMenu != null)
            {
                AdminNotifier.deleteMenu(selectedMenu.menu_id);
                setupDataGridView();
            }
            clearField();
        }

        private void picBoxMenu_Click(object sender, EventArgs e)
        {
            imgOpenFileDialog.ShowDialog();
        }

        private void menuDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            selectedMenu = new msmenu();

            foreach (DataGridViewRow row in menuDataGridView.SelectedRows)
            {
                selectedMenu.menu_id = (int)row.Cells[0].Value;
                selectedMenu.name = row.Cells[1].Value.ToString();
                selectedMenu.price = (int)row.Cells[2].Value;

                selectedMenu.photo = (Byte[])row.Cells[3].Value;

                MemoryStream imageStream = new MemoryStream(selectedMenu.photo);
                picBoxMenu.Image = Image.FromStream(imageStream);
                

                selectedMenu.img_name = row.Cells[4].Value.ToString();
            }
            bindSelectedMenuData();
        }

        private void FragmentManageMenu_Load(object sender, EventArgs e)
        {
            setupDataGridView();
        }

        private void imgOpenFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            this.picBoxMenu.Image = Image.FromFile(imgOpenFileDialog.FileName);
            edtMenuImgName.Text = imgOpenFileDialog.FileName;
        }

        private void edtMenuName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(edtMenuName.Text))
            {
                menuDataGridView.ClearSelection();
            }
        }

        private void clearField()
        {
            edtMenuId.Text = "";
            edtMenuName.Text = "";
            edtMenuImgName.Text = "";
            edtMenuPrice.Value = 0;
            picBoxMenu.Image = null;
            selectedMenu = null;
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearField();
        }
    }
}
