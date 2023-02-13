using laithan_smk_restaurant.data.source.edm;
using laithan_smk_restaurant.ui.helper;
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
    public partial class FragmentManageEmployee : UserControl
    {
        msemployee selectedEmployee = null;
        public FragmentManageEmployee()
        {
            InitializeComponent();
        }

        private void FragmentManageEmployee_Load(object sender, EventArgs e)
        {
            
            setupDataGridView();
        }


        private bool formIsValid()
        {
            if (string.IsNullOrEmpty(edtEmail.Text))
            {
                MessageBox.Show("Email Tidak Boleh Kosong");
                return false;
            }
            else if (string.IsNullOrEmpty(edtEmployeeName.Text))
            {
                MessageBox.Show("Nama Tidak Boleh Kosong");
                return false;
            }
            else if (string.IsNullOrEmpty(edtHandphone.Text))
            {
                MessageBox.Show("No HP Tidak Boleh Kosong");
                return false;
            }
            else if (string.IsNullOrEmpty(edtEmployeeRole.SelectedItem.ToString()))
            {
                MessageBox.Show("Posisi Tidak Boleh Kosong");
                return false;
            }
            else
            {
                return true;
            }
        }
        private void setupDataGridView()
        {
            employeeDataGridView.Refresh();

            employeeDataGridView.ClearSelection();
            selectedEmployee = null;

            AdminNotifier.getAllEmployeeData();
            employeeDataGridView.DataSource = AdminNotifier.listEmployee;

        }

        private void employeeDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            selectedEmployee = new msemployee();

            foreach (DataGridViewRow row in employeeDataGridView.SelectedRows)
            {
                selectedEmployee.employee_id = row.Cells[0].Value.ToString();
                selectedEmployee.name = row.Cells[1].Value.ToString();
                selectedEmployee.email = row.Cells[2].Value.ToString();
                selectedEmployee.handphone = row.Cells[3].Value.ToString();
                selectedEmployee.position = row.Cells[4].Value.ToString();
            }
            bindSelectedEmployeeData();
        }

        private void bindSelectedEmployeeData()
        {
            if(selectedEmployee != null)
            {
                edtEmployeeName.Text = selectedEmployee.name;
                edtEmail.Text = selectedEmployee.email;
                edtHandphone.Text = selectedEmployee.handphone;
                edtEmployeeRole.Text = selectedEmployee.position;
                
            }
        }

        private string generateNewEmployeeId()
        {
            string newEmployeeID;
            if (edtEmployeeRole.SelectedItem.ToString().Equals("admin"))
            {
                newEmployeeID = "ADM-" + TextHelperUtils.generateRandomString(8);
            }
            else if (edtEmployeeRole.SelectedItem.ToString().Equals("chef"))
            {
                newEmployeeID = "CHF-" + TextHelperUtils.generateRandomString(8);
            }
            else
            {
                newEmployeeID = "CSH-" + TextHelperUtils.generateRandomString(8);
            }

            return newEmployeeID;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (formIsValid())
            {
                msemployee employeeModel = new msemployee();
                employeeModel.employee_id = generateNewEmployeeId();

                employeeModel.name = edtEmployeeName.Text;
                employeeModel.email = edtEmail.Text;
                employeeModel.handphone = edtHandphone.Text;
                employeeModel.position = edtEmployeeRole.SelectedItem.ToString();
                employeeModel.password = "123"; // default pass

                AdminNotifier.addEmployee(employeeModel);

                setupDataGridView(); // refresh the data grid view
            }
            clearField();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if(selectedEmployee != null)
            {
                selectedEmployee.name = edtEmployeeName.Text;
                selectedEmployee.email = edtEmail.Text;
                selectedEmployee.handphone = edtHandphone.Text;

                //if the role change, the id should change
                if (!selectedEmployee.position.Equals(edtEmployeeRole.SelectedItem.ToString())){
                    selectedEmployee.employee_id = generateNewEmployeeId();
                }

                selectedEmployee.position = edtEmployeeRole.SelectedItem.ToString();

                AdminNotifier.updateEmployee(selectedEmployee);

                setupDataGridView(); // refresh the data grid view
            }
            clearField();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(selectedEmployee != null)
            {
                AdminNotifier.deleteEmployee(selectedEmployee.employee_id);
                setupDataGridView(); // refresh the data grid view
            }
            clearField();
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearField();
        }

        private void clearField()
        {
            selectedEmployee = null;
            edtEmail.Text = "";
            edtEmployeeName.Text = "";
            edtEmployeeRole.Text = "";
            edtHandphone.Text = "";
        }
    }
}
