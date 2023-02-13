using laithan_smk_restaurant.ui.notifier;
using laithan_smk_restaurant.ui.pages;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (formIsValid())
            {
                doLogin();
            }
        }

        private void moveToMainForm()
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
       private bool formIsValid()
        {
            if (string.IsNullOrEmpty(edtEmail.Text))
            {
                MessageBox.Show("Email Tidak Boleh Kosong");
                return false;
            }
            else if (string.IsNullOrEmpty(edtPassword.Text))
            {
                MessageBox.Show("Password Tidak Boleh Kosong");
                return false;
            }
            else
            {
                return true;
            }
        }
        private void doLogin()
        {
            AuthNotifier.doLoginEmployee(
                edtEmail.Text,
                edtPassword.Text
            );

            if(AuthNotifier.loggedInEmployee != null)
            {
                moveToMainForm();
            }
            else
            {
                MessageBox.Show("Akun Tidak Ditemukan");
            }
            
        }

        private void LoginFrom_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderForm orderForm = new OrderForm();
            orderForm.Show();
        }
    }
}
