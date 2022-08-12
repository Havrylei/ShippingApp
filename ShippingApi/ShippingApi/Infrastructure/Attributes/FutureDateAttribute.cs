using System.ComponentModel.DataAnnotations;

namespace ShippingApi.Infrastructure.Attributes
{
    public class FutureDateAttribute : ValidationAttribute
    {
        public string ErrorMessage { get; set; }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var date = (DateTime)value;

            if (date.Date >= DateTime.UtcNow.Date)
            {
                return ValidationResult.Success;
            }

            return new ValidationResult(ErrorMessage ?? "The date couldn't be in past");
        }
    }
}
