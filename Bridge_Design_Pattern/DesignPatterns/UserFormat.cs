using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class UserFormat : UserManager
    {
        public void displayRecords()
        {
            base.displayRecord();
        }
    }
}
