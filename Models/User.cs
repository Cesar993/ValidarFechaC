#pragma warning disable CS8618

using System.ComponentModel.DataAnnotations;
namespace PersonalErrors.Models;

public class User
{
   [FutureDate]
    public DateTime Fecha { get; set; }

    [MinLength(3, ErrorMessage = "Oops el minimo es de 3 caracteres")]
    [Required]
    public string Apellido { get; set; }
}

public class FutureDateAttribute : ValidationAttribute
{
  protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        DateTime date = (DateTime)value;
        if (date <= DateTime.Now)
        {
            return new ValidationResult("La fecha debe ser en el futuro");
        } else {
            return ValidationResult.Success;
        }
    }
}



