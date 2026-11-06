using Microsoft.AspNetCore.Mvc;
using ProductCatalog.Models;

namespace ProductCatalog.Controllers
{
    public class ProductController : Controller
    {
        // Тауарлар тізімі (дерекқор орнына жадта сақталады)
        private static readonly List<Product> Products = new()
        {
            new Product { Id = 1, Name = "Ноутбук Lenovo IdeaPad 5", Price = 389990, Category = "Ноутбуктер", IsAvailable = true },
            new Product { Id = 2, Name = "Ноутбук ASUS VivoBook 15", Price = 299990, Category = "Ноутбуктер", IsAvailable = false },
            new Product { Id = 3, Name = "Смартфон Samsung Galaxy A55", Price = 199990, Category = "Смартфондар", IsAvailable = true },
            new Product { Id = 4, Name = "Смартфон iPhone 15", Price = 449990, Category = "Смартфондар", IsAvailable = true },
            new Product { Id = 5, Name = "Құлаққап JBL Tune 520BT", Price = 24990, Category = "Аксессуарлар", IsAvailable = true },
            new Product { Id = 6, Name = "Тінтуір Logitech M185", Price = 7990, Category = "Аксессуарлар", IsAvailable = false },
            new Product { Id = 7, Name = "Монитор Xiaomi 27\"", Price = 89990, Category = "Мониторлар", IsAvailable = true },
            new Product { Id = 8, Name = "Пернетақта Redragon K552", Price = 19990, Category = "Аксессуарлар", IsAvailable = true }
        };

        // GET: /Product/ немесе /Product/Index?category=...
        // Strongly typed view: View-ге List<Product> моделі беріледі
        public IActionResult Index(string? category)
        {
            var products = string.IsNullOrEmpty(category)
                ? Products
                : Products.Where(p => p.Category == category).ToList();

            // ViewData және ViewBag арқылы қосымша деректер беру
            ViewData["Title"] = "Тауарлар каталогы";
            ViewBag.Categories = Products.Select(p => p.Category).Distinct().ToList();
            ViewBag.SelectedCategory = category;
            ViewBag.AvailableCount = products.Count(p => p.IsAvailable);

            return View(products);
        }

        // GET: /Product/Details/1
        public IActionResult Details(int id)
        {
            var product = Products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
    }
}
