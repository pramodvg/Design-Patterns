using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Video : IDigitalBooks
    {
        public string getBookName()
        {
            return "Java Video Book";
        }

        public decimal getBookPrice()
        {
            return 13;
        }
    }
}

