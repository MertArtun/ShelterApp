using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShelterApp.Models
{
    public class LoginModel
    {
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Lütfen Email Adresinizi Kontrol Edin")]
        [Required(ErrorMessage = "Email adresi boş bırakılamaz")]
        public string Email { get; set; } = string.Empty;

        [Display(Name = "Şifre")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "Şifreniz minimum 6 karakter olmalıdır")]
        [Required(ErrorMessage = "Şifre boş bırakılamaz")]
        public string Password { get; set; } = string.Empty;
    }
}