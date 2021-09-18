using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    abstract class Users : IUpdateAccounts
    {
        int userId;
        string firstName;
        string lastnameName;
        string email;
        string password;

        public Users(int userId, string firstName, string lastnameName, string email, string password)
        {
            this.userId = userId;
            this.firstName = firstName;
            this.lastnameName = lastnameName;
            this.email = email;
            this.password = password;
        }


        public void updateName(IUpdateAccounts updateAccounts,string name)
        {
            updateAccounts.updateProfileName(name);
        }



    }
}
