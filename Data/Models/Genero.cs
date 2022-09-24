using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Livraria.Data.Models
{
    [Table("Genero")]
    public class Genero
    {
        public Genero()
        {

        }

        [Key]
        [Required]
        public int GeneroId { get; set; }
        public string Descricao { get; set; }

    }

    
}
