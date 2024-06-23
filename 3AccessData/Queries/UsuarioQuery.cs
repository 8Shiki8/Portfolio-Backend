using _2Domain.DTOs;
using _2Domain.Entities;
using _2Domain.Interfaces.Queries;
using _3AccessData.Commands;
using _3AccessData.Commands.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3AccessData.Queries
{
    public class UsuarioQuery:IUsuarioQuery
    {
        // CONTINUAR DESDE ACA
        IGenericRepository db;
        public UsuarioQuery(IGenericRepository context)
        {
            db = context;
        }
       
        public List<UsuarioDTO> GetAllUsuario()
        {
            var AllUsuario = from tbl1 in db.DB().Usuarios
                             select new UsuarioDTO
                             {
                                 nombre = tbl1.nombre,
                                 apellido = tbl1.apellido,
                                 dni = tbl1.dni,
                                 email = tbl1.email
                             };

                            return AllUsuario.ToList();
        }
        public UsuarioDTO GetUsuarioById(int id)
        {
            Usuario usuario = db.FindById<Usuario>(id);
            UsuarioDTO usuarioDto = new UsuarioDTO
            {
                nombre = usuario.nombre,
                apellido = usuario.apellido,
                dni = usuario.dni,
                email = usuario.email
            };

            return usuarioDto;
        }

        public List< UsuarioDTO >GetEspecial(string nombre,string apellido,string dni)
        {
            var usuario2 = from tbl2 in db.DB().Usuarios.Where(p =>
            ((string.IsNullOrEmpty(nombre) || p.nombre==nombre )&&
            ((string.IsNullOrEmpty(apellido) || p.apellido==apellido) &&
            (string.IsNullOrEmpty(dni) || p.dni==dni)))) select new UsuarioDTO
               {
                   nombre = tbl2.nombre,
                   apellido = tbl2.apellido,
                   dni = tbl2.dni,
                   email=tbl2.email
                 
               };


            return usuario2.ToList();
        }

        public List<CarritoDTO> GetCarritoUsuario(int id)
        {
            var carritoUsuario = from tbl1 in db.DB().Carritos where tbl1.carritoId==id
                                 join tbl2 in db.DB().Usuarios
                                 on tbl1.usuarioId equals tbl2.usuarioId
                                 select new CarritoDTO
                                 {
                                     carritoId = tbl1.usuarioId,
                                     nombre = tbl2.nombre,
                                     apellido = tbl2.apellido,
                                     total = tbl1.total
                                 };
            return carritoUsuario.ToList();
        }
    }
}
