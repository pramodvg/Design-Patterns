using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Audio : IDigitalBooks
    {
        public string getBookName()
        {
            return "Human's History Audio Book";
        }

        public decimal getBookPrice()
        {
            return 30;
        }
    }
}

