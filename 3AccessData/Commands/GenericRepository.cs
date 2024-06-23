using _3AccessData.Commands.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3AccessData.Commands
{
    public class GenericRepository:IGenericRepository
    {
        private readonly GStoreDB context1;

        public GenericRepository(GStoreDB context)
        {
            context1 = context;
        }
        public GStoreDB DB() {
            return context1;
        }
        public void Add<T>(T entity) where T : class
        {
            context1.Add(entity);
            context1.SaveChanges();
        }

        public void Remove<T>(T entity) where T : class
        {
            context1.Remove(entity);
            context1.SaveChanges();

        }

        public void Update<T>(T entity) where T : class
        {
            context1.Update(entity);
            context1.SaveChanges();


        }

        public void UpdateRange<T>(List<T> entity) where T : class
        {

            context1.UpdateRange(entity);
            context1.SaveChanges();

        }

        public T FindById<T>(int id) where T : class
        {
            return context1.Find<T>(id);

        }
    }
}
