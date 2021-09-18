using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    abstract class Category
    {
        protected double price;
        public abstract void getPrice();
        public void getBillAmount(int noOfItems)
        {
            Console.WriteLine("Price is : {0}", price * noOfItems);
        }
    }
}
