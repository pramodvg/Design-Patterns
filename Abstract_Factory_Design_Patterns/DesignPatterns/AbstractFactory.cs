using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    abstract class AbstractFactory
    {
        public abstract IPhysicalBooks getPhysicalBookItem(String physicalBook);
        public abstract IDigitalBooks getDigitalBookItem(String digitalBook);
    }
}
