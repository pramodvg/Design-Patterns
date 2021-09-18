using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Users : IPrototype
    {
        int userId;
        string firstName;
        string lastnameName;
        string email;
        string password;

        public Users()
        {

        }

        public Users(int userId, string firstName, string lastnameName, string email, string password)
        {
            this.userId = userId;
            this.firstName = firstName;
            this.lastnameName = lastnameName;
            this.email = email;
            this.password = password;
        }

        public IPrototype getClone()
        {
            return new Users(userId, firstName, lastnameName, email, password);
        }

        public void createAccount()
        {
            Console.WriteLine("{0} {1} {2} {3} {4}", userId, firstName, lastnameName, email, password);
        }

    }

  
}
