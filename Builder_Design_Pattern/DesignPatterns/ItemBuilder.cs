using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class ItemBuilder
    {
        public ItemType buildAudioItem()
        {
            ItemType books = new ItemType();
            books.Add(new Audio());
            return books;
        }
        public ItemType buildVideoItem()
        {
            ItemType books = new ItemType();
            books.Add(new Video());
            return books;
        }
    }
}
