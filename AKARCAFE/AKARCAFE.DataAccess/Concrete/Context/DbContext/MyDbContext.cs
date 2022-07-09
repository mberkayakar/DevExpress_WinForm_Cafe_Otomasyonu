using AKARCAFE.DataAccess.Concrete.Context.Configuration;
using AKARCAFE.Entities.Concrete;
using AKARCAFE.Entities.Concrete.Entities;
using System.Data.Entity;

namespace AKARCAFE.DataAccess.Concrete
{
    public class MyDbContext : DbContext
    {

        public MyDbContext() : base("Data Source =.; Initial Catalog = AKARCAFE2022; Integrated Security = True")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            new ProductConfiguration().Configure(modelBuilder);

        }



        public DbSet<Product> Products { get; set;}
        public DbSet<Menu> Menus { get; set; }
        public DbSet<UnitType> UnitTypes{ get; set; }


    }
}
