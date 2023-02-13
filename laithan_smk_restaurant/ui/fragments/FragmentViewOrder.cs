using laithan_smk_restaurant.data.source.edm;
using laithan_smk_restaurant.ui.notifier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laithan_smk_restaurant.ui.pages
{
    public partial class FragmentViewOrder : UserControl
    {
        private detailorder selectedDetailOrder = null;
        private headerorder selectedHeaderDetailOrder = null;
        public FragmentViewOrder()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ChefNotifier.updateStatusOrderDetail(selectedDetailOrder.detail_id, edtOrderStatus.SelectedItem.ToString());
            setupDetailOrderDataGridView(selectedHeaderDetailOrder.order_id);
            edtOrderStatus.SelectedItem = null;
            selectedDetailOrder = null;
        }


        private void FragmentViewOrder_Load(object sender, EventArgs e)
        {
            setupHeaderOrderDataGridView();
        }

        private void setupHeaderOrderDataGridView()
        {
            headerOrderDataGridView.Refresh();

            detailOrderDataGridView.ClearSelection();
            selectedHeaderDetailOrder = null;
            selectedDetailOrder = null;

            ChefNotifier.getAllHeaderOrder();
            headerOrderDataGridView.DataSource = ChefNotifier.listHeaderOrder;
        }

        private void setupDetailOrderDataGridView(string orderId)
        {
            detailOrderDataGridView.Refresh();

            detailOrderDataGridView.ClearSelection();
            selectedDetailOrder = null;

            ChefNotifier.getAllDetailOrder(orderId);
            detailOrderDataGridView.DataSource = ChefNotifier.listDetailOrder;

            foreach (DataGridViewRow row in detailOrderDataGridView.Rows)
            {
                msmenu item = (msmenu)row.Cells[5].Value;
                row.Cells[1].Value = item.name;
            }
        }

        private void detailOrderDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            selectedDetailOrder = new detailorder();

            foreach (DataGridViewRow row in detailOrderDataGridView.SelectedRows)
            {
                selectedDetailOrder.detail_id =(int) row.Cells[0].Value;

                selectedDetailOrder.qty = (int)row.Cells[2].Value;
                selectedDetailOrder.price = (int)row.Cells[3].Value;
                selectedDetailOrder.status = row.Cells[4].Value.ToString();
                selectedDetailOrder.msmenu = (msmenu)row.Cells[5].Value;

               
                edtOrderStatus.SelectedItem = selectedDetailOrder.status;
            }
            //bindSelectedEmployeeData();
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
    }
}
