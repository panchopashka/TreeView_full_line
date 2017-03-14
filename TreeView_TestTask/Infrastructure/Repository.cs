using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeView_TestTask
{
    public class Repository : IRepository
    {
        private static readonly Random _random = new Random();

        public IEnumerable<Category> getCategories(int initialNumber)
        {
            List<Category> result = new List<Category>();
            for (int i=initialNumber; i<initialNumber+25; i++)
            {
                Category category = new Category(i);
                ItemsInitialization(category);
                result.Add(category);
            }

            return result; 
        }

        private void ItemsInitialization(Category category)
        {
            int count = getRandomNumber(1, 11);
            category.Items = new List<Item>();

            while (category.Items.Count() < count)
            {
                int number = getRandomNumber(1, 31);
                if (category.Items.Where(i => i.Number == number).FirstOrDefault() == null)
                    category.Items.Add(new Item(number));
            }

        }

        private int getRandomNumber(int min, int max)
        {
            return Repository._random.Next(min, max);
        }

    }
}
