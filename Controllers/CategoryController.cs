using Bulkyweb.Models;
using BulkyWeb.Data;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

namespace Web_api_dotnet.Controllers
{
    public class CategoryController : Controller
    {
        ApplicationDbContext db;
        public CategoryController(ApplicationDbContext db)
        {
            this.db = db;
        }

        public bool IsCustomValidationPassed(Category obj)
        {
            Regex regex = new Regex("^[a-zA-Z\\s]+$");
            if (!String.IsNullOrEmpty(obj.name) && !regex.IsMatch(obj.name)) // custom validation logic
            {
                ModelState.AddModelError("name", "Name must contain only characters");
            }
            return ModelState.IsValid;
        }
        public IActionResult Index()
        {
            List<Category> categoriesList = db.Categories.ToList();
            return View(categoriesList);
        }

        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(Category obj)
        {
            if (IsCustomValidationPassed(obj))
            {
                db.Categories.Add(obj);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Category? obj = db.Categories.FirstOrDefault(obj => obj.Id == id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        [HttpPost]
        public IActionResult Edit(Category obj)
        {
            if (IsCustomValidationPassed(obj))
            {
                db.Categories.Update(obj);
                db.SaveChanges();
                TempData["success"] = "Category Updated Successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}
