using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
             Users users;
             users = new Staff(1, 1, "johan", "mathyu", "pp12@f.com", "abc123");
             users.updateName(users, "mike");

             users = new Administrator(2, 2, "ram", "sita", "pp1fdfd2@f.com", "21321232");
             users.updateName(users, "Kelal");

            Console.ReadKey();

        }
    }
}
