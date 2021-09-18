using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class DigitalBookFactory : AbstractFactory
    {
        public override IDigitalBooks getDigitalBookItem(string digitalBook)
        {
            if (digitalBook != null)
            {

                if (digitalBook.Equals("Audio"))
                {
                    return new Audio();
                }
                else if (digitalBook.Equals("Video"))
                {
                    return new Video();
                }
              
            }
            return null;
        }

        public override IPhysicalBooks getPhysicalBookItem(string physicalBook)
        {
            throw new NotImplementedException();
        }
    }
}
