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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        #region Navigation View Region
        private void hideAllNavPanel()
        {
            frontDeskNavigationBtnPanelContainer.Visible = false;
            adminNavigationBtnPanelContainer.Visible = false;
           housekeeperNavigationBtnPanelContainer.Visible = false;
           housekeeperSvNavigationBtnPanelContainer.Visible = false;
            
        }

        private void showNav(Panel navPanel)
        {
            hideAllNavPanel();
            navPanel.Visible = true;
        }

        private void hideAllFragment()
        {
            foreach (UserControl fragment in mainFragmentContainer.Controls)
            {
                fragment.Visible = false;
            }
        }

        private void showFragment(UserControl fragment)
        {
            hideAllFragment();
            fragment.Visible = true;
        }

        private void changeMode(string mode)
        {
            hideAllFragment();

            if (mode.Equals("frontdesk"))
            {
                showNav(frontDeskNavigationBtnPanelContainer);
            }else if (mode.Equals("admin"))
            {
                showNav(adminNavigationBtnPanelContainer);
            }
            else if (mode.Equals("housekeepersv"))
            {
                showNav(housekeeperSvNavigationBtnPanelContainer);
            }
            else if(mode.Equals("housekeeper"))
            {
                showNav(housekeeperNavigationBtnPanelContainer);

            }
            else
            {
                showNav(frontDeskNavigationBtnPanelContainer);
            }
        }

        #endregion
        private void MainForm_Load(object sender, EventArgs e)
        {
            hideAllNavPanel();
            hideAllFragment();

        }
        #region mode changer

        private void btnFrontDesk_Click(object sender, EventArgs e)
        {
            changeMode("frontdesk"); 
        }

        private void btnAdminMode_Click(object sender, EventArgs e)
        {
            changeMode("admin");

        }

        private void btnHousekeeper_Click(object sender, EventArgs e)
        {
            changeMode("housekeeper");

        }

        private void btnHousekeeperSv_Click(object sender, EventArgs e)
        {
            changeMode("housekeepersv");
        }
        #endregion

        #region navigationButton region

        //Front Desk Mode
        private void btnNavReservation_Click(object sender, EventArgs e)
        {
            showFragment(reservationFragment);
        }


        private void btnNavCheckIn_Click(object sender, EventArgs e)
        {
            showFragment(checkinFragment);
        }

        //Other Mode
        private void btnNavMasterEmployee_Click(object sender, EventArgs e)
        {
            showFragment(masterEmployeeFragment);
        }

        private void btnNavCleaningRoom_Click(object sender, EventArgs e)
        {
            showFragment(cleaningRoomFragment);
        }

        private void btnNavAddHousekeepingSchedule_Click(object sender, EventArgs e)
        {
            showFragment(addHousekeepingScheduleFragment);
        }
        private void btnNavReqAddItem_Click(object sender, EventArgs e)
        {
            showFragment(requestAdditionalItemFragment);
        }

        private void btnNavCheckout_Click(object sender, EventArgs e)
        {
            showFragment(checkOutFragment);
        }

        private void btnNavMasterRoomType_Click(object sender, EventArgs e)
        {
            showFragment(masterRoomTypeFragment);
        }

        private void btnNavMasterRoom_Click(object sender, EventArgs e)
        {
            showFragment(masterRoomFragment);
        }

        private void btnNavMasrrterItem_Click(object sender, EventArgs e)
        {
            showFragment(masterItemFragment);
        }


        #endregion


    }
}
