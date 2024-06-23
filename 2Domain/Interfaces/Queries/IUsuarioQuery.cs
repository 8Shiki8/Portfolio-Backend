using _2Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Domain.Interfaces.Queries
{
    public interface IUsuarioQuery
    {
        public List<UsuarioDTO> GetAllUsuario();
        public UsuarioDTO GetUsuarioById(int id);
        public List<UsuarioDTO> GetEspecial(string nombre, string apellido, string dni);
        public List<CarritoDTO> GetCarritoUsuario(int id);


    }
}
