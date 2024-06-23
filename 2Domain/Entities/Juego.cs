using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace _2Domain.Entities
{
    public class Juego
    {
        [Key]
        [Required]
        public int juegoId { get; set; }
        [Column(TypeName ="varchar(40)")]
        [Required]
        public string nombre { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        [Required]
        public decimal precio { get; set; }
        [Column(TypeName = "varchar(500)")]
        [Required]
        public string imagen { get; set; }
        [Column(TypeName = "varchar(2000)")]
        [Required]
        public string descripcion { get; set; }

        public ICollection<CarritoJuego> carritoJuego { get; set; }
        public ICollection<CategoriaJuego> categoriaJuego { get;set; }
    }
}
