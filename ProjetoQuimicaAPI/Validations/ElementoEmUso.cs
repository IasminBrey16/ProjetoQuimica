using System.ComponentModel.DataAnnotations;
using System.Linq;
using API.Models;

namespace API.Validations
{
    public class ElementEmUso : ValidationAttribute
    {
        // public ElementEmUso(string symbol) { }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string symbol = (string)value;

            DataContext context =
                (DataContext)validationContext.GetService(typeof(DataContext));

            Element element = context.Elements.FirstOrDefault
                (f => f.Symbol.Equals(symbol));
                
            if (element == null)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("O Element citado já está em uso!");
        }
    }
}