using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        IDictionary<int ,string> _categories = new Dictionary<int, string>();
        public CategoryRepository()
        {
            InitData();
        }
        private void InitData()
        {
            _categories.Add(1, "Food");
            _categories.Add(2, "Drinks");

            _categories.Add(3, "Shoes");

            _categories.Add(4, "Shirts");

            _categories.Add(5, "Mobile");
            _categories.Add(6, "Laptop");


        }
        public IDictionary<int, string> GetAll()
        {
            return _categories;
        }
    }
}
