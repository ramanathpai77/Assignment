using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductAssign.Models;

namespace ProductAssign.Controllers
{
    public class ProductController1 : Controller
    {
        public static List<Product> list = new List<Product>()
        {
             new Product{Pid=1 ,pname="Moto one fusion plus",price=17499,stock=40},
            new Product{Pid=2 ,pname="Redmi 8",price=7499,stock=40}
        };

        public IActionResult Index()
        {
            return View(list);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View("Create");
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            list.Add(product);
            return RedirectToAction("Index");
        }
       
        [HttpPost]
        public IActionResult Validate(Product prod)
        {
            if (ModelState.IsValid)
            {
                //add modelt to db tables
                list.Add(prod);
                return RedirectToAction("Index");
            }
            else
            {
                return View("Create");
            }

        }
    }
}
