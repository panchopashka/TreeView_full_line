using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeView_TestTask
{
    public interface IRepository
    {
        IEnumerable<Category> getCategories(int initialNumber);
    }
}
