using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace _2Domain.Entities
{
    public class CarritoJuego
    {
        [Key]
        [Required]
        public int carritoJuegoId { get; set; }
        
        [Required]
        [ForeignKey ("juego")]
        public int juegoId { get; set; }

        [Required]
        [ForeignKey("carrito")]
        public int carritoId { get; set; }
        [Required]
        [Column(TypeName ="int")]
        public int cantidad { get; set; }
        [Required]
        [Column(TypeName = "DateTime")]
        public DateTime fecha { get; set; }

        public virtual Juego juego { get; set; }
        public virtual Carrito carrito { get; set; }


    }
}
