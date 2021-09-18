using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            GetCategoryFactory getCategoryFactory = new GetCategoryFactory();
            Category category = getCategoryFactory.getCategory("Audio");
            category.getPrice();
            category.getBillAmount(2);

            Console.ReadKey();
        }
    }
}
