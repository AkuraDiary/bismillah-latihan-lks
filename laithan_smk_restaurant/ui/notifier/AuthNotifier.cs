using laithan_smk_restaurant.data.repository;
using laithan_smk_restaurant.data.source.edm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laithan_smk_restaurant.ui.notifier
{
    public static class AuthNotifier
    {
        public static msemployee loggedInEmployee = null;

        public static void doLoginEmployee(string email, string password)
        {
            loggedInEmployee = Repository.doLoginEmployee(email, password);
        }

        public static void doLogout()
        {
            loggedInEmployee = null;
        }
    }
}
