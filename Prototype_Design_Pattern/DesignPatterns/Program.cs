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
            // Prototype Design Pattern

            Users users1 = new Users(1, "Johan", "patel", "joahan123@gmail.com", "johan111");
            users1.createAccount();

            Users users2 = (Users)users1.getClone();
            users2.createAccount();

            Console.ReadKey();
        }
    }
}
