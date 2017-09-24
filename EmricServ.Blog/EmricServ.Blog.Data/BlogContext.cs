using EmricServ.Blog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmricServ.Blog.Data
{
    public class BlogContext : DbContext
    {
        public BlogContext()
                 : base("name=BlogContext")
        {
            Database.SetInitializer<BlogContext>(null);
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //modelBuilder.Entity<Customer>().HasKey(k => k.CustomerID).Property(p => p.CustomerID).IsRequired();
        }
        public DbSet<BlogCategory> BlogCategory { get; set; }
        public DbSet<BlogPost> BlogPost { get; set; }
        //public DbSet<Order> Orders { get; set; }
    }
}
