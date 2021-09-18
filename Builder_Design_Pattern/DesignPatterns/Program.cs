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
            //creating item builder object
            ItemBuilder itemBuilder = new ItemBuilder();

            //creating audio book item 
            ItemType audioBookObj = itemBuilder.buildAudioItem();
            audioBookObj.Show();

            //creating video book item
            ItemType videoBookObj = itemBuilder .buildVideoItem();
            videoBookObj.Show();

            Console.ReadKey();
        }
    }
}
