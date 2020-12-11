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
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<ProductImage> ProductImages { get; set; }

    }
}
