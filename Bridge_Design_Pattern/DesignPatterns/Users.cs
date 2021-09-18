using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Users : IUsers
    {
        int userId;
        string userName;

        public Users(int userId, string userName)
        {
            this.userId = userId;
            this.userName = userName;
        }

        public void createAccount()
        {
            Console.WriteLine("Account Created");
        }

        public void deleteAccount()
        {
            Console.WriteLine(" Account deleted");
        }

        public void showProfile()
        {
            Console.WriteLine("User ID : {0} User Name : {1}",userId,userName);
        }

        public void updateProfile()
        {
            Console.WriteLine("Account Updated");
        }
    }
}
