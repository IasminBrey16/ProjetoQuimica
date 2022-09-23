using System.ComponentModel.DataAnnotations;
using System.Linq;
using Elementos_Quimicos.Models;

namespace Elementos_Quimicos.Validations
{
    public class ElementoEmUso : ValidationAttribute
    {
        // public ElementoEmUso(string nome) { }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string nome = (string)value;

            DataContext context =
                (DataContext)validationContext.GetService(typeof(DataContext));

            Funcionario funcionario = context.Funcionarios.FirstOrDefault
                (f => f.Nome.Equals(nome));
                
            if (elemento == null)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("O Elemento citado já está em uso!");
        }
    }
}