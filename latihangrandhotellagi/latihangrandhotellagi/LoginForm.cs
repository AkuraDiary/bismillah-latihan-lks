using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace latihangrandhotellagi
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (formIsValid()) 
            {
                //TODO LOGIN
                moveToMainForm();
            }
        }

       bool formIsValid()
        {
            if (string.IsNullOrEmpty(edtUsername.Text))
            {
                MessageBox.Show("Username Can't be empty");
                return false;
            }else if (string.IsNullOrEmpty(edtPassword.Text))
            {
                MessageBox.Show("Password Can't be empty");
                return false;
            }
            else {
                return true; 
            }
        }

        private void moveToMainForm()
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
    }
}
