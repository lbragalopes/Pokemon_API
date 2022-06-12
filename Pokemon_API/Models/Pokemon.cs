using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pokemon_API.Models
{
    public class Pokemon
    {
        [Key]
        [Required]
        public int Codigo { get; set; }
        [Required(ErrorMessage = "O campo nome é obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo tipo é obrigatório")]
        public string Tipo { get; set; }
    }
}
