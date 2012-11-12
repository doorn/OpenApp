using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace Service
{
    public class CategoryListService : ICategoryListService
    {
        public IEnumerable<Category> GetCategories()
        {
            return MockCategories();
        }
        
        IEnumerable<Category> MockCategories() {
            List<Category> CategoryList = new List<Category>();
            Category cat2 = new Category
            {
                Title = "Avfall & Återvinning",
                Source = "http://orebrokoll.azurewebsites.net/api/Categories/1"
            };
            
            Category cat = new Category
            {
                Title = "Resturanger",
                Source = "http://orebrokoll.azurewebsites.net/api/Categories/2"
            };
            CategoryList.Add(cat2);
            CategoryList.Add(cat);
            return CategoryList;
        }
    }
}
