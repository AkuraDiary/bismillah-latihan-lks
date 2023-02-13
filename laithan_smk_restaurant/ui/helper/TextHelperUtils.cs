using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laithan_smk_restaurant.ui.helper
{
    public static class TextHelperUtils
    {
        public static string generateRandomString(int len)
        {
            Random res = new Random();
            string result = "";
            string stringsMag = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890";

            for (int i = 0; i < len; i++)
            {
                int x = res.Next(stringsMag.Length);
                result = result + stringsMag[x];
            }
            return result;
        }
    }
}
