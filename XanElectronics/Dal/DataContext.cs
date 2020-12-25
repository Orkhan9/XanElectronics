using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XanElectronics.Models;

namespace XanElectronics.Dal
{
    public class DataContext :IdentityDbContext<AppUser>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SaleProduct> SaleProducts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Bio> Bios { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Service> Services { get; set; }
    }
}
