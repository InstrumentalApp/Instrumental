// Custom validation
using System.ComponentModel.DataAnnotations;

namespace Instrumental.Attributes;
public class FutureDateAttribute : ValidationAttribute
{
    public int DaysInAdvance { get; init; } = 0;

    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {

        if (value == null)
        {
            return new ValidationResult("Booking Date is required");
        }

        if (value is DateTime)
        {
            DateTime bookingDate = (DateTime)value;

            if (bookingDate > DateTime.UtcNow.AddDays(DaysInAdvance))
            {
                return ValidationResult.Success;
            }
        }

        if (DaysInAdvance > 0)
        {
            return new ValidationResult($"Your Booking Date must be at least {DaysInAdvance} days ahead");
        }

        return new ValidationResult($"Your Booking Date must be in the future");
    }
}
