using BusinessObject;
using DataAccess.Repository.CategoryRepository;
using DataAccess.Repository.ProductRepository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EstoreAPI.Controllers.CategoryController
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {

        private  ICategoryRepository categoryRepository = new CategoryRepository();

        [HttpGet]
        public ActionResult<IEnumerable<Category>> GetCategories() => categoryRepository.GetAllCategories();
    }
}
