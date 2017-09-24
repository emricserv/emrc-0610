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
    public class BlogPostRepository : Repository<BlogPost>, IBlogPostRepository
    {
        public BlogPostRepository(BlogContext context)
            :base(context)
        {

        }
    }
}
