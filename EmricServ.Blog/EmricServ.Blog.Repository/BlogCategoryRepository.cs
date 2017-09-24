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
    public class BlogCategoryRepository : Repository<BlogCategory>, IBlogCategoryRepository
    {
        public BlogCategoryRepository(BlogContext context)
            :base(context)
        {

        }

        public int TesMethod()
        { return 100; }
    }

}
