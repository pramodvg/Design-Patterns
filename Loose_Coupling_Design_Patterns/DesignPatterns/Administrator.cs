using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Administrator : Users
    {
        int adminId;
        string firstName;
        public Administrator(int adminId, int userId, string firstName, string lastnameName, string email, string password) : base(userId, firstName, lastnameName, email, password)
        {
            this.adminId = adminId;
            this.FirstName = firstName;
        }

        public string FirstName { get => firstName; set => firstName = value; }

        public override void updateProfileName(string name)
        {
            FirstName = name;
            Console.WriteLine("Administrator Name Updated : {0}", name);
        }
    }
}
