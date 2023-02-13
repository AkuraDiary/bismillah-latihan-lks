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

namespace laithan_smk_restaurant
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string mode = AuthNotifier.loggedInEmployee.position;

            changeMode(mode);

            lblWelcome.Text = "Welcome " + AuthNotifier.loggedInEmployee.name;

            hideAllFragment();
        }


        #region navigation helper method

        private void hideAllNavPanel()
        {
            adminNavPanel.Visible = cashierNavPanel.Visible = chefNavPanel.Visible = false;
        }

        private void showNavigationPanel(Panel navPanel)
        {
            hideAllNavPanel();
            navPanel.Visible = true;
        }

        private void hideAllFragment()
        {
            foreach (UserControl userControl in mainNavigationFragmentContainer.Controls)
            {
                userControl.Visible = false;
            }
        }

        private void showFragment(UserControl fragment)
        {
            hideAllFragment();
            fragment.Visible = true;
        }

        private void changeMode(String mode)
        {
            
            if (mode.Equals("admin"))
            {
                showNavigationPanel(adminNavPanel);

            }
            else if (mode.Equals("cashier"))
            {
                showNavigationPanel(cashierNavPanel);
            }
            else
            {
                showNavigationPanel(chefNavPanel);
            }
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            changeMode("cashier");
        }

        private void btnChef_Click(object sender, EventArgs e)
        {
            changeMode("chef");
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            changeMode("admin");
        }

        #endregion

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changePasswordForm = new ChangePasswordForm();
            this.Hide();
            changePasswordForm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //todo do logout here
            AuthNotifier.doLogout();
            LoginForm changePasswordForm = new LoginForm();
            this.Hide();
            changePasswordForm.Show();
        }

        #region navigationButton click
        private void btnNavPayment_Click(object sender, EventArgs e)
        {
            showFragment(fragmentPayment);
        }
        private void btnNavViewOrder_Click(object sender, EventArgs e)
        {
            showFragment(fragmentViewOrder);
        }
        private void btnNavManageEmployee_Click(object sender, EventArgs e)
        {
            showFragment(fragmentManageEmployee);
        }

        private void btnNavManageMenu_Click(object sender, EventArgs e)
        {
            showFragment(fragmentManageMenu);
        }

        private void btnNavManageMember_Click(object sender, EventArgs e)
        {
            showFragment(fragmentManageMember);
        }


        #endregion

    }
}
