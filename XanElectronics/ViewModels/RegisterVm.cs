using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace XanElectronics.ViewModels
{
    public class RegisterVm
    {
        [Required, MaxLength(200)]
        public string FullName { get; set; }
        [Required, MaxLength(100)]
        public string UserName { get; set; }
        [Required, EmailAddress, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [StringLength(6, MinimumLength = 6,  ErrorMessage = "length err")]
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
