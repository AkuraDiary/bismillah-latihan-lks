
namespace laithan_smk_restaurant
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblWelcome = new System.Windows.Forms.Label();
            this.adminNavPanel = new System.Windows.Forms.Panel();
            this.btnNavManageMember = new System.Windows.Forms.Button();
            this.btnNavManageMenu = new System.Windows.Forms.Button();
            this.btnNavManageEmployee = new System.Windows.Forms.Button();
            this.mainNavigationFragmentContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.chefNavPanel = new System.Windows.Forms.Panel();
            this.btnNavViewOrder = new System.Windows.Forms.Button();
            this.cashierNavPanel = new System.Windows.Forms.Panel();
            this.btnNavPayment = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnChef = new System.Windows.Forms.Button();
            this.btnCashier = new System.Windows.Forms.Button();
            this.fragmentPayment = new laithan_smk_restaurant.ui.fragments.FragmentPayment();
            this.fragmentViewOrder = new laithan_smk_restaurant.ui.pages.FragmentViewOrder();
            this.fragmentManageMenu = new laithan_smk_restaurant.ui.pages.FragmentManageMenu();
            this.fragmentManageEmployee = new laithan_smk_restaurant.ui.pages.FragmentManageEmployee();
            this.fragmentManageMember = new laithan_smk_restaurant.ui.pages.FragmentManageMember();
            this.adminNavPanel.SuspendLayout();
            this.mainNavigationFragmentContainer.SuspendLayout();
            this.chefNavPanel.SuspendLayout();
            this.cashierNavPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(0, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(155, 48);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome ";
            // 
            // adminNavPanel
            // 
            this.adminNavPanel.Controls.Add(this.btnNavManageMember);
            this.adminNavPanel.Controls.Add(this.btnNavManageMenu);
            this.adminNavPanel.Controls.Add(this.btnNavManageEmployee);
            this.adminNavPanel.Location = new System.Drawing.Point(8, 51);
            this.adminNavPanel.Name = "adminNavPanel";
            this.adminNavPanel.Size = new System.Drawing.Size(239, 609);
            this.adminNavPanel.TabIndex = 1;
            // 
            // btnNavManageMember
            // 
            this.btnNavManageMember.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNavManageMember.FlatAppearance.BorderSize = 0;
            this.btnNavManageMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavManageMember.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavManageMember.ForeColor = System.Drawing.Color.White;
            this.btnNavManageMember.Location = new System.Drawing.Point(0, 113);
            this.btnNavManageMember.Name = "btnNavManageMember";
            this.btnNavManageMember.Size = new System.Drawing.Size(236, 49);
            this.btnNavManageMember.TabIndex = 3;
            this.btnNavManageMember.Text = "Manage Member";
            this.btnNavManageMember.UseVisualStyleBackColor = false;
            this.btnNavManageMember.Click += new System.EventHandler(this.btnNavManageMember_Click);
            // 
            // btnNavManageMenu
            // 
            this.btnNavManageMenu.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNavManageMenu.FlatAppearance.BorderSize = 0;
            this.btnNavManageMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavManageMenu.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavManageMenu.ForeColor = System.Drawing.Color.White;
            this.btnNavManageMenu.Location = new System.Drawing.Point(0, 58);
            this.btnNavManageMenu.Name = "btnNavManageMenu";
            this.btnNavManageMenu.Size = new System.Drawing.Size(236, 49);
            this.btnNavManageMenu.TabIndex = 2;
            this.btnNavManageMenu.Text = "Manage Menu";
            this.btnNavManageMenu.UseVisualStyleBackColor = false;
            this.btnNavManageMenu.Click += new System.EventHandler(this.btnNavManageMenu_Click);
            // 
            // btnNavManageEmployee
            // 
            this.btnNavManageEmployee.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNavManageEmployee.FlatAppearance.BorderSize = 0;
            this.btnNavManageEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavManageEmployee.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavManageEmployee.ForeColor = System.Drawing.Color.White;
            this.btnNavManageEmployee.Location = new System.Drawing.Point(0, 3);
            this.btnNavManageEmployee.Name = "btnNavManageEmployee";
            this.btnNavManageEmployee.Size = new System.Drawing.Size(236, 49);
            this.btnNavManageEmployee.TabIndex = 1;
            this.btnNavManageEmployee.Text = "Manage Employee";
            this.btnNavManageEmployee.UseVisualStyleBackColor = false;
            this.btnNavManageEmployee.Click += new System.EventHandler(this.btnNavManageEmployee_Click);
            // 
            // mainNavigationFragmentContainer
            // 
            this.mainNavigationFragmentContainer.Controls.Add(this.fragmentPayment);
            this.mainNavigationFragmentContainer.Controls.Add(this.fragmentViewOrder);
            this.mainNavigationFragmentContainer.Controls.Add(this.fragmentManageMenu);
            this.mainNavigationFragmentContainer.Controls.Add(this.fragmentManageEmployee);
            this.mainNavigationFragmentContainer.Controls.Add(this.fragmentManageMember);
            this.mainNavigationFragmentContainer.Location = new System.Drawing.Point(264, 51);
            this.mainNavigationFragmentContainer.Name = "mainNavigationFragmentContainer";
            this.mainNavigationFragmentContainer.Size = new System.Drawing.Size(1036, 719);
            this.mainNavigationFragmentContainer.TabIndex = 2;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(8, 721);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(239, 49);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.White;
            this.btnChangePassword.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnChangePassword.Location = new System.Drawing.Point(8, 666);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(236, 49);
            this.btnChangePassword.TabIndex = 4;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // chefNavPanel
            // 
            this.chefNavPanel.Controls.Add(this.btnNavViewOrder);
            this.chefNavPanel.Location = new System.Drawing.Point(8, 51);
            this.chefNavPanel.Name = "chefNavPanel";
            this.chefNavPanel.Size = new System.Drawing.Size(239, 609);
            this.chefNavPanel.TabIndex = 4;
            // 
            // btnNavViewOrder
            // 
            this.btnNavViewOrder.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNavViewOrder.FlatAppearance.BorderSize = 0;
            this.btnNavViewOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavViewOrder.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavViewOrder.ForeColor = System.Drawing.Color.White;
            this.btnNavViewOrder.Location = new System.Drawing.Point(0, 3);
            this.btnNavViewOrder.Name = "btnNavViewOrder";
            this.btnNavViewOrder.Size = new System.Drawing.Size(236, 49);
            this.btnNavViewOrder.TabIndex = 1;
            this.btnNavViewOrder.Text = "View Order";
            this.btnNavViewOrder.UseVisualStyleBackColor = false;
            this.btnNavViewOrder.Click += new System.EventHandler(this.btnNavViewOrder_Click);
            // 
            // cashierNavPanel
            // 
            this.cashierNavPanel.Controls.Add(this.btnNavPayment);
            this.cashierNavPanel.Location = new System.Drawing.Point(8, 51);
            this.cashierNavPanel.Name = "cashierNavPanel";
            this.cashierNavPanel.Size = new System.Drawing.Size(239, 609);
            this.cashierNavPanel.TabIndex = 5;
            // 
            // btnNavPayment
            // 
            this.btnNavPayment.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNavPayment.FlatAppearance.BorderSize = 0;
            this.btnNavPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavPayment.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavPayment.ForeColor = System.Drawing.Color.White;
            this.btnNavPayment.Location = new System.Drawing.Point(0, 3);
            this.btnNavPayment.Name = "btnNavPayment";
            this.btnNavPayment.Size = new System.Drawing.Size(236, 49);
            this.btnNavPayment.TabIndex = 1;
            this.btnNavPayment.Text = "Payment";
            this.btnNavPayment.UseVisualStyleBackColor = false;
            this.btnNavPayment.Click += new System.EventHandler(this.btnNavPayment_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.Location = new System.Drawing.Point(264, 12);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(87, 33);
            this.btnAdmin.TabIndex = 6;
            this.btnAdmin.Text = "admin";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Visible = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnChef
            // 
            this.btnChef.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnChef.FlatAppearance.BorderSize = 0;
            this.btnChef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChef.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChef.ForeColor = System.Drawing.Color.White;
            this.btnChef.Location = new System.Drawing.Point(357, 11);
            this.btnChef.Name = "btnChef";
            this.btnChef.Size = new System.Drawing.Size(87, 33);
            this.btnChef.TabIndex = 7;
            this.btnChef.Text = "Chef";
            this.btnChef.UseVisualStyleBackColor = false;
            this.btnChef.Visible = false;
            this.btnChef.Click += new System.EventHandler(this.btnChef_Click);
            // 
            // btnCashier
            // 
            this.btnCashier.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCashier.FlatAppearance.BorderSize = 0;
            this.btnCashier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCashier.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashier.ForeColor = System.Drawing.Color.White;
            this.btnCashier.Location = new System.Drawing.Point(450, 11);
            this.btnCashier.Name = "btnCashier";
            this.btnCashier.Size = new System.Drawing.Size(87, 33);
            this.btnCashier.TabIndex = 8;
            this.btnCashier.Text = "cashier";
            this.btnCashier.UseVisualStyleBackColor = false;
            this.btnCashier.Visible = false;
            this.btnCashier.Click += new System.EventHandler(this.btnCashier_Click);
            // 
            // fragmentPayment
            // 
            this.fragmentPayment.Location = new System.Drawing.Point(3, 3);
            this.fragmentPayment.Name = "fragmentPayment";
            this.fragmentPayment.Size = new System.Drawing.Size(1036, 719);
            this.fragmentPayment.TabIndex = 4;
            // 
            // fragmentViewOrder
            // 
            this.fragmentViewOrder.Location = new System.Drawing.Point(3, 728);
            this.fragmentViewOrder.Name = "fragmentViewOrder";
            this.fragmentViewOrder.Size = new System.Drawing.Size(1036, 719);
            this.fragmentViewOrder.TabIndex = 3;
            // 
            // fragmentManageMenu
            // 
            this.fragmentManageMenu.Location = new System.Drawing.Point(3, 1453);
            this.fragmentManageMenu.Name = "fragmentManageMenu";
            this.fragmentManageMenu.Size = new System.Drawing.Size(1036, 719);
            this.fragmentManageMenu.TabIndex = 2;
            // 
            // fragmentManageEmployee
            // 
            this.fragmentManageEmployee.Location = new System.Drawing.Point(3, 2178);
            this.fragmentManageEmployee.Name = "fragmentManageEmployee";
            this.fragmentManageEmployee.Size = new System.Drawing.Size(1036, 719);
            this.fragmentManageEmployee.TabIndex = 0;
            // 
            // fragmentManageMember
            // 
            this.fragmentManageMember.Location = new System.Drawing.Point(3, 2903);
            this.fragmentManageMember.Name = "fragmentManageMember";
            this.fragmentManageMember.Size = new System.Drawing.Size(1036, 719);
            this.fragmentManageMember.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1312, 782);
            this.Controls.Add(this.btnCashier);
            this.Controls.Add(this.btnChef);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.cashierNavPanel);
            this.Controls.Add(this.adminNavPanel);
            this.Controls.Add(this.chefNavPanel);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.mainNavigationFragmentContainer);
            this.Controls.Add(this.lblWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.adminNavPanel.ResumeLayout(false);
            this.mainNavigationFragmentContainer.ResumeLayout(false);
            this.chefNavPanel.ResumeLayout(false);
            this.cashierNavPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel adminNavPanel;
        private System.Windows.Forms.FlowLayoutPanel mainNavigationFragmentContainer;
        private System.Windows.Forms.Button btnNavManageEmployee;
        private System.Windows.Forms.Button btnNavManageMember;
        private System.Windows.Forms.Button btnNavManageMenu;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Panel chefNavPanel;
        private System.Windows.Forms.Button btnNavViewOrder;
        private System.Windows.Forms.Panel cashierNavPanel;
        private System.Windows.Forms.Button btnNavPayment;
        private ui.fragments.FragmentPayment fragmentPayment;
        private ui.pages.FragmentViewOrder fragmentViewOrder;
        private ui.pages.FragmentManageMenu fragmentManageMenu;
        private ui.pages.FragmentManageEmployee fragmentManageEmployee;
        private ui.pages.FragmentManageMember fragmentManageMember;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnChef;
        private System.Windows.Forms.Button btnCashier;
    }
}