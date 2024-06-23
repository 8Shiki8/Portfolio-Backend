using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace _2Domain.Entities
{
    public class Categoria
    {
        [Key]
        [Required]
        public int categoriaId { get; set; }

        [Column(TypeName ="varchar(15)")]
        public string tipo { get; set; }

        
        public ICollection<CategoriaJuego> categoriaJuego { get;set; }



    }
}
