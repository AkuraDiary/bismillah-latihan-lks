using laithan_smk_restaurant.data.repository;
using laithan_smk_restaurant.data.source.edm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laithan_smk_restaurant.ui.notifier
{
    public static class CashierNotifier
    {

        #region payment region
        public static List<headerorder> listUnfinishedHeaderOrder;
        public static void submitPayment(string orderId , string newOrderStatus, string bank = "-")
        {
            Repository.updateStatusOrder(orderId, newOrderStatus, bank);
        }
        public static void getPendingHeaderOrder()
        {
            listUnfinishedHeaderOrder = Repository.getFilteredHeaderOrder("pending");
        }
        #endregion
    }
}
