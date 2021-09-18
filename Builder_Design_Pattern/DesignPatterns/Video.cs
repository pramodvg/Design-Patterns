using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Video : Category
    {
        public override string getItemName()
        {
            return "C# video book";
        }

        public override decimal getItemPrice()
        {
            return 50;
        }
    }
}

