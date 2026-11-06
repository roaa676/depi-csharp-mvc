using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class productController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>()
        {
            new Product { Id = 1, Name = "Product 1", Price = 100 },
            new Product { Id = 2, Name = "Product 2", Price = 200 }
        };

            return View(products);
        }
    }