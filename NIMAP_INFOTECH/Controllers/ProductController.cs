using Microsoft.AspNetCore.Mvc;
using NIMAP_INFOTECH.Data;
using NIMAP_INFOTECH.Models;
using System.Drawing.Design;

namespace NIMAP_INFOTECH.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationContext context;

        public ProductController(ApplicationContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var result = context.Products.ToList();
            return View(result);
        }
        [HttpGet]
        public IActionResult Create() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product model)
        {
            if (ModelState.IsValid)
            {
                var prd = new Product()
                {
                    ProductName=model.ProductName,
                    CategoryId=model.CategoryId,
                    CategoryName=model.CategoryName
                };
                context.Products.Add(prd);
                context.SaveChanges();
                TempData["error"] = "Record Saved";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["error"] = "Empty field can't submit";
                return View(model);
            }

        }
        public IActionResult Delete(int ProductId)
        {
            var prd = context.Products.SingleOrDefault(p => p.ProductId == ProductId);
            context.Products.Remove(prd);
            context.SaveChanges();
            TempData["error"] = "Record Deleted";
            return RedirectToAction("Index");
        }
        
        public IActionResult Edit(int ProductId)
        {
            var prd = context.Products.SingleOrDefault(p => p.ProductId == ProductId);
            var result = new Product()
            {
                ProductName = prd.ProductName,
                CategoryId = prd.CategoryId,
                CategoryName = prd.CategoryName
            };
            return View(result);
        }
        
        [HttpPost]
        public IActionResult Edit(Product model)
        {
            var prd = new Product()
            {
                ProductId = model.ProductId,
                ProductName=model.ProductName,
                CategoryId=model.CategoryId,
                CategoryName=model.CategoryName
            };
            context.Products.Update(prd);
            context.SaveChanges();
            TempData["error"] = "Product Details Updated";
            return RedirectToAction("Index");
        }
    }
}
