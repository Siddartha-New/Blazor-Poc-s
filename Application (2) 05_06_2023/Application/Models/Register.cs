using System.ComponentModel.DataAnnotations;
using Application.Validations;
namespace Application.Models
{
    public class Form1
    {
        public Guid Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        [Validation(AllowedDomain = "Mail is incorrect")]
        public string Email { get; set; }

        //[Required(ErrorMessage = "Enter Password")]

        [Required(ErrorMessage = "Password doesn't Match")]
        public string Password { get; set; }

        [Compare(nameof(Password))]
        public string ConformPassword { get; set; }

        [Required(ErrorMessage = "Please Enter Captcha")]
       
        public string captcha { get; set; }

    }
}
