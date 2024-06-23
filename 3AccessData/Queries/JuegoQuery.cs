using _2Domain.DTOs;
using _2Domain.Entities;
using _2Domain.Interfaces.Queries;
using _3AccessData.Commands.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3AccessData.Queries
{
    public class JuegoQuery:IJuegoQuery
    {
        IGenericRepository db;
        public JuegoQuery(IGenericRepository context)
        {
            db = context;
        }
        
        public List<JuegoDTO> GetAllJuego()
        {

            //var AllJuego2 = from tbl1 in db.DB().Juegos
            //                join tbl2 in db.DB().categoriaJuegos
            //                on tbl1.juegoId equals tbl2.JuegoId
            //                join tbl3 in db.DB().Categorias
            //                on tbl2.CategoriaId equals tbl3.categoriaId
            //                select new JuegoDTO
            //                {
            //                    Id=tbl1.juegoId,
            //                    nombre=tbl1.nombre,
            //                    descripcion=tbl1.descripcion,
            //                    imagen=tbl1.imagen,
            //                    precio=tbl1.precio,

            //                };

            var AllJuego3 = (from tbl1 in db.DB().Juegos
                             join tbl2 in db.DB().categoriaJuegos
                             on tbl1.juegoId equals tbl2.JuegoId
                             join tbl3 in db.DB().Categorias
                             on tbl2.CategoriaId equals tbl3.categoriaId
                             select new { juego = tbl1, categoria = tbl3 }).
                            ToList().GroupBy(jc => jc.juego).Select(juegoCategorias => new JuegoDTO
                            {
                                Id = juegoCategorias.Key.juegoId,
                                nombre = juegoCategorias.Key.nombre,
                                descripcion = juegoCategorias.Key.descripcion,
                                imagen = juegoCategorias.Key.imagen,
                                precio = juegoCategorias.Key.precio,
                                categoria = juegoCategorias.Select(c => c.categoria.tipo).ToList()
                            });
                            //select new JuegoDTO
                            //{
                            //    Id = categoriaPorJuego.Key.juegoId,
                            //    nombre = categoriaPorJuego.Key.nombre,
                            //    descripcion = categoriaPorJuego.Key.descripcion,
                            //    imagen = categoriaPorJuego.Key.imagen,
                            //    precio = categoriaPorJuego.Key.precio,
                            //    categoria = categoriaPorJuego.Select(c => c.tipo).ToList()
                            //};


            //var AllJuego = from tbl1 in db.DB(). Juegos
            //               select new JuegoDTO
            //               {
            //                   nombre = tbl1.nombre,
            //                   descripcion = tbl1.descripcion,
            //                   imagen = tbl1.imagen,
            //                   precio = tbl1.precio
            //               };
            return AllJuego3.ToList();
        }
        public JuegoDTO GetJuegoById(int id)
        {


            var JuegoById = from tbl1 in db.DB().Juegos
                            where tbl1.juegoId == id
                            select new JuegoDTO
                            {
                                nombre = tbl1.nombre,
                                descripcion = tbl1.descripcion,
                                imagen = tbl1.imagen,
                                precio = tbl1.precio
                            };



            return JuegoById.ToList()[0];
        }

    }
}
