using Microsoft.AspNetCore.Mvc;
using Unit_7_Coffeeshop_Product_List.Models;

namespace Unit_7_Coffeeshop_Product_List.Controllers
{
    public class CoffeeShopController : Controller
    {
        private readonly CoffeeShopDbContext _coffeeDbContext;
        public CoffeeShopController(CoffeeShopDbContext context)
        {
            _coffeeDbContext = context;
        }
        public IActionResult Index()
        {
            List<Product> result = _coffeeDbContext.Products.ToList();
            return View(result);
        }
        public IActionResult ViewProduct(int ProductId)
        {
            Product p = _coffeeDbContext.Products.FirstOrDefault(p => p.Id == ProductId);
            return View(p);
        }
        public IActionResult AddProduct(Product p)
        {
            _coffeeDbContext.Products.Add(p);
            _coffeeDbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DeleteProduct(int[] DeleteList)
        {
            foreach (int ProductId in DeleteList)
            {
                Product p = _coffeeDbContext.Products.FirstOrDefault(p => p.Id == ProductId);
                _coffeeDbContext.Products.Remove(p);
            }
            _coffeeDbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
