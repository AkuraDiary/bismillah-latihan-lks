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
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        DateTime dateFrom;
        DateTime dateTo;

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
           
            getDataIncome();
            dtpTo.Value.AddDays(1);
        }

        private void changeDateRange()
        {
            dtpTo.MinDate = dateFrom;

            dtpFrom.MaxDate = dtpTo.Value;

            
        }
        private void getDataIncome()
        {
            ReportNotifier.getAllHeaderOrder();
            setupChart();
        }
        private void setupChart()
        {
            incomeChart.Refresh();
            //Filter The Data

            List<headerorder> listData = ReportNotifier.listHeaderOrder;

            if(dateFrom != null  && dateTo != null)
            {
                listData = listData.Where(
                    item => item.date >= dateFrom && item.date <= dateTo
                    ).ToList();
            }

           // MessageBox.Show(listData.Count.ToString());

            incomeChart.DataSource = listData;
            
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            dateFrom = dtpFrom.Value;
            changeDateRange();
            getDataIncome();
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            dateTo = dtpTo.Value;
            changeDateRange();
           getDataIncome();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            getDataIncome();
        }
    }
}
