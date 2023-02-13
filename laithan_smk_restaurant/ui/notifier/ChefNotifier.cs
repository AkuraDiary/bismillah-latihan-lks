using laithan_smk_restaurant.data.repository;
using laithan_smk_restaurant.data.source.edm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laithan_smk_restaurant.ui.notifier
{
    public static class ChefNotifier
    {
        public static List<headerorder> listHeaderOrder;
        public static List<detailorder> listDetailOrder;

        #region view order region

      
        public static void getAllHeaderOrder()
        {
            listHeaderOrder = Repository.getAllHeaderOrder();
        }

        public static void getAllDetailOrder(string orderId)
        {
            listDetailOrder = Repository.getAllDetailOrder(orderId);   
        }

        public static void updateStatusOrderDetail(int detail_id, string newStatus)
        {
            Repository.updateStatusOrderDetail(detail_id, newStatus);
        }
        #endregion
    }
}
