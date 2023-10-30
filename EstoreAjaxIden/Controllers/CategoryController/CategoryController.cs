using Microsoft.AspNetCore.Mvc;

namespace EstoreAjaxIden.Controllers.CategoryController
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
