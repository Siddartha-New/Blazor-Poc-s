using System.ComponentModel.DataAnnotations;

namespace Mubadhula_Validator_pocs_1.Models
{
    public class Regex
    {
            [Required]
            [RegularExpression(@"^\+(?:[0-9] ?)[0-9]$", ErrorMessage = "saudi accepted")]
            public string saudi { get; set; }
            [Required]
            [RegularExpression(@"^\+(?:[0-9] ?)[0-9]$", ErrorMessage = "Iran accepted")]   
            public string Iran { get; set; }
            [Required]
            [RegularExpression(@"^\+(?:[0-9] ?)[0-9]$", ErrorMessage = "India accepted")]
            public string India { get; set; }
        
    }
}
