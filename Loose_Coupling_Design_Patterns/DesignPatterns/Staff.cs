using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Staff : Users
    {
        int staffid;
        string firstName;
        public Staff(int staffid,int userId, string firstName, string lastnameName, string email, string password) : base(userId, firstName, lastnameName, email, password)
        {
            this.Staffid = staffid;
            this.FirstName = firstName;
        }

        public int Staffid { get => staffid; set => staffid = value; }
        public string FirstName { get => firstName; set => firstName = value; }

        public override void updateProfileName(string name)
        {
            FirstName = name;
            Console.WriteLine("Staff Name Updated : {0}", name);
        }
    }
}
