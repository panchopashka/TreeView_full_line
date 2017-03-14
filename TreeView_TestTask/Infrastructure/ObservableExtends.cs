using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeView_TestTask
{
    public static class ObservableReplaceRange
    {
        public static void AddRange<T>(this ObservableCollection<T> rootCollecion, IEnumerable<T> newCollection)
        {
            if (rootCollecion != null)
                foreach (T element in newCollection)
                    rootCollecion.Add(element);
        }

        public static void ReplaceRange<T>(this ObservableCollection<T> rootCollecion, IEnumerable<T> newCollection) where T: ICloneable
        {

            if (rootCollecion != null)
            {
                rootCollecion.Clear();
                foreach (T element in newCollection)
                    rootCollecion.Add((T)element.Clone());
            }
        }
    }
}
