using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstDemo.Models;

namespace FirstDemo.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            List<Product> prods = MakeProducts();
            return View(prods.ToList());
        }

        private List<Product> MakeProducts()
        {
            Product p1 = new Product();
            p1.ProductName = "Pencils";
            p1.Price = 0.99M;
            p1.Quantity = 100;

            Product p2 = new Product();
            p2.ProductName = "Pens";
            p2.Price = 2.99M;
            p2.Quantity = 50;

            Product p3 = new Product();
            p3.ProductName = "Paper";
            p3.Price = 4.99M;
            p3.Quantity = 500;

            Product p4 = new Product();
            p4.ProductName = "Erasers";
            p4.Price = 1.12M;
            p4.Quantity = 45;

            List<Product> products = new List<Product>();
            products.Add(p1);
            products.Add(p2);
            products.Add(p3);
            products.Add(p4);

            return products;
        }
    }
}