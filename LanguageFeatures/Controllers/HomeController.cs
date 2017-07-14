using LanguageFeatures.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
        {
            public string Index()
            {
                return "Navigate to a URL to show an example";
            }

            public ViewResult AutoProperty()
            {
                // create a new Product object            
                Product myProduct = new Product();
                // set the property value            
                myProduct.Name = "Kayak";
                // get the property            
                string productName = myProduct.Name;
                // generate the view            
                return View("Result",(object)String.Format("Product name: {0}", productName));
            }

            public ViewResult CreateProduct()
            {
                // create a new Product object
                Product myProduct = new Product();
                // set the property values
                myProduct.productID = 100;
                myProduct.Name = "Kayak";
                myProduct.Description = "A boat for one person";
                myProduct.Price = 275m;
                myProduct.Category = "Watersports";

                return View("Result", (object)String.Format("Category: {0}", myProduct.Category));
            }

        public ViewResult CreateCollection()
            {
                string[] stringArray = { "apple", "orange", "plum" };
                List<int> intList = new List<int> { 10, 20, 30, 40 };
                Dictionary<string, int> myDict = new Dictionary<string, int> { { "apple", 10 }, { "orange", 20 }, { "plum", 30 } };

                return View("Result", (object)stringArray[1]);
            }

        public ViewResult UseExtension()
            {
            // create and populate ShoppingCart
            ShoppingCart cart = new ShoppingCart
            {
                Products = new List<Product>
                {
                    new Product {Name = "Kayak", Price = 275M },
                    new Product {Name = "Lifejacket", Price = 48.95M },
                    new Models.Product {Name = "Soccerball", Price = 34.95M },
                    new Product {Name = "Cornerflag", Price = 35.95M}
                }
            };
             // get the total value of the products in the cart
            decimal cartTotal = cart.TotalPrices();

            return View("Result", (object)String.Format("Total: {0:c}, cartTotal"));
            }
        }
    } 