using _2Domain.DTOs;
using _2Domain.Entities;
using _2Domain.Interfaces;
using _2Domain.Interfaces.Queries;
using _3AccessData.Commands.Repository;
using _3AccessData.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Aplication.Services
{
    public class CategoriaService : ICategoriaService
    {
        ICategoriaQuery db;
        IGenericRepository genericRepository;
        public CategoriaDTO AddCategoria(CategoriaDTO categoriaDto)
        {
            Categoria categoria=new Categoria() {tipo=categoriaDto.tipo };
            
            genericRepository.Add(categoria);
            return categoriaDto;
        }

        public List<Categoria>GetAllCategoria()
        {
          return db.GetAllCategorias();
        }

        public CategoriaService(ICategoriaQuery context,IGenericRepository repo)
        {
            db = context;
            genericRepository = repo;
        }
    }
}
