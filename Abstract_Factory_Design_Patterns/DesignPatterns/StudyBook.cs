using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class StudyBook : IPhysicalBooks
    {
        public string getBookName()
        {
            return "C# Programming Book";
        }

        public decimal getBookPrice()
        {
            return 50;
        }

        public string isDamaged()
        {
            return "No Damage";
        }
    }
}
