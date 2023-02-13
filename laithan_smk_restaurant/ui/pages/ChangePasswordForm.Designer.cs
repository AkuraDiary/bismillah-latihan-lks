
namespace laithan_smk_restaurant
{
    partial class ChangePasswordForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.edtConfirmPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.edtOldPassword = new System.Windows.Forms.TextBox();
            this.btnSaveNewPassword = new System.Windows.Forms.Button();
            this.edtNewPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(160, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Confirm Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // edtConfirmPassword
            // 
            this.edtConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtConfirmPassword.Location = new System.Drawing.Point(164, 239);
            this.edtConfirmPassword.Name = "edtConfirmPassword";
            this.edtConfirmPassword.Size = new System.Drawing.Size(231, 24);
            this.edtConfirmPassword.TabIndex = 10;
            this.edtConfirmPassword.UseSystemPasswordChar = true;
            this.edtConfirmPassword.TextChanged += new System.EventHandler(this.edtConfirmPassword_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "New Password";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // edtOldPassword
            // 
            this.edtOldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtOldPassword.Location = new System.Drawing.Point(164, 112);
            this.edtOldPassword.Name = "edtOldPassword";
            this.edtOldPassword.Size = new System.Drawing.Size(231, 24);
            this.edtOldPassword.TabIndex = 6;
            this.edtOldPassword.UseSystemPasswordChar = true;
            // 
            // btnSaveNewPassword
            // 
            this.btnSaveNewPassword.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSaveNewPassword.Enabled = false;
            this.btnSaveNewPassword.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveNewPassword.ForeColor = System.Drawing.Color.White;
            this.btnSaveNewPassword.Location = new System.Drawing.Point(164, 295);
            this.btnSaveNewPassword.Name = "btnSaveNewPassword";
            this.btnSaveNewPassword.Size = new System.Drawing.Size(231, 44);
            this.btnSaveNewPassword.TabIndex = 5;
            this.btnSaveNewPassword.Text = "Save";
            this.btnSaveNewPassword.UseVisualStyleBackColor = false;
            this.btnSaveNewPassword.Click += new System.EventHandler(this.btnSaveNewPassword_Click);
            // 
            // edtNewPassword
            // 
            this.edtNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtNewPassword.Location = new System.Drawing.Point(164, 173);
            this.edtNewPassword.Name = "edtNewPassword";
            this.edtNewPassword.Size = new System.Drawing.Size(231, 24);
            this.edtNewPassword.TabIndex = 8;
            this.edtNewPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(160, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Old Password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnCancel.Location = new System.Drawing.Point(164, 345);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(231, 29);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 424);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edtConfirmPassword);
            this.Controls.Add(this.edtNewPassword);
            this.Controls.Add(this.edtOldPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaveNewPassword);
            this.Name = "ChangePasswordForm";
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.ChangePasswordForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edtConfirmPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edtOldPassword;
        private System.Windows.Forms.Button btnSaveNewPassword;
        private System.Windows.Forms.TextBox edtNewPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
    }
}