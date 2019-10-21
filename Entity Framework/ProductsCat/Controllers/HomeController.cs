using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductsCat.Models;

namespace ProductsCat.Controllers
{
    public class HomeController : Controller
    {

        private MyContext db;
     
        // here we can "inject" our context service into the constructor
        public HomeController(MyContext context)
        {
            db = context;
        }



        [HttpGet("Category")]
        public IActionResult Category()
        {
            ViewBag.allCat = db.Categories.ToList();
            return View();
        }

        [HttpPost("CreateCat")]
        public IActionResult CreateCat(Category newCat)
        {
            db.Add(newCat);
            db.SaveChanges();
            return RedirectToAction("Category");
        }


        [HttpGet("CategoryDetails/{Id}")]
        public IActionResult CategoryDetails(int Id)
        {

        ViewBag.SelectedCategory = db.Categories
        .Include(Cat => Cat.ProdcutsInCat)
        .ThenInclude(prod => prod.AssocProduct )
        .FirstOrDefault(categ => categ.CategoryId == Id);

        ViewBag.OtherCategories = db.Categories
        .Include(Cat => Cat.ProdcutsInCat)
        .ThenInclude(prod => prod.AssocProduct )
        .Where(categ => categ.CategoryId != Id);

        ViewBag.IncludedProducts = db.Products
        .Include(Cat => Cat.CategoriesForProd)
        .ThenInclude(prod => prod.AssocCategory )
        .Where(p => p.CategoriesForProd.Any(cp => cp.CategoryId == Id));

        ViewBag.OtherProducts = db.Products
        .Include(Cat => Cat.CategoriesForProd)
        .Where(p => !p.CategoriesForProd.Any(cp => cp.CategoryId == Id));

            return View("CategoryDetails");
        }


        [HttpPost("AddProductToCategory/{Id}")]
        public IActionResult AddProductToCategory(int Id, Association AddingProdToCat)
        {
             db.Add(AddingProdToCat);
             db.SaveChanges();

          return RedirectToAction("CategoryDetails" , new {Id = Id});
        }



////////////////////////////////////////////////////////////////////////////////////


        [HttpGet("")]
        public IActionResult Product()
        {
            ViewBag.allprod = db.Products.ToList();
            return View();
        }


        [HttpPost("CreateProd")]
        public IActionResult CreateProd(Product NewProduct)
        {
            db.Add(NewProduct);
            db.SaveChanges();
            return RedirectToAction("Product");
        }

      
        [HttpGet("ProductDetails/{Id}")]
        public IActionResult ProductDetails(int Id)
        {

        ViewBag.SelectedProduct = db.Products
        .Include(Cat => Cat.CategoriesForProd)
        .ThenInclude(prod => prod.AssocCategory )
        .FirstOrDefault(categ => categ.ProductId == Id);

        ViewBag.OtherProduct = db.Products
        .Include(Cat => Cat.CategoriesForProd)
        .ThenInclude(prod => prod.AssocCategory )
        .Where(categ => categ.ProductId != Id);

        ViewBag.IncludedCategory = db.Categories
        .Include(Cat => Cat.ProdcutsInCat)
        .ThenInclude(prod => prod.AssocCategory )
        .Where(p => p.ProdcutsInCat.Any(cp => cp.ProductId == Id));

        ViewBag.OtherCategory = db.Categories
        .Include(Cat => Cat.ProdcutsInCat)
        .Where(p => !p.ProdcutsInCat.Any(cp => cp.ProductId == Id));

        ViewBag.OtherProducts = db.Products
        .Include(Cat => Cat.CategoriesForProd)
        .Where(p => !p.CategoriesForProd.Any(cp => cp.CategoryId == Id));
            return View("ProductDetails");
        }


        [HttpPost("AddCategoryToProduct/{Id}")]
        public IActionResult AddCategoryToProduct(int Id, Association AddCategoryToProduct)
        {
             db.Add(AddCategoryToProduct);
             db.SaveChanges();

          return RedirectToAction("ProductDetails" , new {Id = Id});
        }

    }
}



    //  ViewBag.OtherProducts= db.Products.Include(p => p.CategoriesForProd).Where(pc => pc.CategoriesForProd.Any(c => c.CategoryId == Id));
        // ViewBag.allproducts = db.Products
        // .Include(Prod => !Prod.CategoriesForProd)
        // ToList()
        // .Wher

    //   ViewBag.AddProds= db.Products.Include(p => p.CategoriesForProd).Where(pc => !pc.CategoriesForProd.Any(c => c.CategoryId == categoryid));

    //   ViewBag.ShowProds= dbContext.Products.Include(p => p.AssocCats).Where(pc => pc.AssocCats.Any(c => c.CategoryId == categoryid));


        // ViewBag.SelectedCategory2 = db.Categories
        // .Include(Cat => Cat.ProdcutsInCat)
        // .ThenInclude(prod => prod.Product )
        // .FirstOrDefault(p => p.CategoryId == Id);
