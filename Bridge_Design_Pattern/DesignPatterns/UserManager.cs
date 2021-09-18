using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class UserManager
    {
       public IUsers users;

        public void openAccount()
        {
            users.createAccount();
        }

        public void changeDetails()
        {
            users.updateProfile();
        }

        public void removeAccount()
        {
            users.deleteAccount();
        }

        public void displayRecord()
        {
            users.showProfile();
        }

    }
}
