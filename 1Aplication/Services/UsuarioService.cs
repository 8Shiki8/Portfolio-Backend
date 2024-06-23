using _2Domain.DTOs;
using _2Domain.Entities;
using _2Domain.Interfaces;
using _2Domain.Interfaces.Queries;
using _3AccessData.Commands.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Aplication.Services
{
    public class UsuarioService : IUsuarioService
    {
        IUsuarioQuery db;
        IGenericRepository repo;     
        public UsuarioDTO AddUsuario(UsuarioDTO usuarioDto)
        {
            Usuario usuario=new Usuario() 
            { 
                nombre = usuarioDto.nombre,
                apellido = usuarioDto.apellido,
                dni = usuarioDto.dni,
                email = usuarioDto.email,

            };
            repo.Add(usuario);
            return usuarioDto;
        }

        public List<UsuarioDTO> GetAllUsuario()
        {
            return db.GetAllUsuario();
        }

        public UsuarioDTO GetUsuarioById(int id)
        {
            return db.GetUsuarioById(id);
        }

        public List<UsuarioDTO> GetEspecial(string nombre, string apellido, string dni)
        {
            return db.GetEspecial(nombre,apellido,dni );
        }

        public List<CarritoDTO> GetCarritoUsuario(int id)
        {
           return db.GetCarritoUsuario(id);
        }

        public UsuarioService(IUsuarioQuery service, IGenericRepository genericRepository )
        {
            db = service;
           repo=genericRepository;
        }
    }
}
