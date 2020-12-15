using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XanElectronics.Dto
{
    public class ProductUpdateDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal ResultPrice { get; set; }
        public int DisCountRate { get; set; }
        public int Star { get; set; }
        public bool IsNew { get; set; }
        public bool IsFeatured { get; set; }
        public int CategoryId { get; set; }
        public IFormFile[] Images { get; set; }

    }
}
