using System.ComponentModel.DataAnnotations;

namespace Mubadhula_Validator_pocs_1.Models
{
    public class Radio
    {
        public int RadioValue { get; set; }
        public string Gender { get; set; }
      
    }   
    public class MobileNumbers
    {
        public string Region { get; set; }

        public string Digit_Num { get; set; }
    }
}
