using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HairFlow.Models
{
    public class LoginModel
    {
        [Required]
        [StringLength(100,MinimumLength =5)]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name ="Remember Me")]
        public bool RemeberMe { get; set; }
        public string LoginInValid { get; set; }
    }
}
