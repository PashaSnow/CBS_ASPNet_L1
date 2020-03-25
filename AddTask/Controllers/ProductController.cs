using System.Collections.Generic;
using System.Web.Mvc;
using Task2.Models;

namespace AddTask.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        List<Product> product = new List<Product>();
        public ActionResult List()
        {

            product.Add(new Product());
            product.Add(new Product { ID = 2, Name = "Audi", Price = 80.7m, Description = "Car with standart engine" });
            product.Add(new Product { ID = 3, Name = "Ford", Price = 15m, Description = "Car with standart engine" });
            product.Add(new Product { ID = 4, Name = "Jeep", Price = 30.0m, Description = "Car with standart engine" });

            return View(product);
        }
        public ActionResult Details()
        {
            return View();
        }

    }
}