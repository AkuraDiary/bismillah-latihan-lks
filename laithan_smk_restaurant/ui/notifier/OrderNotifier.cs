using laithan_smk_restaurant.data.repository;
using laithan_smk_restaurant.data.source.edm;
using laithan_smk_restaurant.ui.helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laithan_smk_restaurant.ui.notifier
{
    public static class OrderNotifier
    {

       
        
        public static string generateOrderId()
        {
            return "ORDER-" + TextHelperUtils.generateRandomString(8);
        }


        public static string placeOrder(string memberId, string employeeId, int totalPrice)
        {
            string orderHeaderId = generateOrderId();
            headerorder orderHeaderModel = new headerorder();

            orderHeaderModel.order_id = orderHeaderId;
            orderHeaderModel.employee_id = employeeId;
            orderHeaderModel.member_id = memberId;
            orderHeaderModel.date = DateTime.Now;

            orderHeaderModel.payment = "-"; //default
            orderHeaderModel.bank = "-"; //default
            orderHeaderModel.order_status = "pending"; //default
            orderHeaderModel.total_price = totalPrice;
            

            Repository.placeOrder(orderHeaderModel);

            return orderHeaderId;
        
        }

        public static void placeOrderItemDetail(detailorder detailOrderModel)
        {
            Repository.addOrderDetail(detailOrderModel);
        }

    
    }

  
}
