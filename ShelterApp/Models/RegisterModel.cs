using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShelterApp.Models
{
    public class RegisterModel
    {
        [Display(Name = "Adınız")]
        [Required(AllowEmptyStrings =false,ErrorMessage ="Adı Boş Bırakılamaz")]
        public string Firstname { get; set; } = string.Empty;

        [Display(Name = "Soyadınız")]
        [Required(AllowEmptyStrings =false,ErrorMessage ="Soyadı Boş Bırakılamaz")]
        public string Lastname { get; set; } = string.Empty;

        [Display(Name = "Email Adresiniz")]
        [DataType(DataType.EmailAddress)]
        [Required(AllowEmptyStrings =false,ErrorMessage ="Email Boş Bırakılamaz")]
        [RegularExpression(@"^[\w-]+(\.[\w-]+)*@([a-z0-9-]+(\.[a-z0-9-]+)*?\.[a-z]{2,6}|(\d{1,3}\.){3}\d{1,3})(:\d{4})?$", ErrorMessage = "Geçerli bir email adresi giriniz")]
        public string Email { get; set; } = string.Empty;

        [Display(Name = "Şifreniz")]
        [MinLength(6)]
        [DataType(DataType.Password)]
        [Required(AllowEmptyStrings =false,ErrorMessage ="Şifre Boş Bırakılamaz")]
        public string Password { get; set; } = string.Empty;

        [Display(Name = "Telefon Numaranız")]
        [Phone]
        [Required(AllowEmptyStrings =false,ErrorMessage ="Telefon Boş Bırakılamaz")]
        public string Phonenumber { get; set; } = string.Empty;
    }
}