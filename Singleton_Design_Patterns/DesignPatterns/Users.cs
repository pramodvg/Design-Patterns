using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Users
    {
        int userId;
        string firstName;
        string lastnameName;
        string email;
        string password;

        public void makePayment()
        {
            //getting singleton instance object
            PurchaseItem purchaseItem = PurchaseItem.Instance;
            purchaseItem.buyItem();

        }

    }

}
