using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using XanElectronics.Dal;

namespace XanElectronics.Controllers
{
    public class ShopController : Controller
    {
        private readonly DataContext _context;
        public ShopController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index(int? page)
        {
            ViewBag.PageCount = Math.Ceiling((decimal)_context.Products.Count() / 4);
            ViewBag.Page = page;

            if (page == null)
            {
                var products = _context.Products.OrderByDescending(p => p.Id).Take(4).Include(c => c.Category)
                .Include(c => c.ProductImages).ToList();
                return View(products);
            }
            else
            {
                var products = _context.Products.OrderByDescending(p => p.Id).Skip(((int)page - 1) * 4)
                 .Take(4).Include(c => c.Category).Include(c => c.ProductImages).ToList();
                return View(products);
            }
        }
    }
}
