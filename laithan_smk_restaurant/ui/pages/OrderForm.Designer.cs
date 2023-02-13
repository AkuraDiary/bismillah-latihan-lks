
namespace laithan_smk_restaurant.ui.pages
{
    partial class OrderForm
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
            this.components = new System.ComponentModel.Container();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.picBoxMenu = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.edtItemQty = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblItemPrice = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.menusDataGridView = new System.Windows.Forms.DataGridView();
            this.menu_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photo = new System.Windows.Forms.DataGridViewImageColumn();
            this.img_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msmenuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLoginEmployee = new System.Windows.Forms.Button();
            this.tempMenuDataGridView = new System.Windows.Forms.DataGridView();
            this.menuId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menu_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menu_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.membersDataGridView = new System.Windows.Forms.DataGridView();
            this.memberidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msmemberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.lblPelanggan = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtItemQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menusDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmenuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempMenuDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmemberBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.BackColor = System.Drawing.Color.White;
            this.btnRemoveItem.Enabled = false;
            this.btnRemoveItem.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveItem.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveItem.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnRemoveItem.Location = new System.Drawing.Point(948, 477);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(102, 29);
            this.btnRemoveItem.TabIndex = 42;
            this.btnRemoveItem.Text = "Delete";
            this.btnRemoveItem.UseVisualStyleBackColor = false;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // picBoxMenu
            // 
            this.picBoxMenu.BackColor = System.Drawing.Color.Transparent;
            this.picBoxMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxMenu.Location = new System.Drawing.Point(575, 313);
            this.picBoxMenu.Name = "picBoxMenu";
            this.picBoxMenu.Size = new System.Drawing.Size(208, 193);
            this.picBoxMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxMenu.TabIndex = 41;
            this.picBoxMenu.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(820, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 23);
            this.label3.TabIndex = 39;
            this.label3.Text = "Qty";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPlaceOrder.Enabled = false;
            this.btnPlaceOrder.FlatAppearance.BorderSize = 0;
            this.btnPlaceOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaceOrder.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrder.ForeColor = System.Drawing.Color.White;
            this.btnPlaceOrder.Location = new System.Drawing.Point(575, 721);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(190, 41);
            this.btnPlaceOrder.TabIndex = 38;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = false;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.Enabled = false;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(824, 477);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 29);
            this.btnAdd.TabIndex = 43;
            this.btnAdd.Text = "Add Item";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // edtItemQty
            // 
            this.edtItemQty.Location = new System.Drawing.Point(930, 390);
            this.edtItemQty.Name = "edtItemQty";
            this.edtItemQty.Size = new System.Drawing.Size(120, 20);
            this.edtItemQty.TabIndex = 44;
            this.edtItemQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edtItemQty.ValueChanged += new System.EventHandler(this.edtItemQty_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(820, 437);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 23);
            this.label1.TabIndex = 45;
            this.label1.Text = "Price";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(820, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 23);
            this.label2.TabIndex = 46;
            this.label2.Text = "Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblItemPrice
            // 
            this.lblItemPrice.AutoSize = true;
            this.lblItemPrice.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemPrice.Location = new System.Drawing.Point(926, 437);
            this.lblItemPrice.Name = "lblItemPrice";
            this.lblItemPrice.Size = new System.Drawing.Size(74, 23);
            this.lblItemPrice.TabIndex = 47;
            this.lblItemPrice.Text = "Item Price";
            this.lblItemPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.Location = new System.Drawing.Point(926, 341);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(81, 23);
            this.lblItemName.TabIndex = 48;
            this.lblItemName.Text = "Item Name";
            this.lblItemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menusDataGridView
            // 
            this.menusDataGridView.AllowUserToAddRows = false;
            this.menusDataGridView.AllowUserToDeleteRows = false;
            this.menusDataGridView.AutoGenerateColumns = false;
            this.menusDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.menusDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menusDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.menu_id,
            this.name,
            this.price,
            this.photo,
            this.img_name});
            this.menusDataGridView.DataSource = this.msmenuBindingSource;
            this.menusDataGridView.Location = new System.Drawing.Point(12, 313);
            this.menusDataGridView.Name = "menusDataGridView";
            this.menusDataGridView.ReadOnly = true;
            this.menusDataGridView.Size = new System.Drawing.Size(547, 193);
            this.menusDataGridView.TabIndex = 49;
            this.menusDataGridView.SelectionChanged += new System.EventHandler(this.menusDataGridView_SelectionChanged);
            // 
            // menu_id
            // 
            this.menu_id.DataPropertyName = "menu_id";
            this.menu_id.HeaderText = "menu_id";
            this.menu_id.Name = "menu_id";
            this.menu_id.ReadOnly = true;
            this.menu_id.Visible = false;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // photo
            // 
            this.photo.DataPropertyName = "photo";
            this.photo.HeaderText = "photo";
            this.photo.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.photo.Name = "photo";
            this.photo.ReadOnly = true;
            // 
            // img_name
            // 
            this.img_name.DataPropertyName = "img_name";
            this.img_name.HeaderText = "img_name";
            this.img_name.Name = "img_name";
            this.img_name.ReadOnly = true;
            this.img_name.Visible = false;
            // 
            // msmenuBindingSource
            // 
            this.msmenuBindingSource.DataSource = typeof(laithan_smk_restaurant.data.source.edm.msmenu);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(683, 684);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(82, 23);
            this.lblTotal.TabIndex = 51;
            this.lblTotal.Text = "Total Order";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(575, 684);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 23);
            this.label5.TabIndex = 50;
            this.label5.Text = "Total ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 23);
            this.label4.TabIndex = 52;
            this.label4.Text = "List Menu";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLoginEmployee
            // 
            this.btnLoginEmployee.BackColor = System.Drawing.Color.Transparent;
            this.btnLoginEmployee.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnLoginEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginEmployee.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginEmployee.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnLoginEmployee.Location = new System.Drawing.Point(952, 12);
            this.btnLoginEmployee.Name = "btnLoginEmployee";
            this.btnLoginEmployee.Size = new System.Drawing.Size(119, 29);
            this.btnLoginEmployee.TabIndex = 53;
            this.btnLoginEmployee.Text = "Login";
            this.btnLoginEmployee.UseVisualStyleBackColor = false;
            this.btnLoginEmployee.Click += new System.EventHandler(this.btnLoginEmployee_Click);
            // 
            // tempMenuDataGridView
            // 
            this.tempMenuDataGridView.AllowUserToAddRows = false;
            this.tempMenuDataGridView.AllowUserToDeleteRows = false;
            this.tempMenuDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tempMenuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tempMenuDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.menuId,
            this.menu_name,
            this.menu_price,
            this.qty,
            this.subtotal,
            this.dataGridViewImageColumn1});
            this.tempMenuDataGridView.Location = new System.Drawing.Point(12, 544);
            this.tempMenuDataGridView.Name = "tempMenuDataGridView";
            this.tempMenuDataGridView.ReadOnly = true;
            this.tempMenuDataGridView.Size = new System.Drawing.Size(547, 218);
            this.tempMenuDataGridView.TabIndex = 54;
            this.tempMenuDataGridView.SelectionChanged += new System.EventHandler(this.tempMenuDataGridView_SelectionChanged);
            // 
            // menuId
            // 
            this.menuId.HeaderText = "menuId";
            this.menuId.Name = "menuId";
            this.menuId.ReadOnly = true;
            // 
            // menu_name
            // 
            this.menu_name.HeaderText = "name";
            this.menu_name.Name = "menu_name";
            this.menu_name.ReadOnly = true;
            // 
            // menu_price
            // 
            this.menu_price.HeaderText = "price";
            this.menu_price.Name = "menu_price";
            this.menu_price.ReadOnly = true;
            // 
            // qty
            // 
            this.qty.HeaderText = "qty";
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "subtotal";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "photo";
            this.dataGridViewImageColumn1.HeaderText = "photo";
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 518);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 23);
            this.label6.TabIndex = 55;
            this.label6.Text = "Current Item";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // membersDataGridView
            // 
            this.membersDataGridView.AllowDrop = true;
            this.membersDataGridView.AllowUserToAddRows = false;
            this.membersDataGridView.AllowUserToDeleteRows = false;
            this.membersDataGridView.AllowUserToOrderColumns = true;
            this.membersDataGridView.AllowUserToResizeColumns = false;
            this.membersDataGridView.AllowUserToResizeRows = false;
            this.membersDataGridView.AutoGenerateColumns = false;
            this.membersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.membersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.membersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.memberidDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.membersDataGridView.DataSource = this.msmemberBindingSource;
            this.membersDataGridView.Location = new System.Drawing.Point(12, 96);
            this.membersDataGridView.Name = "membersDataGridView";
            this.membersDataGridView.Size = new System.Drawing.Size(378, 172);
            this.membersDataGridView.TabIndex = 56;
            this.membersDataGridView.SelectionChanged += new System.EventHandler(this.membersDataGridView_SelectionChanged);
            // 
            // memberidDataGridViewTextBoxColumn
            // 
            this.memberidDataGridViewTextBoxColumn.DataPropertyName = "member_id";
            this.memberidDataGridViewTextBoxColumn.HeaderText = "member_id";
            this.memberidDataGridViewTextBoxColumn.Name = "memberidDataGridViewTextBoxColumn";
            this.memberidDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // msmemberBindingSource
            // 
            this.msmemberBindingSource.DataSource = typeof(laithan_smk_restaurant.data.source.edm.msmember);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 23);
            this.label7.TabIndex = 57;
            this.label7.Text = "List Member";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPelanggan
            // 
            this.lblPelanggan.AutoSize = true;
            this.lblPelanggan.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPelanggan.Location = new System.Drawing.Point(418, 96);
            this.lblPelanggan.Name = "lblPelanggan";
            this.lblPelanggan.Size = new System.Drawing.Size(81, 37);
            this.lblPelanggan.TabIndex = 58;
            this.lblPelanggan.Text = "Name";
            this.lblPelanggan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(4, 12);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(247, 48);
            this.lblWelcome.TabIndex = 59;
            this.lblWelcome.Text = "Place Order Here";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 783);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblPelanggan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.membersDataGridView);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tempMenuDataGridView);
            this.Controls.Add(this.btnLoginEmployee);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.menusDataGridView);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.lblItemPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edtItemQty);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.picBoxMenu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPlaceOrder);
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Form";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtItemQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menusDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmenuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempMenuDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmemberBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.PictureBox picBoxMenu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown edtItemQty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblItemPrice;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.DataGridView menusDataGridView;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLoginEmployee;
        private System.Windows.Forms.BindingSource msmenuBindingSource;
        private System.Windows.Forms.DataGridView tempMenuDataGridView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView membersDataGridView;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource msmemberBindingSource;
        private System.Windows.Forms.Label lblPelanggan;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuId;
        private System.Windows.Forms.DataGridViewTextBoxColumn menu_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn menu_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn menu_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewImageColumn photo;
        private System.Windows.Forms.DataGridViewTextBoxColumn img_name;
    }
}