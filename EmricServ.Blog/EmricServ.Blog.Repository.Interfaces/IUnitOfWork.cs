using EmricServ.Blog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmricServ.Blog.Repository.Interfaces
{
    public interface IUnitOfWork
    {
        void Save();
        T Repository<T>() where T : class;
    }
}
