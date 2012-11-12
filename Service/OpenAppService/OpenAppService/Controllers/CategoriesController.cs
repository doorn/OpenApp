using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Service;

namespace OpenAppService.Controllers
{
    public class CategoriesController : ApiController
    {
        
        // GET: api/Categories
        public IEnumerable<object> Get()
        {
            ICategoryListService categoryListService = new CategoryListService();
            return categoryListService.GetCategories();
        }
        // GET api/Categories/5
        public IEnumerable<object> Get(int id)
        {
            ICategoryService categoryService = new CategoryService();
            return categoryService.GetCategory(id);
        }
    }
}
