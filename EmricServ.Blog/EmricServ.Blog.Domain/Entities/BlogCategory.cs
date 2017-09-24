using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmricServ.Blog.Domain.Entities
{
    public class BlogCategory : BaseEntity
    {
        public string CategoryName { get; set; }
        public Int64 ParentId { get; set; }
        public string Description { get; set; }
        public string CategoryImage { get; set; }
    }
}
