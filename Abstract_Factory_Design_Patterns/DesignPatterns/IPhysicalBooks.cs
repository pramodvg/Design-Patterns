using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    interface IPhysicalBooks
    {
        string isDamaged();
        string getBookName();
        decimal getBookPrice();
        
    }
}
