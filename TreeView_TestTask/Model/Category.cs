using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TreeView_TestTask
{
    public class Category : Element, ICloneable
    {       
        public List<Item> Items { get; set; }

        public bool IsExpanded { get; set; }

        public Category()
        {
            IsExpanded = false;
        }

        public Category(int number):this()
        {
            Number = number;
        }

        #region ICloneable
        public object Clone()
        {
            var ds = new DataContractSerializer(typeof(Category));
            MemoryStream stream = new MemoryStream();
            ds.WriteObject(stream, this);
            stream.Position = 0;
            return ds.ReadObject(stream);
        }
        #endregion
    }
}
