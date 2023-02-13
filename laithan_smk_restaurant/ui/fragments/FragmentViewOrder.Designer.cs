
namespace laithan_smk_restaurant.ui.pages
{
    partial class FragmentViewOrder
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
            this.headerOrderDataGridView = new System.Windows.Forms.DataGridView();
            this.detailOrderDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edtOrderStatus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailorderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.order_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewOrderHeaderorderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detail_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menu_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msmenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.headerOrderDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailOrderDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailorderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewOrderHeaderorderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(3, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(241, 37);
            this.lblWelcome.TabIndex = 4;
            this.lblWelcome.Text = "View Order Fragment";
            // 
            // headerOrderDataGridView
            // 
            this.headerOrderDataGridView.AllowUserToAddRows = false;
            this.headerOrderDataGridView.AllowUserToDeleteRows = false;
            this.headerOrderDataGridView.AutoGenerateColumns = false;
            this.headerOrderDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.headerOrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.headerOrderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.order_id});
            this.headerOrderDataGridView.DataSource = this.viewOrderHeaderorderBindingSource;
            this.headerOrderDataGridView.Location = new System.Drawing.Point(10, 105);
            this.headerOrderDataGridView.Name = "headerOrderDataGridView";
            this.headerOrderDataGridView.ReadOnly = true;
            this.headerOrderDataGridView.Size = new System.Drawing.Size(265, 550);
            this.headerOrderDataGridView.TabIndex = 35;
            this.headerOrderDataGridView.SelectionChanged += new System.EventHandler(this.headerOrderDataGridView_SelectionChanged);
            // 
            // detailOrderDataGridView
            // 
            this.detailOrderDataGridView.AllowUserToAddRows = false;
            this.detailOrderDataGridView.AllowUserToDeleteRows = false;
            this.detailOrderDataGridView.AutoGenerateColumns = false;
            this.detailOrderDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.detailOrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detailOrderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.detail_id,
            this.menu_name,
            this.qty,
            this.price,
            this.status,
            this.msmenu});
            this.detailOrderDataGridView.DataSource = this.detailorderBindingSource;
            this.detailOrderDataGridView.Location = new System.Drawing.Point(297, 105);
            this.detailOrderDataGridView.Name = "detailOrderDataGridView";
            this.detailOrderDataGridView.ReadOnly = true;
            this.detailOrderDataGridView.Size = new System.Drawing.Size(325, 550);
            this.detailOrderDataGridView.TabIndex = 36;
            this.detailOrderDataGridView.SelectionChanged += new System.EventHandler(this.detailOrderDataGridView_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 37);
            this.label1.TabIndex = 37;
            this.label1.Text = "Order ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(290, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 37);
            this.label2.TabIndex = 38;
            this.label2.Text = "Detail";
            // 
            // edtOrderStatus
            // 
            this.edtOrderStatus.FormattingEnabled = true;
            this.edtOrderStatus.Items.AddRange(new object[] {
            "pending",
            "cooking",
            "delivered"});
            this.edtOrderStatus.Location = new System.Drawing.Point(628, 201);
            this.edtOrderStatus.Name = "edtOrderStatus";
            this.edtOrderStatus.Size = new System.Drawing.Size(231, 21);
            this.edtOrderStatus.TabIndex = 41;
            this.edtOrderStatus.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(624, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 23);
            this.label5.TabIndex = 40;
            this.label5.Text = "Status Action";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(684, 228);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(175, 41);
            this.btnUpdate.TabIndex = 39;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "msmenu";
            this.dataGridViewTextBoxColumn1.HeaderText = "msmenu";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // detailorderBindingSource
            // 
            this.detailorderBindingSource.DataSource = typeof(laithan_smk_restaurant.data.source.edm.detailorder);
            // 
            // order_id
            // 
            this.order_id.DataPropertyName = "order_id";
            this.order_id.HeaderText = "order_id";
            this.order_id.Name = "order_id";
            this.order_id.ReadOnly = true;
            // 
            // viewOrderHeaderorderBindingSource
            // 
            this.viewOrderHeaderorderBindingSource.DataSource = typeof(laithan_smk_restaurant.data.source.edm.headerorder);
            // 
            // detail_id
            // 
            this.detail_id.DataPropertyName = "detail_id";
            this.detail_id.HeaderText = "detail_id";
            this.detail_id.Name = "detail_id";
            this.detail_id.ReadOnly = true;
            this.detail_id.Visible = false;
            // 
            // menu_name
            // 
            this.menu_name.HeaderText = "menu";
            this.menu_name.Name = "menu_name";
            this.menu_name.ReadOnly = true;
            // 
            // qty
            // 
            this.qty.DataPropertyName = "qty";
            this.qty.HeaderText = "qty";
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // msmenu
            // 
            this.msmenu.DataPropertyName = "msmenu";
            this.msmenu.HeaderText = "msmenu";
            this.msmenu.Name = "msmenu";
            this.msmenu.ReadOnly = true;
            this.msmenu.Visible = false;
            // 
            // FragmentViewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.edtOrderStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.detailOrderDataGridView);
            this.Controls.Add(this.headerOrderDataGridView);
            this.Controls.Add(this.lblWelcome);
            this.Name = "FragmentViewOrder";
            this.Size = new System.Drawing.Size(1036, 719);
            this.Load += new System.EventHandler(this.FragmentViewOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.headerOrderDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailOrderDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailorderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewOrderHeaderorderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.DataGridView headerOrderDataGridView;
        private System.Windows.Forms.DataGridView detailOrderDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox edtOrderStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_id;
        private System.Windows.Forms.BindingSource viewOrderHeaderorderBindingSource;
        private System.Windows.Forms.BindingSource detailorderBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn detail_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn menu_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn msmenu;
    }
}
