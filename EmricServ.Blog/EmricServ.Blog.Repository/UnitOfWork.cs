using EmricServ.Blog.Data;
using EmricServ.Blog.Domain.Entities;
using EmricServ.Blog.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmricServ.Blog.Repository
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private readonly BlogContext context;
        string errorMessage = string.Empty;
        private bool disposed;
        private Dictionary<string, object> repositories;

        public UnitOfWork(BlogContext context)
        {
            this.context = context;
        }

        public UnitOfWork()
        {
            context = new BlogContext();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            disposed = true;
        }

        public T Repository<T>() where T : class
        {
            if (repositories == null)
            {
                repositories = new Dictionary<string, object>();
            }

            var type = typeof(T).Name;

            if (!repositories.ContainsKey(type))
            {
                var repositoryType = typeof(T);
                var repositoryInstance = Activator.CreateInstance(repositoryType, context);
                repositories.Add(type, repositoryInstance);
            }
            return (T)repositories[type];
        }
    }
}
