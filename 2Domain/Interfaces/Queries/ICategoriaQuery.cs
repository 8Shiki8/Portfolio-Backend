using _2Domain.DTOs;
using _2Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Domain.Interfaces.Queries
{
    public interface ICategoriaQuery
    {
        public List<Categoria> GetAllCategorias();


    }
}
