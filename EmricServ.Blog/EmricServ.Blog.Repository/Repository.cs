using EmricServ.Blog.Data;
using EmricServ.Blog.Domain.Entities;
using EmricServ.Blog.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmricServ.Blog.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private BlogContext context = null;
        private DbSet<TEntity> dbSet = null;

        public Repository(BlogContext context)
        {
            this.context = context;
            dbSet = context.Set<TEntity>();
        }

        public virtual IEnumerable<TEntity> SelectAll()
        {
            return dbSet.ToList();
        }

        public virtual TEntity SelectByID(object id)
        {
            return dbSet.Find(id);
        }

        public virtual void Insert(TEntity obj)
        {
            dbSet.Add(obj);
        }

        public virtual void Update(TEntity obj)
        {
            dbSet.Attach(obj);
            context.Entry(obj).State = EntityState.Modified;
        }

        public virtual void Delete(object id)
        {
            TEntity existing = dbSet.Find(id);
            dbSet.Remove(existing);
        }

        public virtual void Save()
        {
            context.SaveChanges();
        }
    }
}
