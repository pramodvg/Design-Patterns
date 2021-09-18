using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    //The 'Prototype' interface class
    interface IPrototype
    {
        IPrototype getClone();
    }
}
