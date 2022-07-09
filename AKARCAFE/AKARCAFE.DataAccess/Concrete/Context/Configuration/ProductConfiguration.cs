using AKARCAFE.Entities.Concrete;
using System.Data.Entity;

namespace AKARCAFE.DataAccess.Concrete.Context.Configuration
{
    public class ProductConfiguration 
    {
        public void Configure(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasKey(x => x.Id);
            modelBuilder.Entity<Product>().Property(x => x.Money).HasColumnName("URUN_FIYATI");

        }
    }
}
 
