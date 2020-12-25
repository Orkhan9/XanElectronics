using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XanElectronics.Dal;
using XanElectronics.Models;
using XanElectronics.ViewModels;

namespace XanElectronics.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly DataContext _context;
        public HeaderViewComponent(DataContext context, UserManager<AppUser> userManager)
        {
            _userManager = userManager;
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            ViewBag.FullName = "";
            if (User.Identity.IsAuthenticated)
            {
                AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
                ViewBag.FullName = user.UserName;
            }

            decimal Total = 0;
            if (Request.Cookies["xbasket"] != null)
            {
                List<BasketVM> products = JsonConvert.DeserializeObject<List<BasketVM>>(Request.Cookies["xbasket"]);
                ViewBag.BasketCount = products.Where(x => x.UserName == User.Identity.Name).Count();

                foreach (BasketVM item in products.Where(x => x.UserName == User.Identity.Name))
                {
                    Product dbProduct = await _context.Products.FindAsync(item.Id);
                    if (dbProduct != null)
                    {
                        Total += item.BasketCount * dbProduct.ResultPrice;
                    }

                }
                ViewBag.TotalPrice = Total;
            }
            else
            {
                ViewBag.BasketCount = 0;
                ViewBag.TotalPrice = 0;
            }

            Bio model = _context.Bios.FirstOrDefault();
            return View(await Task.FromResult(model));
        }
    }
}
