using Bulkyweb.Models;
using BulkyWeb.Data;
using Microsoft.AspNetCore.Mvc;

namespace Web_api_dotnet.Controllers
{
    public class CategoryController : Controller
    {
        ApplicationDbContext db;
        public CategoryController(ApplicationDbContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            List<Category> categoriesList = db.Categories.ToList();
            return View(categoriesList);
        }
    }
}
