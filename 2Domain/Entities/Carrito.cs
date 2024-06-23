using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace _2Domain.Entities
{
    public class Carrito
    {
        [Key]
        [Required]
        public int carritoId { get; set; }

        [ForeignKey("usuario")]
        [Required]
        public int usuarioId { get; set; }
        [Column(TypeName ="decimal(18,2)")]
        public decimal total { get; set; }// cambiar tipo de dato

        public Usuario usuario { get; set; }
        public ICollection<CarritoJuego> carritoJuego { get; set; }

    }
}
