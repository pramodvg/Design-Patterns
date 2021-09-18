using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class PurchaseItem : Users
    {
        int itemId;
        string itemName;
        decimal price;
        decimal totalAmount;
        public static PurchaseItem purchaseItem;
        //accessing singleton instance method
        public static PurchaseItem Instance
        {
            get
            {
                if (purchaseItem == null)
                {
                    //singleton instance created only once
                    purchaseItem = new PurchaseItem();
                }
                return purchaseItem;
            }
        }
        public void buyItem()
        {
            Console.WriteLine("Item Purchased.");
        }
    }
}
