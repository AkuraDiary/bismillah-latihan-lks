using laithan_smk_restaurant.data.source.edm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laithan_smk_restaurant.data.repository
{
    public static class Repository
    {
        public static db_restaurantEntities dbContextEntities = new db_restaurantEntities();

        #region order region

        public static string getRandomChef()
        {
            List<msemployee> listChef = dbContextEntities.msemployees.Where(
                item => item.employee_id.StartsWith("CHF")
                ).ToList();
            Random random = new Random();

            int index = random.Next(listChef.Count);

            return listChef[index].employee_id;
        }
        public static void placeOrder(headerorder orderHeaderModel)
        {
            try
            {
                dbContextEntities.headerorders.Add(orderHeaderModel);
                dbContextEntities.SaveChanges();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Anda Belum memilih Member");
            }
            
        }

        public static void addOrderDetail(detailorder detailOrderModel)
        {
            dbContextEntities.detailorders.Add(detailOrderModel);
            dbContextEntities.SaveChanges();
        }
        #endregion

        #region chef view order region
        public static List<detailorder> getAllDetailOrder(string orderId)
        {
            return dbContextEntities.detailorders.Where(item => item.order_id.Equals(orderId)).ToList();
        }

        public static void updateStatusOrder(string orderId, string orderStatus, string _bank = "-")
        {
            headerorder orderModel = dbContextEntities.headerorders.Find(orderId);

            orderModel.order_status = orderStatus;
            if (!_bank.Equals("-"))
            {
                orderModel.payment = "cash";
            }
            orderModel.bank = _bank;
            dbContextEntities.SaveChanges();
        }

        public static List<headerorder> getFilteredHeaderOrder(string statusFilter)
        {
            return dbContextEntities.headerorders.Where(item => item.order_status.Equals(statusFilter)).ToList();
        }


        public static List<headerorder> getAllHeaderOrder()
        {
            return dbContextEntities.headerorders.ToList();
        }

        public static void updateStatusOrderDetail(int detail_id, string newStatus)
        {
            detailorder detailModel = dbContextEntities.detailorders.Find(detail_id);
            if(detailModel != null)
            {
                detailModel.status = newStatus;
                dbContextEntities.SaveChanges();
            }
            
        }
        #endregion

        #region auth
        public static msemployee doLoginEmployee(string email, string password)
        {
   
            return dbContextEntities.msemployees.Where(
                item => item.email.Equals(email) && item.password.Equals(password)
                ).FirstOrDefault();

        }

       

        public static void changePasswordEmployee(msemployee employee, string newPassword)
        {
            msemployee selectedEmployee = dbContextEntities.msemployees.Find(employee.employee_id); //.password = newPassword;
            selectedEmployee.password = newPassword;
            dbContextEntities.SaveChanges();

        }

      
        #endregion

        #region member master

        public static void updateMember(msmember selectedMemberModel)
        {
            msmember selectedMember = dbContextEntities.msmembers.Find(selectedMemberModel.member_id);

            selectedMember.name = selectedMemberModel.name;
            selectedMember.email = selectedMemberModel.email;
            selectedMember.handphone = selectedMemberModel.handphone;
            selectedMember.join_date = selectedMember.join_date;
         

            dbContextEntities.SaveChanges();
        }

        public static List<msmember> getAllMember()
        {
            return dbContextEntities.msmembers.ToList();
        }

        public static void deleteMember(string memberID)
        {
            msmember selectedMember = dbContextEntities.msmembers.Find(memberID); //.password = newPassword;

            dbContextEntities.msmembers.Remove(selectedMember);
            dbContextEntities.SaveChanges();
        }

        public static void addMember(msmember selectedMemberModel)
        {
            dbContextEntities.msmembers.Add(selectedMemberModel);
            dbContextEntities.SaveChanges();
        }

       
        #endregion

        #region menu master
        public static List<msmenu> getAllMenu()
        {
            return dbContextEntities.msmenus.ToList();
        }

        public static void updateMenu(msmenu menuModel)
        {
            msmenu selectedMenu = dbContextEntities.msmenus.Find(menuModel.menu_id);

            selectedMenu.name = menuModel.name;
            selectedMenu.price = menuModel.price;       
            selectedMenu.photo = menuModel.photo;
            selectedMenu.img_name = menuModel.img_name;

            dbContextEntities.SaveChanges();
        }

        public static void addMenu(msmenu menuModel)
        {
            dbContextEntities.msmenus.Add(menuModel);
            dbContextEntities.SaveChanges();
        }

        public static void deleteMenu(int menuId)
        {
            msmenu selectedMenu = dbContextEntities.msmenus.Find(menuId); //.password = newPassword;

            dbContextEntities.msmenus.Remove(selectedMenu);
            dbContextEntities.SaveChanges();
        }

        #endregion

        #region employee master

        public static  List<msemployee> getAllEmployee()
        {
            return dbContextEntities.msemployees.ToList();
        }


        public static void updateEmployee(msemployee selectedEmployeeModel)
        {
            msemployee selectedEmployee = dbContextEntities.msemployees.Find(selectedEmployeeModel.employee_id);
            
            selectedEmployee.email = selectedEmployeeModel.email;
            selectedEmployee.position = selectedEmployeeModel.position;
            selectedEmployee.name = selectedEmployeeModel.name;
            selectedEmployee.handphone = selectedEmployeeModel.handphone;

            dbContextEntities.SaveChanges();
        }

        public static void addEmployee(msemployee employeeData)
        {
            dbContextEntities.msemployees.Add(employeeData);
            dbContextEntities.SaveChanges();
        }

        public static void deleteEmployee(string employeeId)
        {
            msemployee selectedEmployee = dbContextEntities.msemployees.Find(employeeId); //.password = newPassword;

            dbContextEntities.msemployees.Remove(selectedEmployee);
            dbContextEntities.SaveChanges();
        }
        #endregion


     
    }
}
