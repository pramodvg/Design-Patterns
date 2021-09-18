using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class GetCategoryFactory
    {
        public Category getCategory(String categoryType)
        {
            if (categoryType == null)
            {
                return null;
            }
            if (categoryType.Equals("Audio"))
            {
                return new Audio();
            }
            else if (categoryType.Equals("Video"))
            {
                return new Video();
            }
            return null;
        }
    }
}
