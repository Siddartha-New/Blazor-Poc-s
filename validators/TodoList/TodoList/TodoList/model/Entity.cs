using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace TodoList.model
{
    public class Entity
    {
        [Required]
        [StringLength(10,ErrorMessage = "Name is too long.")]
        public string Name { get; set; }
       
        public Guid Id { get; set; }  
        [Required]
        [StringLength(10, ErrorMessage = "Number is too long.")]
        public string MobileNumber { get; set; }

        [Required]
        [Range(typeof(bool), "true", "true",
        ErrorMessage = "Gender Is must Specify")]
        public bool Male { get; set; }

        [Required]
        public bool Female { get; set; }
        [Required(ErrorMessage = "Start Date is required")]
        public DateTime? StartDate { get; set; } = null;
        [Required(ErrorMessage = " End Date is required")]
        public DateTime? EndDate { get; set; } = null;


        [Required]
        [Range(1,10, ErrorMessage = "People must atleast 0 - 1.")]
        public int People { get; set; }
    }
}
