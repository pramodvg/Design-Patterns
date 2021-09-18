using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Magazines : IPhysicalBooks
    {
        public string getBookName()
        {
            return "IndiaTimes";
        }

        public decimal getBookPrice()
        {
            return 3;
        }

        public string isDamaged()
        {
            return "No Damage";
        }
    }
}
