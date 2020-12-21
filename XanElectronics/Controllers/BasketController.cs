using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using XanElectronics.Dal;
using XanElectronics.Models;
using XanElectronics.ViewModels;

namespace XanElectronics.Controllers
{
    public class BasketController : Controller
    {
        private readonly DataContext _context;
        public BasketController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account");
            }

            decimal number = 0;
            ViewBag.BasketTotalPrice = "";
            string fbasket = Request.Cookies["fbasket"];
            List<BasketVM> basketProducts = new List<BasketVM>();
            List<BasketVM> userProducts = new List<BasketVM>();

            if (fbasket != null)
            {
                basketProducts = JsonConvert.DeserializeObject<List<BasketVM>>(fbasket);

                foreach (BasketVM basketProduct in basketProducts)
                {
                    if (basketProduct.UserName == User.Identity.Name)
                    {
                        Product dbProduct = _context.Products.FirstOrDefault(x => x.Id == basketProduct.Id);
                        if (dbProduct != null)
                        {
                            basketProduct.Price = dbProduct.Price;
                            basketProduct.Image = dbProduct.ProductImages.FirstOrDefault().ImageUrl;
                            basketProduct.Title = dbProduct.Name;
                            basketProduct.DbCount = dbProduct.Count;
                            userProducts.Add(basketProduct);
                        }
                        basketProduct.ProductTotalPrice = basketProduct.BasketCount * basketProduct.Price;
                        number += basketProduct.ProductTotalPrice;
                    }
                }
                ViewBag.BasketTotalPrice = number;
            }
            return View(userProducts);
        }


        public IActionResult AddBasket(int? id)
        {
            decimal basketTotalPrice = 0;

            if (id == null) return NotFound();

            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account");
            }

            Product dbproduct = _context.Products.FirstOrDefault(x => x.Id == id);

            if (dbproduct == null) return NotFound();
            List<BasketVM> basketProducts;
            if (Request.Cookies["fbasket"] == null)
            {
                basketProducts = new List<BasketVM>();
            }
            else
            {
                basketProducts = JsonConvert.DeserializeObject<List<BasketVM>>(Request.Cookies["fbasket"]);
            }

            BasketVM existProduct = basketProducts.FirstOrDefault(p => p.Id == id && p.UserName == User.Identity.Name);

            if (existProduct == null)
            {
                BasketVM newproduct = new BasketVM
                {
                    Id = dbproduct.Id,
                    BasketCount = 1,
                    UserName = User.Identity.Name
                };
                basketProducts.Add(newproduct);
            }
            else
            {
                existProduct.BasketCount++;
            }

            foreach (var basketProduct in basketProducts.Where(x => x.UserName == User.Identity.Name))
            {
                Product dbProduct = _context.Products.FirstOrDefault(x => x.Id == basketProduct.Id);
                if (dbProduct != null)
                {
                    basketProduct.Price = dbProduct.Price;
                    basketProduct.Image = dbProduct.ProductImages.FirstOrDefault().ImageUrl;
                    basketProduct.Title = dbProduct.Name;
                    basketProduct.DbCount = dbProduct.Count;
                }
                basketProduct.ProductTotalPrice = basketProduct.BasketCount * basketProduct.Price;
                basketTotalPrice += basketProduct.ProductTotalPrice;
            }

            string fbasket = JsonConvert.SerializeObject(basketProducts);
            Response.Cookies.Append("fbasket", fbasket, new CookieOptions { MaxAge = TimeSpan.FromDays(14) });
            var anonymObject = new
            {
                BasketTotalPrice = basketTotalPrice,
                BasketProductCount = basketProducts.Where(p => p.UserName == User.Identity.Name).Count()
            };

            return Ok(anonymObject);
        }


        public IActionResult ProductCountPlusAxious([FromForm] int id)
        {
            int basketProductDbCount = 0;
            decimal basketTotalPrice = 0;
            decimal productTotalPrice = 0;
            string basket = Request.Cookies["fbasket"];
            List<BasketVM> basketProducts = JsonConvert.DeserializeObject<List<BasketVM>>(basket);
            BasketVM product = basketProducts.FirstOrDefault(p => p.Id == id && p.UserName == User.Identity.Name);

            product.BasketCount++;
            int basketCount = product.BasketCount;
            foreach (var basketProduct in basketProducts.Where(x => x.UserName == User.Identity.Name))
            {
                Product dbProduct = _context.Products.FirstOrDefault(x => x.Id == basketProduct.Id);
                if (dbProduct.Id == id)
                {
                    basketProductDbCount = dbProduct.Count;
                }
                if (dbProduct != null)
                {
                    basketProduct.Price = dbProduct.Price;
                    basketProduct.Image = dbProduct.ProductImages.FirstOrDefault().ImageUrl;
                    basketProduct.Title = dbProduct.Name;
                    basketProduct.DbCount = dbProduct.Count;
                }
                basketProduct.ProductTotalPrice = basketProduct.BasketCount * basketProduct.Price;
                if (basketProduct.Id == id)
                {
                    productTotalPrice = basketProduct.ProductTotalPrice;
                }
                basketTotalPrice += basketProduct.ProductTotalPrice;
            }

            string fbasket = JsonConvert.SerializeObject(basketProducts);
            Response.Cookies.Append("fbasket", fbasket, new CookieOptions { MaxAge = TimeSpan.FromDays(14) });
            var anonymObject = new
            {
                BasketProducts = basketProducts,
                ProductBasketCount = basketCount,
                BasketTotalPrice = basketTotalPrice,
                ProductTotalPrice = productTotalPrice,
                BasketProductDbCount = basketProductDbCount,
                ProductId = product.Id
            };
            return Ok(anonymObject);
        }

        public IActionResult ProductCountMinusAxious(int? id)
        {
            decimal basketTotalPrice = 0;
            decimal productTotalPrice = 0;
            string basket = Request.Cookies["fbasket"];
            List<BasketVM> basketProducts = JsonConvert.DeserializeObject<List<BasketVM>>(basket);
            BasketVM product = basketProducts.FirstOrDefault(p => p.Id == id);

            if (product.BasketCount > 1)
            {
                product.BasketCount--;
            }
            else
            {
                basketProducts.Remove(product);
            }

            int basketCount = product.BasketCount;
            foreach (var basketProduct in basketProducts.Where(x => x.UserName == User.Identity.Name))
            {
                Product dbProduct = _context.Products.FirstOrDefault(x => x.Id == basketProduct.Id);
                if (dbProduct != null)
                {
                    basketProduct.Price = dbProduct.Price;
                    basketProduct.Image = dbProduct.ProductImages.FirstOrDefault().ImageUrl;
                    basketProduct.Title = dbProduct.Name;
                    basketProduct.DbCount = dbProduct.Count;
                }
                basketProduct.ProductTotalPrice = basketProduct.BasketCount * basketProduct.Price;
                if (basketProduct.Id == id)
                {
                    productTotalPrice = basketProduct.ProductTotalPrice;
                }
                basketTotalPrice += basketProduct.ProductTotalPrice;
            }

            string fbasket = JsonConvert.SerializeObject(basketProducts);
            Response.Cookies.Append("fbasket", fbasket, new CookieOptions { MaxAge = TimeSpan.FromDays(14) });
            var anonymObject = new
            {
                BasketProducts = basketProducts,
                ProductBasketCount = basketCount,
                BasketTotalPrice = basketTotalPrice,
                ProductTotalPrice = productTotalPrice
            };
            return Ok(anonymObject);
        }


        public IActionResult RemoveProduct(int? id)
        {
            decimal basketTotalPrice = 0;
            string basket = Request.Cookies["fbasket"];
            List<BasketVM> basketProducts = JsonConvert.DeserializeObject<List<BasketVM>>(basket);
            BasketVM product = basketProducts.FirstOrDefault(p => p.Id == id);

            basketProducts.Remove(product);

            foreach (var basketProduct in basketProducts.Where(x => x.UserName == User.Identity.Name))
            {
                Product dbProduct = _context.Products.FirstOrDefault(x => x.Id == basketProduct.Id);
                if (dbProduct != null)
                {
                    basketProduct.Price = dbProduct.Price;
                    basketProduct.Image = dbProduct.ProductImages.FirstOrDefault().ImageUrl;
                    basketProduct.Title = dbProduct.Name;
                    basketProduct.DbCount = dbProduct.Count;
                }
                basketProduct.ProductTotalPrice = basketProduct.BasketCount * basketProduct.Price;
                basketTotalPrice += basketProduct.ProductTotalPrice;
            }

            string fbasket = JsonConvert.SerializeObject(basketProducts);
            Response.Cookies.Append("fbasket", fbasket, new CookieOptions { MaxAge = TimeSpan.FromDays(14) });
            var anonymObject = new
            {
                BasketTotalPrice = basketTotalPrice,
                BasketProductCount = basketProducts.Where(x => x.UserName == User.Identity.Name).Count()
            };
            return Ok(anonymObject);
        }


    }
}
