using System.ComponentModel.DataAnnotations;

namespace Application.Validations
{
    public class captchavalidation:ValidationAttribute
    {
        public string AllowedDomain { get; set; }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var data = value.ToString().Split();
            if (data[0].Contains("@"))
            {
                return null;
            }
            else
            {
                return new ValidationResult($"{AllowedDomain}",
                new[] { validationContext.MemberName });

            }
        }
    }

}
