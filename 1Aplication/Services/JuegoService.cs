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
    public class JuegoService : IJuegoService
    {
        IJuegoQuery db;
        IGenericRepository genericRepository1;
        public JuegoDTO AddJuego(JuegoDTO juegoDto)
        {
            //hize cambios aca

            Juego juego = new Juego() {
                nombre=juegoDto.nombre,
                precio=juegoDto.precio,
                descripcion=juegoDto.descripcion,
                imagen=juegoDto.imagen,
            };
            genericRepository1.Add(juego);

            for (int i=0;i<juegoDto.categoria.Count();i++)
            { 
                CategoriaJuego catJuego=new CategoriaJuego();
                catJuego.JuegoId = juego.juegoId;
                catJuego.CategoriaId = int.Parse(juegoDto.categoria[i]);
                genericRepository1.Add(catJuego);
            }

            return juegoDto;
        }

        public List<JuegoDTO> GetAllJuego()
        {
            return db.GetAllJuego();
        }

        public JuegoDTO GetJuegoById(int id)
        {
            return db.GetJuegoById(id);

        }
        public JuegoService(IJuegoQuery context,IGenericRepository repo)
        {
            db = context;
            genericRepository1 = repo;

        }
    }
}
