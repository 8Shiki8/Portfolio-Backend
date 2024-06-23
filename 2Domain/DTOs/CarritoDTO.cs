using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Domain.DTOs
{
    public class CarritoDTO
    {
        public int carritoId { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set;}
        public decimal total { get; set; }
    }
}
