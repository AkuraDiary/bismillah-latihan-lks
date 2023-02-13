using laithan_smk_restaurant.data.repository;
using laithan_smk_restaurant.data.source.edm;
using laithan_smk_restaurant.ui.notifier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laithan_smk_restaurant.ui.pages
{
    public partial class OrderForm : Form
    {
        private msmenu selectedMenu = null;
        int totalPrice = 0;
        msmember selectedMember = null;
        public OrderForm()
        {
            InitializeComponent();
        }

        private void btnLoginEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            setupMenusDataGridView();
            setupMemberDataGridView();
        }

        private void menusDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            selectedMenu = new msmenu();

            foreach (DataGridViewRow row in menusDataGridView.SelectedRows)
            {
                selectedMenu.menu_id = (int)row.Cells[0].Value;
                selectedMenu.name = row.Cells[1].Value.ToString();
                selectedMenu.price = (int)row.Cells[2].Value;

                selectedMenu.photo = (Byte[])row.Cells[3].Value;
                selectedMenu.img_name = row.Cells[4].Value.ToString();
                MemoryStream imageStream = new MemoryStream(selectedMenu.photo);
                picBoxMenu.Image = Image.FromStream(imageStream);

            }
            edtItemQty.Value = 1; //default is 1
           
            bindSelectedMenuData();
        }
        private void bindSelectedMenuData()
        {
            if (selectedMenu != null)
            {
                lblItemName.Text = selectedMenu.name;
                lblItemPrice.Text = selectedMenu.price.ToString();
            }
        }

        private void setupMenusDataGridView()
        {
            menusDataGridView.Refresh();
            menusDataGridView.ClearSelection();

            AdminNotifier.getAllMenuData();
            menusDataGridView.DataSource = AdminNotifier.listMenu;
        }

        private void tempMenuDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            selectedMenu = new msmenu();


            foreach (DataGridViewRow row in tempMenuDataGridView.SelectedRows)
            {
                selectedMenu.menu_id = (int)row.Cells[0].Value;
                selectedMenu.name = row.Cells[1].Value.ToString();
                selectedMenu.price = (int)row.Cells[2].Value;
                edtItemQty.Value = int.Parse(row.Cells[3].Value.ToString());

                selectedMenu.photo = (Byte[])row.Cells[5].Value;

                MemoryStream imageStream = new MemoryStream(selectedMenu.photo);
                picBoxMenu.Image = Image.FromStream(imageStream);
               
            }
            bindSelectedMenuData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(tempMenuDataGridView.RowCount > 0 & tempMenuDataGridView.SelectedRows.Count > 0)
            {
                if ((int)tempMenuDataGridView.SelectedRows[0].Cells[0].Value == selectedMenu.menu_id) // if edit or already added
                {
                    tempMenuDataGridView.SelectedRows[0].Cells[3].Value = edtItemQty.Value;
                }
            }

            else
            {
                try
                {
                    tempMenuDataGridView.Rows.Add(
                    selectedMenu.menu_id,
                    selectedMenu.name,
                    selectedMenu.price,
                    edtItemQty.Value,
                    selectedMenu.price * edtItemQty.Value,
                    selectedMenu.photo
                    );
                }catch (Exception)
                {
                    MessageBox.Show("Pilih member terlebih Dahulu");
                }
                
            }
            clearField();
            calculateTotal();
        }

        private void clearField()
        {
            selectedMenu = null;
            lblItemName.Text = "";
            lblItemPrice.Text = "";
            edtItemQty.Value = 0;
            picBoxMenu.Image = null;
            lblTotal.Text = "";
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (tempMenuDataGridView.Rows.Count  > 0)
            {
                string employeeId = Repository.getRandomChef();

                string idHeaderOrder = OrderNotifier.placeOrder(selectedMember.member_id, employeeId, totalPrice);

                foreach (DataGridViewRow row in tempMenuDataGridView.Rows)
                {
                    detailorder detailOrderModel = new detailorder();
                    detailOrderModel.order_id = idHeaderOrder;

                    detailOrderModel.menu_id = (int)row.Cells[0].Value;

                    int qty =(int)Math.Round((decimal)row.Cells[3].Value, 0);
                    //MessageBox.Show("IDK ANYMORE " + (row.Cells[3].Value).GetType() + " " + qty);

                    detailOrderModel.qty = qty;

                    detailOrderModel.price = (qty * (int)row.Cells[2].Value);

                    detailOrderModel.status = "pending";//default

                  

                    OrderNotifier.placeOrderItemDetail(detailOrderModel);
                }

                clearField();
                tempMenuDataGridView.Rows.Clear();
            }
            else
            {
                MessageBox.Show("Pleace Add An Item first");
            }
            
        }
        
        private void setupMemberDataGridView()
        {
            membersDataGridView.Refresh();

            membersDataGridView.ClearSelection();
            selectedMember = null;

            AdminNotifier.getAllMemberData();
            membersDataGridView.DataSource = AdminNotifier.listMember;
            clearField();
        }
        private void membersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            selectedMember = new msmember();
            btnRemoveItem.Enabled = btnPlaceOrder.Enabled = btnAdd.Enabled = true;
            

            foreach (DataGridViewRow row in membersDataGridView.SelectedRows)
            {
                selectedMember.member_id = row.Cells[0].Value.ToString();
                selectedMember.name = row.Cells[1].Value.ToString();
            }
            tempMenuDataGridView.ClearSelection();
            tempMenuDataGridView.Rows.Clear();
            lblPelanggan.Text = "Atas Nama : " + selectedMember.name;
        }

        private void calculateTotal()
        {
            totalPrice = 0;
            foreach (DataGridViewRow row in tempMenuDataGridView.Rows)
            {
                //lblTotal.Text = row.Cells[4].Value.ToString();
                
                totalPrice += int.Parse(row.Cells[4].Value.ToString());
            }
            CultureInfo culture = new CultureInfo("id-ID");
            lblTotal.Text = totalPrice.ToString("C", culture);
            
        }
        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if ((int)tempMenuDataGridView.SelectedRows[0].Cells[0].Value == selectedMenu.menu_id) // if edit or already added
            {
                tempMenuDataGridView.Rows.Remove(tempMenuDataGridView.SelectedRows[0]);
            }
            clearField();
            calculateTotal();
        }

        private void edtItemQty_ValueChanged(object sender, EventArgs e)
        {
           
        }
    }
}
