using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class ItemType
    {
        private List<Item> _item = new List<Item>();
        public void Add(Item item)
        {
            _item.Add(item);
        }
        public void Show()
        {
            Console.WriteLine("\nBooks item :");
            foreach (Item item in _item)
            {
                Console.WriteLine("Book Name : {0}",item.getItemName());
                Console.WriteLine("Book Price : {0}",item.getItemPrice());
            }
                
        }
    }
}
