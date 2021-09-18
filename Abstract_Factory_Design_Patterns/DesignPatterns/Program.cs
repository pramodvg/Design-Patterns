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
            // Abstract Factory Design Pattern.

            //created Digital book object
            AbstractFactory digitalBook = BookFactory.getDigitalBook();
            IDigitalBooks digitalBookItem = digitalBook.getDigitalBookItem("Video");
            Console.WriteLine("Book Name : {0}. Price : {1}", digitalBookItem.getBookName(), digitalBookItem.getBookPrice());

            //created Physical book object
            AbstractFactory physicalBook = BookFactory.getPhysicalBook();
            IPhysicalBooks physicalBookItem = physicalBook.getPhysicalBookItem("Magazines");
            Console.WriteLine("Book Name : {0}. Price : {1}", physicalBookItem.getBookName(), physicalBookItem.getBookPrice());

            Console.ReadKey();
        }
    }
}
