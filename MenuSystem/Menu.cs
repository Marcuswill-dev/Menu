using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MenuSystem
{
    internal class Menu
    {
        public string Title;
        public MenuItem[] MenuItems;
        public int ItemCount = 0;
        public void Show()
        {
            Console.WriteLine(Title);
            for (int i = 0; i < ItemCount; i++)
            {
                Console.WriteLine(MenuItems[i].Title);
            }

        }
        
        

    }
}
