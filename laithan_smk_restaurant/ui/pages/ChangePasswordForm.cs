using laithan_smk_restaurant.data.repository;
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

namespace laithan_smk_restaurant
{
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }


        private void btnSaveNewPassword_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(edtOldPassword.Text))
            {
                MessageBox.Show("Please confirm your old password");
            }
            else if (!edtOldPassword.Text.Equals(AuthNotifier.loggedInEmployee.password))
            {
                MessageBox.Show("Old Password didn't match");
            }
            else
            {
                Repository.changePasswordEmployee(AuthNotifier.loggedInEmployee, edtNewPassword.Text);
                AuthNotifier.doLogout();
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
        }

        private void edtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (edtConfirmPassword.Text.Equals(edtNewPassword.Text))
            {
                btnSaveNewPassword.Enabled = true;
            }
            else
            {
                btnSaveNewPassword.Enabled = false;
            }
                        
        }

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
