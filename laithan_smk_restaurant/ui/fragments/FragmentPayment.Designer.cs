
namespace laithan_smk_restaurant.ui.fragments
{
    partial class FragmentPayment
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
            this.edtMetodeBayar = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.detailOrderDataGridView = new System.Windows.Forms.DataGridView();
            this.detail_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msmenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailorderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.headerOrderDataGridView = new System.Windows.Forms.DataGridView();
            this.orderidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewOrderHeaderorderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.edtPayment = new System.Windows.Forms.TextBox();
            this.lblBayar = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblKembalian = new System.Windows.Forms.Label();
            this.btnToLaporan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.detailOrderDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailorderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerOrderDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewOrderHeaderorderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(3, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(141, 48);
            this.lblWelcome.TabIndex = 5;
            this.lblWelcome.Text = "Payment";
            // 
            // edtMetodeBayar
            // 
            this.edtMetodeBayar.FormattingEnabled = true;
            this.edtMetodeBayar.Items.AddRange(new object[] {
            "cash",
            "bank"});
            this.edtMetodeBayar.Location = new System.Drawing.Point(298, 328);
            this.edtMetodeBayar.Name = "edtMetodeBayar";
            this.edtMetodeBayar.Size = new System.Drawing.Size(231, 21);
            this.edtMetodeBayar.TabIndex = 48;
            this.edtMetodeBayar.TabStop = false;
            this.edtMetodeBayar.SelectedIndexChanged += new System.EventHandler(this.edtMetodeBayar_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(294, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 47;
            this.label5.Text = "Metode Bayar";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(298, 475);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(175, 41);
            this.btnPay.TabIndex = 46;
            this.btnPay.Text = "Bayar";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(291, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 37);
            this.label2.TabIndex = 45;
            this.label2.Text = "Detail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 37);
            this.label1.TabIndex = 44;
            this.label1.Text = "Order ID";
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
            this.menu,
            this.qty,
            this.price,
            this.msmenu});
            this.detailOrderDataGridView.DataSource = this.detailorderBindingSource;
            this.detailOrderDataGridView.Location = new System.Drawing.Point(298, 84);
            this.detailOrderDataGridView.Name = "detailOrderDataGridView";
            this.detailOrderDataGridView.ReadOnly = true;
            this.detailOrderDataGridView.Size = new System.Drawing.Size(562, 196);
            this.detailOrderDataGridView.TabIndex = 43;
            // 
            // detail_id
            // 
            this.detail_id.DataPropertyName = "detail_id";
            this.detail_id.HeaderText = "detail_id";
            this.detail_id.Name = "detail_id";
            this.detail_id.ReadOnly = true;
            this.detail_id.Visible = false;
            // 
            // menu
            // 
            this.menu.HeaderText = "menu";
            this.menu.Name = "menu";
            this.menu.ReadOnly = true;
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
            this.price.HeaderText = "price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // msmenu
            // 
            this.msmenu.DataPropertyName = "msmenu";
            this.msmenu.HeaderText = "msmenu";
            this.msmenu.Name = "msmenu";
            this.msmenu.ReadOnly = true;
            this.msmenu.Visible = false;
            // 
            // detailorderBindingSource
            // 
            this.detailorderBindingSource.DataSource = typeof(laithan_smk_restaurant.data.source.edm.detailorder);
            // 
            // headerOrderDataGridView
            // 
            this.headerOrderDataGridView.AllowUserToAddRows = false;
            this.headerOrderDataGridView.AllowUserToDeleteRows = false;
            this.headerOrderDataGridView.AutoGenerateColumns = false;
            this.headerOrderDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.headerOrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.headerOrderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderidDataGridViewTextBoxColumn1});
            this.headerOrderDataGridView.DataSource = this.viewOrderHeaderorderBindingSource;
            this.headerOrderDataGridView.Location = new System.Drawing.Point(11, 84);
            this.headerOrderDataGridView.Name = "headerOrderDataGridView";
            this.headerOrderDataGridView.ReadOnly = true;
            this.headerOrderDataGridView.Size = new System.Drawing.Size(265, 550);
            this.headerOrderDataGridView.TabIndex = 42;
            this.headerOrderDataGridView.SelectionChanged += new System.EventHandler(this.headerOrderDataGridView_SelectionChanged);
            // 
            // orderidDataGridViewTextBoxColumn1
            // 
            this.orderidDataGridViewTextBoxColumn1.DataPropertyName = "order_id";
            this.orderidDataGridViewTextBoxColumn1.HeaderText = "order_id";
            this.orderidDataGridViewTextBoxColumn1.Name = "orderidDataGridViewTextBoxColumn1";
            this.orderidDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // viewOrderHeaderorderBindingSource
            // 
            this.viewOrderHeaderorderBindingSource.DataSource = typeof(laithan_smk_restaurant.data.source.edm.headerorder);
            // 
            // edtPayment
            // 
            this.edtPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtPayment.Location = new System.Drawing.Point(298, 403);
            this.edtPayment.Name = "edtPayment";
            this.edtPayment.Size = new System.Drawing.Size(231, 24);
            this.edtPayment.TabIndex = 49;
            this.edtPayment.TextChanged += new System.EventHandler(this.edtPayment_TextChanged);
            // 
            // lblBayar
            // 
            this.lblBayar.AutoSize = true;
            this.lblBayar.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBayar.Location = new System.Drawing.Point(294, 377);
            this.lblBayar.Name = "lblBayar";
            this.lblBayar.Size = new System.Drawing.Size(42, 23);
            this.lblBayar.TabIndex = 50;
            this.lblBayar.Text = "Bank";
            this.lblBayar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(818, 283);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(42, 23);
            this.lblTotal.TabIndex = 51;
            this.lblTotal.Text = "Total";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(636, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 23);
            this.label3.TabIndex = 52;
            this.label3.Text = "Total";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKembalian
            // 
            this.lblKembalian.AutoSize = true;
            this.lblKembalian.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKembalian.Location = new System.Drawing.Point(636, 392);
            this.lblKembalian.Name = "lblKembalian";
            this.lblKembalian.Size = new System.Drawing.Size(80, 23);
            this.lblKembalian.TabIndex = 53;
            this.lblKembalian.Text = "Kembalian";
            this.lblKembalian.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblKembalian.Visible = false;
            // 
            // btnToLaporan
            // 
            this.btnToLaporan.BackColor = System.Drawing.Color.Transparent;
            this.btnToLaporan.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnToLaporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToLaporan.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToLaporan.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnToLaporan.Location = new System.Drawing.Point(903, 3);
            this.btnToLaporan.Name = "btnToLaporan";
            this.btnToLaporan.Size = new System.Drawing.Size(130, 31);
            this.btnToLaporan.TabIndex = 54;
            this.btnToLaporan.Text = "Report";
            this.btnToLaporan.UseVisualStyleBackColor = false;
            this.btnToLaporan.Click += new System.EventHandler(this.btnToLaporan_Click);
            // 
            // FragmentPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnToLaporan);
            this.Controls.Add(this.lblKembalian);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblBayar);
            this.Controls.Add(this.edtPayment);
            this.Controls.Add(this.edtMetodeBayar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.detailOrderDataGridView);
            this.Controls.Add(this.headerOrderDataGridView);
            this.Controls.Add(this.lblWelcome);
            this.Name = "FragmentPayment";
            this.Size = new System.Drawing.Size(1036, 719);
            this.Load += new System.EventHandler(this.FragmentPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.detailOrderDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailorderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerOrderDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewOrderHeaderorderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.ComboBox edtMetodeBayar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView detailOrderDataGridView;
        private System.Windows.Forms.DataGridView headerOrderDataGridView;
        private System.Windows.Forms.TextBox edtPayment;
        private System.Windows.Forms.Label lblBayar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource detailorderBindingSource;
        private System.Windows.Forms.BindingSource viewOrderHeaderorderBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label lblKembalian;
        private System.Windows.Forms.DataGridViewTextBoxColumn detail_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn menu;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn msmenu;
        private System.Windows.Forms.Button btnToLaporan;
    }
}
