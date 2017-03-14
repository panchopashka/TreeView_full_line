using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace TreeView_TestTask
{
    public abstract class Element
    {
        protected string type;
        public int Number { get; set; }
        public string Color { get; set; }

        public Element()
        {
            type = this.GetType().Name;
            Color = "Black";
        }

        public string Name {
            get
            {
                return type + Number.ToString();
            }
        }


        
    }
}
