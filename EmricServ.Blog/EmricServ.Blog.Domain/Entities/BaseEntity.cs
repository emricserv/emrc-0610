using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmricServ.Blog.Domain.Entities
{
    public class BaseEntity
    {
        public Int64 Id { get; set; }
        public DateTime CreatedDttm { get; set; }
        public DateTime ModifiedDttm { get; set; }
        //public string Ip { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}
