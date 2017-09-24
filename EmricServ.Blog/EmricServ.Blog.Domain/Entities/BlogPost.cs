using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmricServ.Blog.Domain.Entities
{
    public class BlogPost : BaseEntity
    {
        public string BlogTitle { get; set; }
        public string BlogExerpt { get; set; }
        public string BlogContent { get; set; }
        public string BlogImage { get; set; }
    }
}
