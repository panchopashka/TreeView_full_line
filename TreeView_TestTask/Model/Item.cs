using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeView_TestTask
{
    public class Item : Element
    {
        public Item()
        {
           
        }
        public Item(int number):this()
        {
            Number = number;          
        }

    }
}
