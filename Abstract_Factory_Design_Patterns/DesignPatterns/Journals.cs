using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Journals : IPhysicalBooks
    {
        public string getBookName()
        {
            return "India History";
        }

        public decimal getBookPrice()
        {
            return 10;
        }

        public string isDamaged()
        {
            return "No Damage";
        }
    }
}
