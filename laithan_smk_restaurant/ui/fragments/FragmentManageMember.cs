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
    public partial class FragmentManageMember : UserControl
    {
        msmember selectedMember = null;
        public FragmentManageMember()
        {
            InitializeComponent();
        }

        private void FragmentManageMember_Load(object sender, EventArgs e)
        {
            setupDataGridView();
        }
        private bool formIsValid()
        {
            if (string.IsNullOrEmpty(edtMemberName.Text))
            {
                MessageBox.Show("Nama Tidak Boleh Kosong");
                return false;
            }
            else if (string.IsNullOrEmpty(edtMemberHandphone.Text))
            {
                MessageBox.Show("Handphone Boleh Kosong");
                return false;
            }
            else if (string.IsNullOrEmpty(edtMemberEmail.Text))
            {
                MessageBox.Show("Email Tidak Boleh Kosong");
                return false;
            }
        
            else
            {
                return true;
            }
        }
        private void setupDataGridView()
        {
            membersDataGridView.Refresh();

            membersDataGridView.ClearSelection();
            selectedMember = null;

            AdminNotifier.getAllMemberData();
            membersDataGridView.DataSource = AdminNotifier.listMember;
            clearField();
        }

        private void bindSelectedEmployeeData()
        {
            if (selectedMember != null)
            {
                edtMemberName.Text = selectedMember.name;
                edtMemberEmail.Text = selectedMember.email;
                edtMemberHandphone.Text = selectedMember.handphone;
                lblMemberId.Text = selectedMember.member_id;
            }
        }

        private void clearField()
        {
                edtMemberName.Text = "";
                edtMemberEmail.Text = "";
                edtMemberHandphone.Text = "";
                lblMemberId.Text = "";
            selectedMember = null;
        }


        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (formIsValid())
            {
                msmember membermodel = new msmember();
                membermodel.member_id = generateNewMemberId();

                membermodel.name = edtMemberName.Text;
                membermodel.email = edtMemberEmail.Text;
                membermodel.handphone = edtMemberHandphone.Text;
                membermodel.join_date = DateTime.Now;
               

                AdminNotifier.addMember(membermodel);

                setupDataGridView(); // refresh the data grid view
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedMember != null)
            {
                selectedMember.name = edtMemberName.Text;
                selectedMember.email = edtMemberName.Text;
                selectedMember.handphone = edtMemberName.Text;

                AdminNotifier.updateMember(selectedMember);

                setupDataGridView(); // refresh the data grid view
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedMember != null)
            {
                AdminNotifier.deleteMember(selectedMember.member_id);
                setupDataGridView(); // refresh the data grid view
            }
        }
        private string generateNewMemberId()
        {
             return  "Member-" + TextHelperUtils.generateRandomString(8);
            
        }

        private void membersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            selectedMember = new msmember();

            foreach (DataGridViewRow row in membersDataGridView.SelectedRows)
            {
                selectedMember.member_id = row.Cells[0].Value.ToString();
                selectedMember.name = row.Cells[1].Value.ToString();
                selectedMember.email = row.Cells[2].Value.ToString();
                selectedMember.handphone = row.Cells[3].Value.ToString();
                //selectedMember.position = row.Cells[4].Value.ToString();
            }
            bindSelectedEmployeeData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearField();
        }
    }
}
