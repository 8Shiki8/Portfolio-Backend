using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3AccessData.Commands.Repository
{
    public interface IGenericRepository
    {
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Remove<T>(T entity) where T : class;
        void UpdateRange<T>(List<T> entity) where T : class;

        T FindById<T>(int id) where T : class;
        public GStoreDB DB();



    }
}
