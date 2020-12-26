using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using XanElectronics.Dal;
using XanElectronics.Dto;
using XanElectronics.Models;

namespace XanElectronics.Controllers
{
    public class ShopController : Controller
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public ShopController(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
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
                return PartialView("_partialPagination",products);
            }
        }

        public IActionResult Detail(int? id)
        {
            if (id == null) return NotFound();
            var product = _context.Products.Include(x => x.ProductImages)
                .FirstOrDefault(x => x.Id == id);
            if (product == null) return BadRequest();
            return View(product);
        }
    }
}
