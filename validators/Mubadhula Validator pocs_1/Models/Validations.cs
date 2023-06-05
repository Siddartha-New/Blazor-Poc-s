using System.ComponentModel.DataAnnotations;

namespace Mubadhula_Validator_pocs_1.Models
{
    public class Validations
    {
        [Required(ErrorMessage = "Please Enter Your FirstName")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please Enter Your LastName")]
        public string LastName { get; set; }
        [Required]
            
        [RegularExpression(@"^(\+\d{1,3}\s?)?(\(\d{1,3}\)\s?)?(\d{1,3}[\s-]?\d{1,4}[\s-]?\d{1,4})$", ErrorMessage = "Please enter a valid Mobile number.")]
        public string MobileNumber { get; set; }

        [Required]
        [RegularExpression(@"^(?!^0+$)[A-Z0-9]{1,8}$", ErrorMessage = "Please Enter Valid Passport Number.")]
        public string PassPortNumber { get; set; }
    }
}
