using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shopping.Models;

namespace Shopping.Controllers
{
    public class ProductsController : Controller
    {
        private List<ProductModel> products = new List<ProductModel>()
            {
                new ProductModel { id = 1, name ="Iphone",price=2000.5f,image = "https://shop.jtglobal.com/wp-content/uploads/2020/10/iphone-12-red.jpg" },
                new ProductModel { id = 2, name = "Samsung", price = 2350.5f , image ="https://th.bing.com/th/id/R3c5a616c0e81979c3ebea66028c07292?rik=%2fpYO8pGlVMOlPQ&pid=ImgRaw" },
                new ProductModel { id = 3, name = "Huawei", price = 2212.5f , image = "https://th.bing.com/th/id/OIP.SveOfFB72I9UFFR3DF0PgQHaHa?pid=ImgDet&rs=1"},
            };
        public IActionResult Index(string color = "")
        {
            ViewData["color"] = color;
            ViewData["AllProducts"] = products;
            return View();
        }
        //GET: /Products/Details/id
        public IActionResult Details(int ? Id)
        {
            if(Id==null)
            {
                return Content("no product");
            }
            else
            {
                var product = products.Find(match: model => model.id == Id);

                if(product == null)
                {
                    return Content("NotFound");
                }
                ViewData["product"] = product;
            }
           

            return View();

          
        }
    }
}
