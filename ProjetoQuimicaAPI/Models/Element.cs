using System;
using System.ComponentModel.DataAnnotations;
using API.Validations;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace API.Models
{
    //Data Annotations
    public class Element
    {
        public Element () => CriadoEm = DateTime.Now;

        public int Id { get; set; }

        [Required(ErrorMessage = "O campo simbolo(do elemento) é obrigatório!")]
        public string Symbol { get; set; }
        
        [Required(ErrorMessage = "O campo número atômico(Z) é obrigatório!")]
        public int Z { get; set; }

        public int FamilyId { get; set; }

        public Family Family { get; set; }

        public string EletronicConfiguration { get; set; }

        public DateTime CriadoEm { get; set; }
    }
}