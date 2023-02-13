using laithan_smk_restaurant.data.repository;
using laithan_smk_restaurant.data.source.edm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laithan_smk_restaurant.ui.notifier
{
    public static class ReportNotifier
    {
        public static List<headerorder> listHeaderOrder;

        public static void getAllHeaderOrder()
        {
            listHeaderOrder = Repository.getFilteredHeaderOrder("paid");
        }

    }
}
