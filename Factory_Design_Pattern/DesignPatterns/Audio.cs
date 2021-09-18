using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Audio : Category
    {
        public override void getPrice()
        {
            price = 10;
        }
    }
}
