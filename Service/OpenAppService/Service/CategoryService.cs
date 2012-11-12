using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace Service
{
    public class CategoryService : ICategoryService
    {
        public IEnumerable<Category> GetCategories()
        {
            return MockCategories();
        }
        
        IEnumerable<Category> MockCategories() {
            List<Category> CategoryList = new List<Category>();
            Category cat2 = new Category
            {
                ID = 1,
                Title = "Avfall & Återvinning"
            };
            
            Category cat = new Category
            {
                ID = 1,
                Title = "Resturanger"
            };
            CategoryList.Add(cat2);
            CategoryList.Add(cat);
            return CategoryList;
        }
    }
}
