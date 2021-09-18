using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class BookFactory
    {
        public static AbstractFactory getDigitalBook()
        {
            return new DigitalBookFactory();
        }

        public static AbstractFactory getPhysicalBook()
        {
            return new PhysicalBookFactory();
        }
    }
}
