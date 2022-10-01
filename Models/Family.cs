using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using API.Validations;
using System.Text.Json.Serialization;

namespace API.Models
{
    //Data Annotations
    public class Family
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo nome é obrigatório!")]
        public string Name { get; set; }

        public string SpecificName { get; set; } 

        [JsonIgnore]
        public List<Element> Elements { get; set; }
    }
}