using laithan_smk_restaurant.data.repository;
using laithan_smk_restaurant.data.source.edm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laithan_smk_restaurant.ui.notifier
{
    public static class AdminNotifier
    {

        #region master member 

        public static List<msmember> listMember = new List<msmember>();
        internal static void getAllMemberData()
        {
            listMember = Repository.getAllMember();
        }
        public static void updateMember(msmember selectedMemberModel)
        {
            Repository.updateMember(selectedMemberModel);
        }

        public static void addMember(msmember selectedMemberModel)
        {

            Repository.addMember(selectedMemberModel);
        }



        public static void deleteMember(string memberID)
        {
            Repository.deleteMember(memberID);
        }
        #endregion
        #region master menu
        public static List<msmenu> listMenu = new List<msmenu>();

        public static void getAllMenuData()
        {
            listMenu = Repository.getAllMenu();
        }

   

        public static void updateMenu(msmenu selectedMenuModel)
        {
            Repository.updateMenu(selectedMenuModel);
        }

        public static void addMenu(msmenu selectedMenuModel)
        {

            Repository.addMenu(selectedMenuModel);
        }



        public static void deleteMenu(int menuId)
        {
            Repository.deleteMenu(menuId);
        }


        #endregion

        #region master employee 

        public static List<msemployee> listEmployee = new List<msemployee>();

        public static void getAllEmployeeData()
        {
            listEmployee = Repository.getAllEmployee();
        }

        public static void updateEmployee(msemployee selectedEmployeeModel)
        {
            Repository.updateEmployee(selectedEmployeeModel);
        }

        public static void addEmployee(msemployee employeeData)
        {
        
            Repository.addEmployee(employeeData);
        }

      

        public static void deleteEmployee(string employeeId)
        {
            Repository.deleteEmployee(employeeId);
        }
        #endregion
    }
}
