
namespace laithan_smk_restaurant.ui.pages
{
    partial class FragmentManageMenu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.edtMenuName = new System.Windows.Forms.TextBox();
            this.Nama = new System.Windows.Forms.Label();
            this.edtMenuId = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.edtMenuImgName = new System.Windows.Forms.TextBox();
            this.edtMenuPrice = new System.Windows.Forms.NumericUpDown();
            this.picBoxMenu = new System.Windows.Forms.PictureBox();
            this.imgOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuDataGridView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.msmenuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.imgnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.edtMenuPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmenuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(3, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(351, 48);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Fragment Manage Menu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(213, 499);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 23);
            this.label4.TabIndex = 28;
            this.label4.Text = "Price";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(213, 453);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 23);
            this.label3.TabIndex = 26;
            this.label3.Text = "Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // edtMenuName
            // 
            this.edtMenuName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtMenuName.Location = new System.Drawing.Point(360, 453);
            this.edtMenuName.Name = "edtMenuName";
            this.edtMenuName.Size = new System.Drawing.Size(231, 24);
            this.edtMenuName.TabIndex = 27;
            this.edtMenuName.TextChanged += new System.EventHandler(this.edtMenuName_TextChanged);
            // 
            // Nama
            // 
            this.Nama.AutoSize = true;
            this.Nama.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nama.Location = new System.Drawing.Point(213, 414);
            this.Nama.Name = "Nama";
            this.Nama.Size = new System.Drawing.Size(60, 23);
            this.Nama.TabIndex = 24;
            this.Nama.Text = "Menu Id";
            this.Nama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Nama.Visible = false;
            // 
            // edtMenuId
            // 
            this.edtMenuId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtMenuId.Location = new System.Drawing.Point(360, 411);
            this.edtMenuId.Name = "edtMenuId";
            this.edtMenuId.Size = new System.Drawing.Size(231, 24);
            this.edtMenuId.TabIndex = 25;
            this.edtMenuId.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(586, 621);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(175, 41);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(372, 621);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(175, 41);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Location = new System.Drawing.Point(166, 621);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(175, 41);
            this.btnInsert.TabIndex = 21;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 541);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 23);
            this.label1.TabIndex = 30;
            this.label1.Text = "Photo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // edtMenuImgName
            // 
            this.edtMenuImgName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtMenuImgName.Location = new System.Drawing.Point(360, 538);
            this.edtMenuImgName.Name = "edtMenuImgName";
            this.edtMenuImgName.Size = new System.Drawing.Size(231, 24);
            this.edtMenuImgName.TabIndex = 31;
            // 
            // edtMenuPrice
            // 
            this.edtMenuPrice.AutoSize = true;
            this.edtMenuPrice.Location = new System.Drawing.Point(360, 501);
            this.edtMenuPrice.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.edtMenuPrice.Name = "edtMenuPrice";
            this.edtMenuPrice.Size = new System.Drawing.Size(231, 20);
            this.edtMenuPrice.TabIndex = 32;
            this.edtMenuPrice.ThousandsSeparator = true;
            // 
            // picBoxMenu
            // 
            this.picBoxMenu.BackColor = System.Drawing.Color.Transparent;
            this.picBoxMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxMenu.Location = new System.Drawing.Point(701, 390);
            this.picBoxMenu.Name = "picBoxMenu";
            this.picBoxMenu.Size = new System.Drawing.Size(228, 205);
            this.picBoxMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxMenu.TabIndex = 33;
            this.picBoxMenu.TabStop = false;
            this.picBoxMenu.Click += new System.EventHandler(this.picBoxMenu_Click);
            // 
            // imgOpenFileDialog
            // 
            this.imgOpenFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.imgOpenFileDialog_FileOk);
            // 
            // menuDataGridView
            // 
            this.menuDataGridView.AllowUserToAddRows = false;
            this.menuDataGridView.AllowUserToDeleteRows = false;
            this.menuDataGridView.AutoGenerateColumns = false;
            this.menuDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.menuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menuDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.menuidDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.photoDataGridViewImageColumn,
            this.imgnameDataGridViewTextBoxColumn});
            this.menuDataGridView.DataSource = this.msmenuBindingSource;
            this.menuDataGridView.Location = new System.Drawing.Point(11, 51);
            this.menuDataGridView.Name = "menuDataGridView";
            this.menuDataGridView.ReadOnly = true;
            this.menuDataGridView.Size = new System.Drawing.Size(918, 297);
            this.menuDataGridView.TabIndex = 34;
            this.menuDataGridView.SelectionChanged += new System.EventHandler(this.menuDataGridView_SelectionChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(844, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "click  for image";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnCancel.Location = new System.Drawing.Point(474, 568);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(117, 29);
            this.btnCancel.TabIndex = 37;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // msmenuBindingSource
            // 
            this.msmenuBindingSource.DataSource = typeof(laithan_smk_restaurant.data.source.edm.msmenu);
            // 
            // menuidDataGridViewTextBoxColumn
            // 
            this.menuidDataGridViewTextBoxColumn.DataPropertyName = "menu_id";
            this.menuidDataGridViewTextBoxColumn.HeaderText = "menu_id";
            this.menuidDataGridViewTextBoxColumn.Name = "menuidDataGridViewTextBoxColumn";
            this.menuidDataGridViewTextBoxColumn.ReadOnly = true;
            this.menuidDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // photoDataGridViewImageColumn
            // 
            this.photoDataGridViewImageColumn.DataPropertyName = "photo";
            this.photoDataGridViewImageColumn.HeaderText = "photo";
            this.photoDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.photoDataGridViewImageColumn.Name = "photoDataGridViewImageColumn";
            this.photoDataGridViewImageColumn.ReadOnly = true;
            // 
            // imgnameDataGridViewTextBoxColumn
            // 
            this.imgnameDataGridViewTextBoxColumn.DataPropertyName = "img_name";
            this.imgnameDataGridViewTextBoxColumn.HeaderText = "img_name";
            this.imgnameDataGridViewTextBoxColumn.Name = "imgnameDataGridViewTextBoxColumn";
            this.imgnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FragmentManageMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.menuDataGridView);
            this.Controls.Add(this.picBoxMenu);
            this.Controls.Add(this.edtMenuPrice);
            this.Controls.Add(this.edtMenuImgName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.edtMenuName);
            this.Controls.Add(this.Nama);
            this.Controls.Add(this.edtMenuId);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.lblWelcome);
            this.Name = "FragmentManageMenu";
            this.Size = new System.Drawing.Size(1036, 719);
            this.Load += new System.EventHandler(this.FragmentManageMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.edtMenuPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmenuBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edtMenuName;
        private System.Windows.Forms.Label Nama;
        private System.Windows.Forms.TextBox edtMenuId;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edtMenuImgName;
        private System.Windows.Forms.NumericUpDown edtMenuPrice;
        private System.Windows.Forms.PictureBox picBoxMenu;
        private System.Windows.Forms.OpenFileDialog imgOpenFileDialog;
        private System.Windows.Forms.DataGridView menuDataGridView;
        private System.Windows.Forms.BindingSource msmenuBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn menu_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewImageColumn photo;
        private System.Windows.Forms.DataGridViewTextBoxColumn img_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn photoDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imgnameDataGridViewTextBoxColumn;
    }
}
