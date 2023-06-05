using System.ComponentModel.DataAnnotations;

namespace Application.Models
{
    public class Form1
    {
        public string Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Enter Password")]
        public string Password { get; set; }

    }
}
