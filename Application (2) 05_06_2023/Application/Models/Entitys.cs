using System.ComponentModel.DataAnnotations;

namespace Application.Models
{
    public class Entitys
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Description { get; set; }

        [Required]
        public string password { get; set; }
    }
}
