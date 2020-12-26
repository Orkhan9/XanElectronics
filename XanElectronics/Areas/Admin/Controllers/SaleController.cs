using System.Linq;
using System.Threading.Tasks;
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

        public SaleController(DataContext context)
        {
            _context = context;
        }
        
        // GET
        public IActionResult Index()
        {
            return View(_context.Sales.Where(x=>x.IsFinished==false).Include(s=>s.AppUser).ToList());
            
        }
        
        public IActionResult FinishedSales()
        {
            return View(_context.Sales.Where(x=>x.IsFinished==true).Include(s=>s.AppUser).ToList());
            
        }
        
        public async Task<IActionResult> Deactive(int? id)
        {
            if (id == null) return BadRequest();
            var sale = _context.Sales.FirstOrDefault(x => x.Id == id);
            if (sale == null) return BadRequest();
            sale.IsFinished = true;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
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