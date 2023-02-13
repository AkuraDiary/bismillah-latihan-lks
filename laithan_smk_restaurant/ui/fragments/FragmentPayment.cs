using laithan_smk_restaurant.data.source.edm;
using laithan_smk_restaurant.ui.notifier;
using laithan_smk_restaurant.ui.pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laithan_smk_restaurant.ui.fragments
{
    public partial class FragmentPayment : UserControl
    {
        //private detailorder selectedDetailOrder = null;
        private headerorder selectedHeaderDetailOrder = null;
        private int totalPriceOrder = 0;
        public FragmentPayment()
        {
            InitializeComponent();
        }

        private void edtMetodeBayar_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblBayar.Text = edtMetodeBayar.SelectedItem.ToString();
            
                lblKembalian.Visible = edtMetodeBayar.SelectedIndex == 0;
            
        }


        private void setupHeaderOrderDataGridView()
        {
            headerOrderDataGridView.Refresh();

            detailOrderDataGridView.ClearSelection();
            selectedHeaderDetailOrder = null;
            //selectedDetailOrder = null;

            CashierNotifier.getPendingHeaderOrder();
            headerOrderDataGridView.DataSource = CashierNotifier.listUnfinishedHeaderOrder;
        }

        private void setupDetailOrderDataGridView(string orderId)
        {
            detailOrderDataGridView.Refresh();
            totalPriceOrder = 0;
            detailOrderDataGridView.ClearSelection();
            //selectedDetailOrder = null;

            ChefNotifier.getAllDetailOrder(orderId);
            detailOrderDataGridView.DataSource = ChefNotifier.listDetailOrder;

            foreach (DataGridViewRow row in detailOrderDataGridView.Rows)
            {
                msmenu item = (msmenu)row.Cells[4].Value;
                row.Cells[1].Value = item.name;
                row.Cells[3].Value = item.price;

                int qty = (int)row.Cells[2].Value;
                int price = (int)row.Cells[3].Value;

                totalPriceOrder += qty * price;
            }

            CultureInfo culture = new CultureInfo("id-ID");
            
            lblTotal.Text = totalPriceOrder.ToString("C", culture) ;

        }

      

        private void headerOrderDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            selectedHeaderDetailOrder = new headerorder();

            foreach (DataGridViewRow row in headerOrderDataGridView.SelectedRows)
            {
                selectedHeaderDetailOrder.order_id = row.Cells[0].Value.ToString();
                setupDetailOrderDataGridView(selectedHeaderDetailOrder.order_id);
            }
        }

        private void FragmentPayment_Load(object sender, EventArgs e)
        {
            setupHeaderOrderDataGridView();
            edtMetodeBayar.SelectedIndex = 1;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if(edtMetodeBayar.SelectedIndex == 0)
            {
                CashierNotifier.submitPayment(selectedHeaderDetailOrder.order_id, "paid");
            }
            else
            {
                CashierNotifier.submitPayment(selectedHeaderDetailOrder.order_id, "paid", edtPayment.Text);
            }
            //detailOrderDataGridView.Rows.Clear();
            setupHeaderOrderDataGridView();
            
        }

        private void edtPayment_TextChanged(object sender, EventArgs e)
        {
            if (edtMetodeBayar.SelectedIndex == 0)
            {
                if (!string.IsNullOrEmpty(edtPayment.Text))
                {
                    lblKembalian.Text = "Kembalian : " + (int.Parse(edtPayment.Text) - totalPriceOrder).ToString();
                }
            }
        }

        private void btnToLaporan_Click(object sender, EventArgs e)
        {
            this.FindForm().Hide();
            
            ReportForm reportForm = new ReportForm();
            reportForm.Show();
        }
    }
}
