
namespace latihangrandhotellagi
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
            this.btnExit = new System.Windows.Forms.Button();
            this.frontDeskNavigationBtnPanelContainer = new System.Windows.Forms.Panel();
            this.mainFragmentContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNavReservation = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnNavCheckIn = new System.Windows.Forms.Button();
            this.btnNavReqAddItem = new System.Windows.Forms.Button();
            this.btnNavCheckout = new System.Windows.Forms.Button();
            this.btnNavMasterRoomType = new System.Windows.Forms.Button();
            this.btnNavMasrrterItem = new System.Windows.Forms.Button();
            this.btnNavMasterRoom = new System.Windows.Forms.Button();
            this.housekeeperSvNavigationBtnPanelContainer = new System.Windows.Forms.Panel();
            this.btnNavAddHousekeepingSchedule = new System.Windows.Forms.Button();
            this.housekeeperNavigationBtnPanelContainer = new System.Windows.Forms.Panel();
            this.btnNavCleaningRoom = new System.Windows.Forms.Button();
            this.adminNavigationBtnPanelContainer = new System.Windows.Forms.Panel();
            this.btnNavMasterEmployee = new System.Windows.Forms.Button();
            this.btnAdminMode = new System.Windows.Forms.Button();
            this.btnFrontDesk = new System.Windows.Forms.Button();
            this.btnHousekeeper = new System.Windows.Forms.Button();
            this.btnHousekeeperSv = new System.Windows.Forms.Button();
            this.reservationFragment = new latihangrandhotellagi.ui.pages.ReservationFragment();
            this.masterEmployeeFragment = new latihangrandhotellagi.ui.pages.MasterEmployeeFragment();
            this.cleaningRoomFragment = new latihangrandhotellagi.ui.pages.CleaningRoomFragment();
            this.checkinFragment = new latihangrandhotellagi.ui.pages.CheckinFragment();
            this.addHousekeepingScheduleFragment = new latihangrandhotellagi.ui.pages.AddHousekeepingSchedule();
            this.requestAdditionalItemFragment = new latihangrandhotellagi.ui.pages.frontdesk.RequestAdditionalItemFragment();
            this.checkOutFragment = new latihangrandhotellagi.ui.pages.frontdesk.CheckOutFragment();
            this.masterRoomTypeFragment = new latihangrandhotellagi.ui.pages.frontdesk.MasterRoomTypeFragment();
            this.masterRoomFragment = new latihangrandhotellagi.ui.pages.frontdesk.MasterRoomFragment();
            this.masterItemFragment = new latihangrandhotellagi.ui.pages.frontdesk.MasterItem();
            this.frontDeskNavigationBtnPanelContainer.SuspendLayout();
            this.mainFragmentContainer.SuspendLayout();
            this.housekeeperSvNavigationBtnPanelContainer.SuspendLayout();
            this.housekeeperNavigationBtnPanelContainer.SuspendLayout();
            this.adminNavigationBtnPanelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Maroon;
            this.btnExit.Location = new System.Drawing.Point(1231, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(44, 35);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frontDeskNavigationBtnPanelContainer
            // 
            this.frontDeskNavigationBtnPanelContainer.BackColor = System.Drawing.Color.DodgerBlue;
            this.frontDeskNavigationBtnPanelContainer.Controls.Add(this.btnNavMasrrterItem);
            this.frontDeskNavigationBtnPanelContainer.Controls.Add(this.btnNavMasterRoom);
            this.frontDeskNavigationBtnPanelContainer.Controls.Add(this.btnNavMasterRoomType);
            this.frontDeskNavigationBtnPanelContainer.Controls.Add(this.btnNavCheckout);
            this.frontDeskNavigationBtnPanelContainer.Controls.Add(this.btnNavReqAddItem);
            this.frontDeskNavigationBtnPanelContainer.Controls.Add(this.btnNavCheckIn);
            this.frontDeskNavigationBtnPanelContainer.Controls.Add(this.btnNavReservation);
            this.frontDeskNavigationBtnPanelContainer.Location = new System.Drawing.Point(1, 43);
            this.frontDeskNavigationBtnPanelContainer.Name = "frontDeskNavigationBtnPanelContainer";
            this.frontDeskNavigationBtnPanelContainer.Size = new System.Drawing.Size(210, 728);
            this.frontDeskNavigationBtnPanelContainer.TabIndex = 2;
            // 
            // mainFragmentContainer
            // 
            this.mainFragmentContainer.Controls.Add(this.masterItemFragment);
            this.mainFragmentContainer.Controls.Add(this.masterRoomTypeFragment);
            this.mainFragmentContainer.Controls.Add(this.checkOutFragment);
            this.mainFragmentContainer.Controls.Add(this.requestAdditionalItemFragment);
            this.mainFragmentContainer.Controls.Add(this.reservationFragment);
            this.mainFragmentContainer.Controls.Add(this.masterEmployeeFragment);
            this.mainFragmentContainer.Controls.Add(this.cleaningRoomFragment);
            this.mainFragmentContainer.Controls.Add(this.checkinFragment);
            this.mainFragmentContainer.Controls.Add(this.addHousekeepingScheduleFragment);
            this.mainFragmentContainer.Controls.Add(this.masterRoomFragment);
            this.mainFragmentContainer.Location = new System.Drawing.Point(217, 43);
            this.mainFragmentContainer.Name = "mainFragmentContainer";
            this.mainFragmentContainer.Size = new System.Drawing.Size(1049, 728);
            this.mainFragmentContainer.TabIndex = 3;
            // 
            // btnNavReservation
            // 
            this.btnNavReservation.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNavReservation.FlatAppearance.BorderSize = 0;
            this.btnNavReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavReservation.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavReservation.ForeColor = System.Drawing.Color.White;
            this.btnNavReservation.Location = new System.Drawing.Point(3, 23);
            this.btnNavReservation.Name = "btnNavReservation";
            this.btnNavReservation.Size = new System.Drawing.Size(204, 49);
            this.btnNavReservation.TabIndex = 7;
            this.btnNavReservation.Text = "Reservation";
            this.btnNavReservation.UseVisualStyleBackColor = false;
            this.btnNavReservation.Click += new System.EventHandler(this.btnNavReservation_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(10, 5);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(153, 28);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Grand Hotel Login";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNavCheckIn
            // 
            this.btnNavCheckIn.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNavCheckIn.FlatAppearance.BorderSize = 0;
            this.btnNavCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavCheckIn.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavCheckIn.ForeColor = System.Drawing.Color.White;
            this.btnNavCheckIn.Location = new System.Drawing.Point(3, 78);
            this.btnNavCheckIn.Name = "btnNavCheckIn";
            this.btnNavCheckIn.Size = new System.Drawing.Size(204, 49);
            this.btnNavCheckIn.TabIndex = 8;
            this.btnNavCheckIn.Text = "Check in";
            this.btnNavCheckIn.UseVisualStyleBackColor = false;
            this.btnNavCheckIn.Click += new System.EventHandler(this.btnNavCheckIn_Click);
            // 
            // btnNavReqAddItem
            // 
            this.btnNavReqAddItem.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNavReqAddItem.FlatAppearance.BorderSize = 0;
            this.btnNavReqAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavReqAddItem.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavReqAddItem.ForeColor = System.Drawing.Color.White;
            this.btnNavReqAddItem.Location = new System.Drawing.Point(3, 133);
            this.btnNavReqAddItem.Name = "btnNavReqAddItem";
            this.btnNavReqAddItem.Size = new System.Drawing.Size(204, 49);
            this.btnNavReqAddItem.TabIndex = 9;
            this.btnNavReqAddItem.Text = "Request Additional Item(s)";
            this.btnNavReqAddItem.UseVisualStyleBackColor = false;
            this.btnNavReqAddItem.Click += new System.EventHandler(this.btnNavReqAddItem_Click);
            // 
            // btnNavCheckout
            // 
            this.btnNavCheckout.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNavCheckout.FlatAppearance.BorderSize = 0;
            this.btnNavCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavCheckout.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavCheckout.ForeColor = System.Drawing.Color.White;
            this.btnNavCheckout.Location = new System.Drawing.Point(3, 188);
            this.btnNavCheckout.Name = "btnNavCheckout";
            this.btnNavCheckout.Size = new System.Drawing.Size(204, 49);
            this.btnNavCheckout.TabIndex = 10;
            this.btnNavCheckout.Text = "Checkout";
            this.btnNavCheckout.UseVisualStyleBackColor = false;
            this.btnNavCheckout.Click += new System.EventHandler(this.btnNavCheckout_Click);
            // 
            // btnNavMasterRoomType
            // 
            this.btnNavMasterRoomType.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNavMasterRoomType.FlatAppearance.BorderSize = 0;
            this.btnNavMasterRoomType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavMasterRoomType.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavMasterRoomType.ForeColor = System.Drawing.Color.White;
            this.btnNavMasterRoomType.Location = new System.Drawing.Point(3, 243);
            this.btnNavMasterRoomType.Name = "btnNavMasterRoomType";
            this.btnNavMasterRoomType.Size = new System.Drawing.Size(204, 49);
            this.btnNavMasterRoomType.TabIndex = 11;
            this.btnNavMasterRoomType.Text = "Master Room Type";
            this.btnNavMasterRoomType.UseVisualStyleBackColor = false;
            this.btnNavMasterRoomType.Click += new System.EventHandler(this.btnNavMasterRoomType_Click);
            // 
            // btnNavMasrrterItem
            // 
            this.btnNavMasrrterItem.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNavMasrrterItem.FlatAppearance.BorderSize = 0;
            this.btnNavMasrrterItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavMasrrterItem.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavMasrrterItem.ForeColor = System.Drawing.Color.White;
            this.btnNavMasrrterItem.Location = new System.Drawing.Point(3, 353);
            this.btnNavMasrrterItem.Name = "btnNavMasrrterItem";
            this.btnNavMasrrterItem.Size = new System.Drawing.Size(204, 49);
            this.btnNavMasrrterItem.TabIndex = 13;
            this.btnNavMasrrterItem.Text = "Master Item";
            this.btnNavMasrrterItem.UseVisualStyleBackColor = false;
            this.btnNavMasrrterItem.Click += new System.EventHandler(this.btnNavMasrrterItem_Click);
            // 
            // btnNavMasterRoom
            // 
            this.btnNavMasterRoom.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNavMasterRoom.FlatAppearance.BorderSize = 0;
            this.btnNavMasterRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavMasterRoom.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavMasterRoom.ForeColor = System.Drawing.Color.White;
            this.btnNavMasterRoom.Location = new System.Drawing.Point(3, 298);
            this.btnNavMasterRoom.Name = "btnNavMasterRoom";
            this.btnNavMasterRoom.Size = new System.Drawing.Size(204, 49);
            this.btnNavMasterRoom.TabIndex = 12;
            this.btnNavMasterRoom.Text = "Master Room";
            this.btnNavMasterRoom.UseVisualStyleBackColor = false;
            this.btnNavMasterRoom.Click += new System.EventHandler(this.btnNavMasterRoom_Click);
            // 
            // housekeeperSvNavigationBtnPanelContainer
            // 
            this.housekeeperSvNavigationBtnPanelContainer.BackColor = System.Drawing.Color.DodgerBlue;
            this.housekeeperSvNavigationBtnPanelContainer.Controls.Add(this.btnNavAddHousekeepingSchedule);
            this.housekeeperSvNavigationBtnPanelContainer.Location = new System.Drawing.Point(1, 43);
            this.housekeeperSvNavigationBtnPanelContainer.Name = "housekeeperSvNavigationBtnPanelContainer";
            this.housekeeperSvNavigationBtnPanelContainer.Size = new System.Drawing.Size(210, 728);
            this.housekeeperSvNavigationBtnPanelContainer.TabIndex = 14;
            // 
            // btnNavAddHousekeepingSchedule
            // 
            this.btnNavAddHousekeepingSchedule.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNavAddHousekeepingSchedule.FlatAppearance.BorderSize = 0;
            this.btnNavAddHousekeepingSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavAddHousekeepingSchedule.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavAddHousekeepingSchedule.ForeColor = System.Drawing.Color.White;
            this.btnNavAddHousekeepingSchedule.Location = new System.Drawing.Point(3, 23);
            this.btnNavAddHousekeepingSchedule.Name = "btnNavAddHousekeepingSchedule";
            this.btnNavAddHousekeepingSchedule.Size = new System.Drawing.Size(204, 68);
            this.btnNavAddHousekeepingSchedule.TabIndex = 7;
            this.btnNavAddHousekeepingSchedule.Text = "Add Housekeeping Schedule";
            this.btnNavAddHousekeepingSchedule.UseVisualStyleBackColor = false;
            this.btnNavAddHousekeepingSchedule.Click += new System.EventHandler(this.btnNavAddHousekeepingSchedule_Click);
            // 
            // housekeeperNavigationBtnPanelContainer
            // 
            this.housekeeperNavigationBtnPanelContainer.BackColor = System.Drawing.Color.DodgerBlue;
            this.housekeeperNavigationBtnPanelContainer.Controls.Add(this.btnNavCleaningRoom);
            this.housekeeperNavigationBtnPanelContainer.Location = new System.Drawing.Point(1, 43);
            this.housekeeperNavigationBtnPanelContainer.Name = "housekeeperNavigationBtnPanelContainer";
            this.housekeeperNavigationBtnPanelContainer.Size = new System.Drawing.Size(210, 728);
            this.housekeeperNavigationBtnPanelContainer.TabIndex = 15;
            // 
            // btnNavCleaningRoom
            // 
            this.btnNavCleaningRoom.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNavCleaningRoom.FlatAppearance.BorderSize = 0;
            this.btnNavCleaningRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavCleaningRoom.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavCleaningRoom.ForeColor = System.Drawing.Color.White;
            this.btnNavCleaningRoom.Location = new System.Drawing.Point(3, 23);
            this.btnNavCleaningRoom.Name = "btnNavCleaningRoom";
            this.btnNavCleaningRoom.Size = new System.Drawing.Size(204, 68);
            this.btnNavCleaningRoom.TabIndex = 7;
            this.btnNavCleaningRoom.Text = "Cleaning Rom";
            this.btnNavCleaningRoom.UseVisualStyleBackColor = false;
            this.btnNavCleaningRoom.Click += new System.EventHandler(this.btnNavCleaningRoom_Click);
            // 
            // adminNavigationBtnPanelContainer
            // 
            this.adminNavigationBtnPanelContainer.BackColor = System.Drawing.Color.DodgerBlue;
            this.adminNavigationBtnPanelContainer.Controls.Add(this.btnNavMasterEmployee);
            this.adminNavigationBtnPanelContainer.Location = new System.Drawing.Point(1, 43);
            this.adminNavigationBtnPanelContainer.Name = "adminNavigationBtnPanelContainer";
            this.adminNavigationBtnPanelContainer.Size = new System.Drawing.Size(210, 728);
            this.adminNavigationBtnPanelContainer.TabIndex = 16;
            // 
            // btnNavMasterEmployee
            // 
            this.btnNavMasterEmployee.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNavMasterEmployee.FlatAppearance.BorderSize = 0;
            this.btnNavMasterEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavMasterEmployee.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavMasterEmployee.ForeColor = System.Drawing.Color.White;
            this.btnNavMasterEmployee.Location = new System.Drawing.Point(3, 23);
            this.btnNavMasterEmployee.Name = "btnNavMasterEmployee";
            this.btnNavMasterEmployee.Size = new System.Drawing.Size(204, 68);
            this.btnNavMasterEmployee.TabIndex = 7;
            this.btnNavMasterEmployee.Text = "Master Employee";
            this.btnNavMasterEmployee.UseVisualStyleBackColor = false;
            this.btnNavMasterEmployee.Click += new System.EventHandler(this.btnNavMasterEmployee_Click);
            // 
            // btnAdminMode
            // 
            this.btnAdminMode.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdminMode.FlatAppearance.BorderSize = 0;
            this.btnAdminMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminMode.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminMode.ForeColor = System.Drawing.Color.White;
            this.btnAdminMode.Location = new System.Drawing.Point(395, 6);
            this.btnAdminMode.Name = "btnAdminMode";
            this.btnAdminMode.Size = new System.Drawing.Size(117, 31);
            this.btnAdminMode.TabIndex = 17;
            this.btnAdminMode.Text = "admin";
            this.btnAdminMode.UseVisualStyleBackColor = false;
            this.btnAdminMode.Click += new System.EventHandler(this.btnAdminMode_Click);
            // 
            // btnFrontDesk
            // 
            this.btnFrontDesk.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnFrontDesk.FlatAppearance.BorderSize = 0;
            this.btnFrontDesk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFrontDesk.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrontDesk.ForeColor = System.Drawing.Color.White;
            this.btnFrontDesk.Location = new System.Drawing.Point(518, 6);
            this.btnFrontDesk.Name = "btnFrontDesk";
            this.btnFrontDesk.Size = new System.Drawing.Size(117, 31);
            this.btnFrontDesk.TabIndex = 18;
            this.btnFrontDesk.Text = "FrontDesk";
            this.btnFrontDesk.UseVisualStyleBackColor = false;
            this.btnFrontDesk.Click += new System.EventHandler(this.btnFrontDesk_Click);
            // 
            // btnHousekeeper
            // 
            this.btnHousekeeper.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnHousekeeper.FlatAppearance.BorderSize = 0;
            this.btnHousekeeper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHousekeeper.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHousekeeper.ForeColor = System.Drawing.Color.White;
            this.btnHousekeeper.Location = new System.Drawing.Point(641, 6);
            this.btnHousekeeper.Name = "btnHousekeeper";
            this.btnHousekeeper.Size = new System.Drawing.Size(136, 31);
            this.btnHousekeeper.TabIndex = 19;
            this.btnHousekeeper.Text = "Housekeeper";
            this.btnHousekeeper.UseVisualStyleBackColor = false;
            this.btnHousekeeper.Click += new System.EventHandler(this.btnHousekeeper_Click);
            // 
            // btnHousekeeperSv
            // 
            this.btnHousekeeperSv.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnHousekeeperSv.FlatAppearance.BorderSize = 0;
            this.btnHousekeeperSv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHousekeeperSv.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHousekeeperSv.ForeColor = System.Drawing.Color.White;
            this.btnHousekeeperSv.Location = new System.Drawing.Point(783, 6);
            this.btnHousekeeperSv.Name = "btnHousekeeperSv";
            this.btnHousekeeperSv.Size = new System.Drawing.Size(167, 31);
            this.btnHousekeeperSv.TabIndex = 20;
            this.btnHousekeeperSv.Text = "Housekeeper SV";
            this.btnHousekeeperSv.UseVisualStyleBackColor = false;
            this.btnHousekeeperSv.Click += new System.EventHandler(this.btnHousekeeperSv_Click);
            // 
            // reservationFragment
            // 
            this.reservationFragment.Location = new System.Drawing.Point(3, 2939);
            this.reservationFragment.Name = "reservationFragment";
            this.reservationFragment.Size = new System.Drawing.Size(1049, 728);
            this.reservationFragment.TabIndex = 4;
            // 
            // masterEmployeeFragment
            // 
            this.masterEmployeeFragment.Location = new System.Drawing.Point(3, 3673);
            this.masterEmployeeFragment.Name = "masterEmployeeFragment";
            this.masterEmployeeFragment.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.masterEmployeeFragment.Size = new System.Drawing.Size(1049, 728);
            this.masterEmployeeFragment.TabIndex = 3;
            // 
            // cleaningRoomFragment
            // 
            this.cleaningRoomFragment.Location = new System.Drawing.Point(3, 4407);
            this.cleaningRoomFragment.Name = "cleaningRoomFragment";
            this.cleaningRoomFragment.Size = new System.Drawing.Size(1049, 728);
            this.cleaningRoomFragment.TabIndex = 2;
            // 
            // checkinFragment
            // 
            this.checkinFragment.Location = new System.Drawing.Point(3, 5141);
            this.checkinFragment.Name = "checkinFragment";
            this.checkinFragment.Size = new System.Drawing.Size(1049, 728);
            this.checkinFragment.TabIndex = 1;
            // 
            // addHousekeepingScheduleFragment
            // 
            this.addHousekeepingScheduleFragment.Location = new System.Drawing.Point(3, 5875);
            this.addHousekeepingScheduleFragment.Name = "addHousekeepingScheduleFragment";
            this.addHousekeepingScheduleFragment.Size = new System.Drawing.Size(1049, 728);
            this.addHousekeepingScheduleFragment.TabIndex = 0;
            // 
            // requestAdditionalItemFragment
            // 
            this.requestAdditionalItemFragment.Location = new System.Drawing.Point(3, 2205);
            this.requestAdditionalItemFragment.Name = "requestAdditionalItemFragment";
            this.requestAdditionalItemFragment.Size = new System.Drawing.Size(1049, 728);
            this.requestAdditionalItemFragment.TabIndex = 5;
            // 
            // checkOutFragment
            // 
            this.checkOutFragment.Location = new System.Drawing.Point(3, 1471);
            this.checkOutFragment.Name = "checkOutFragment";
            this.checkOutFragment.Size = new System.Drawing.Size(1049, 728);
            this.checkOutFragment.TabIndex = 6;
            // 
            // masterRoomTypeFragment
            // 
            this.masterRoomTypeFragment.Location = new System.Drawing.Point(3, 737);
            this.masterRoomTypeFragment.Name = "masterRoomTypeFragment";
            this.masterRoomTypeFragment.Size = new System.Drawing.Size(1049, 728);
            this.masterRoomTypeFragment.TabIndex = 7;
            // 
            // masterRoomFragment
            // 
            this.masterRoomFragment.Location = new System.Drawing.Point(3, 6609);
            this.masterRoomFragment.Name = "masterRoomFragment";
            this.masterRoomFragment.Size = new System.Drawing.Size(1049, 728);
            this.masterRoomFragment.TabIndex = 8;
            // 
            // masterItemFragment
            // 
            this.masterItemFragment.Location = new System.Drawing.Point(3, 3);
            this.masterItemFragment.Name = "masterItemFragment";
            this.masterItemFragment.Size = new System.Drawing.Size(1049, 728);
            this.masterItemFragment.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 783);
            this.Controls.Add(this.btnHousekeeperSv);
            this.Controls.Add(this.btnHousekeeper);
            this.Controls.Add(this.btnFrontDesk);
            this.Controls.Add(this.btnAdminMode);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.mainFragmentContainer);
            this.Controls.Add(this.frontDeskNavigationBtnPanelContainer);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.adminNavigationBtnPanelContainer);
            this.Controls.Add(this.housekeeperNavigationBtnPanelContainer);
            this.Controls.Add(this.housekeeperSvNavigationBtnPanelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.frontDeskNavigationBtnPanelContainer.ResumeLayout(false);
            this.mainFragmentContainer.ResumeLayout(false);
            this.housekeeperSvNavigationBtnPanelContainer.ResumeLayout(false);
            this.housekeeperNavigationBtnPanelContainer.ResumeLayout(false);
            this.adminNavigationBtnPanelContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel frontDeskNavigationBtnPanelContainer;
        private System.Windows.Forms.FlowLayoutPanel mainFragmentContainer;
        private System.Windows.Forms.Button btnNavReservation;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnNavCheckIn;
        private System.Windows.Forms.Button btnNavReqAddItem;
        private System.Windows.Forms.Button btnNavMasrrterItem;
        private System.Windows.Forms.Button btnNavMasterRoom;
        private System.Windows.Forms.Button btnNavMasterRoomType;
        private System.Windows.Forms.Button btnNavCheckout;
        private System.Windows.Forms.Panel housekeeperSvNavigationBtnPanelContainer;
        private System.Windows.Forms.Button btnNavAddHousekeepingSchedule;
        private System.Windows.Forms.Panel housekeeperNavigationBtnPanelContainer;
        private System.Windows.Forms.Button btnNavCleaningRoom;
        private System.Windows.Forms.Panel adminNavigationBtnPanelContainer;
        private System.Windows.Forms.Button btnNavMasterEmployee;
        private System.Windows.Forms.Button btnAdminMode;
        private System.Windows.Forms.Button btnFrontDesk;
        private System.Windows.Forms.Button btnHousekeeper;
        private System.Windows.Forms.Button btnHousekeeperSv;
        private ui.pages.AddHousekeepingSchedule addHousekeepingScheduleFragment;
        private ui.pages.CheckinFragment checkinFragment;
        private ui.pages.CleaningRoomFragment cleaningRoomFragment;
        private ui.pages.ReservationFragment reservationFragment;
        private ui.pages.MasterEmployeeFragment masterEmployeeFragment;
        private ui.pages.frontdesk.MasterItem masterItemFragment;
        private ui.pages.frontdesk.MasterRoomTypeFragment masterRoomTypeFragment;
        private ui.pages.frontdesk.CheckOutFragment checkOutFragment;
        private ui.pages.frontdesk.RequestAdditionalItemFragment requestAdditionalItemFragment;
        private ui.pages.frontdesk.MasterRoomFragment masterRoomFragment;
    }
}