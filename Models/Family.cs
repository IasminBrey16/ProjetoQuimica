using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using API.Validations;

namespace API.Models
{
    //Data Annotations
    public class Family
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo nome é obrigatório!")]
        public string Name { get; set; }

        public string Group { get; set; }

        public List<Element> Elements { get; set; }
    }
}