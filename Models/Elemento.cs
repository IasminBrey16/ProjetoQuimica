using System;
using System.ComponentModel.DataAnnotations;
using Elementos_Quimicos.Validations;

namespace Elementos_Quimicos.Models
{
    //Data Annotations
    public class Elemento
    {
        public Elemento () => CriadoEm = DateTime.Now;
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo nome(do elemento) é obrigatório!")]
        public string Nome { get; set; }

        
        [Required(ErrorMessage = "O campo massa é obrigatório!")]
        public string Massa { get; set; }


        public DateTime CriadoEm { get; set; }
    }
}