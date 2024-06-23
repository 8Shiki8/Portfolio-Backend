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
    public class CategoriaQuery:ICategoriaQuery
    {
        GStoreDB db;
        public CategoriaQuery(GStoreDB context)
        {
            db = context;
        }

        public List<Categoria> GetAllCategorias()
        {
          
            var AllCategoria = from tbl1 in db.Categorias
                               select new Categoria()
                               {
                                   categoriaId=tbl1.categoriaId,

                                   tipo = tbl1.tipo,
                               };
            return AllCategoria.ToList();
        }

       
    }
}
