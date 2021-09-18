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
            UserFormat userFormat = new UserFormat();
            userFormat.users = new Users(1,"Johan");
            userFormat.displayRecord();

            Console.ReadKey();
        }
    }
}
