using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using XanElectronics.Dal;

namespace XanElectronics.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class SaleController : Controller
    {
        private readonly DataContext _context;
        private readonly IWebHostEnvironment _env;

        public SaleController(DataContext context)
        {
            _context = context;
        }
        
        // GET
        public IActionResult Index()
        {
            return View(_context.Sales.Include(s=>s.AppUser).ToList());
            
        }

        public IActionResult Detail(int? id)
        {
            if (id == null) return NotFound();
            var sale = _context.Sales.Include(s=>s.SaleProducts)
                .ThenInclude(s=>s.Product).FirstOrDefault(p => p.Id == id);
            if (sale == null) return NotFound();
            return View(sale);
        }
    }
}