using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XanElectronics.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int DisCountRate { get; set; }
        public int Star { get; set; }
        public bool IsNew { get; set; }
        public bool IsFeatured { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<ProductImage> ProductImages { get; set; }

    }
}
