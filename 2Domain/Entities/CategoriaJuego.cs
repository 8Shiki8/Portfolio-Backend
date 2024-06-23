using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Domain.Entities
{
    public class CategoriaJuego
    {
        [Key]   
        public int Id { get; set; }
        [ForeignKey("Juego")]
        [Required]
       public int JuegoId { get; set; }
        [ForeignKey("Categoria")]
        [Required]
        public int CategoriaId { get; set; }

        public Juego Juego { get; set;}
        public Categoria Categoria { get; set; }
    }
}
