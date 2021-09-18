using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class PhysicalBookFactory : AbstractFactory
    {
      
        public override IPhysicalBooks getPhysicalBookItem(string physicalBook)
        {
            if (physicalBook != null)
            {

                if (physicalBook.Equals("Journal"))
                {
                    return new Journals();
                }
                else if (physicalBook.Equals("Magazines"))
                {
                    return new Magazines();
                }
                else if (physicalBook.Equals("StudyBook"))
                {
                    return new StudyBook();
                }
            }
            return null;
        }

        public override IDigitalBooks getDigitalBookItem(string digitalBook)
        {
            throw new NotImplementedException();
        }
    }
}
