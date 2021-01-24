using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Registration.Repository
{
    public class RepositoryBase<T>
        where T : class
    {
        private RepositoryBase context = new RepositoryBase();
        protected DbSet<T> DbSet { get; set; }
        public RepositoryBase()
        {
            DbSet = context.Set<T>();
        }

        public List<T> GetAll()
        {
            return DbSet.ToList();
        }
       
        public T Get(int id)
        {
            return DbSet.Find(id);
        }
        public void Add(T entity)
        {
            DbSet.Add(entity);
        }
        public void SaveChanges()
        {
            context.SaveChanges();
        }

    }
        
}
