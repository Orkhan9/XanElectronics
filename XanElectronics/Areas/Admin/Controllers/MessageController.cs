using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using XanElectronics.Dal;

namespace XanElectronics.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class MessageController : Controller
    {
        private readonly DataContext _context;

        public MessageController(DataContext context)
        {
            _context = context;
        }
        // GET
        public IActionResult Index()
        {
            return View(_context.Messages.ToList());
        }
    }
}