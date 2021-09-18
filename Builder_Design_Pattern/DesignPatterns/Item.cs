using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
   abstract class Item
    {
      public abstract decimal getItemPrice();
      public abstract string getItemName();
    }
}
