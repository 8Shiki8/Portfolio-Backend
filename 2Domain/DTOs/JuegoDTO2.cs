using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Domain.DTOs
{
    public class JuegoDTO2
    {
        public string nombre { get; set; }
        public decimal precio { get; set; }
        public string imagen { get; set; }
        public string descripcion { get; set; }

        public List<string> categoria { get; set; }
    }
}
