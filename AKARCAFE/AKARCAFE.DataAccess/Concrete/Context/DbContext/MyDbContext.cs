using AKARCAFE.DataAccess.Concrete.Context.Configuration;
using AKARCAFE.Entities.Concrete;
using System.Data.Entity;

namespace AKARCAFE.DataAccess.Concrete
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base()
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            new ProductConfiguration().Configure(modelBuilder);

        }



        public DbSet<Product> Products { get; set;} 
    }
}
