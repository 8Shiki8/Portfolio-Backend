using _2Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Domain.Interfaces.Queries
{
    public interface IJuegoQuery
    {
        public List<JuegoDTO> GetAllJuego();
        public JuegoDTO GetJuegoById(int id);
    }
}
