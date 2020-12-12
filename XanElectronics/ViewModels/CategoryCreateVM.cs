using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace XanElectronics.ViewModels
{
    public class CategoryCreateVM
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [NotMapped,Required]
        public IFormFile Image { get; set; }
    }
}
