using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace _2Domain.Entities
{
    public class Usuario
    {   
        [Key]
        [Required]
        public int usuarioId { get; set; }
        [Required]
        [Column (TypeName ="varchar(15)")]
        public string nombre { get; set; }
        [Required]
        [Column(TypeName = "varchar(15)")]

        public string apellido { get; set; }
        [Required]
        [Column (TypeName ="varchar(15)")]

        public string dni { get; set; }
        [Required]
        [Column(TypeName = "varchar(40)")]
        public string email{ get; set; }

        public Carrito carrito { get; set; }



    }
}
