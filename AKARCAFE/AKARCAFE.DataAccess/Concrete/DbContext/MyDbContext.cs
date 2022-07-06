using AKARCAFE.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKARCAFE.DataAccess.Concrete
{
    public class MyDbContext : DbContext
    {







        public DbSet<Product> products { get; set;} 
    }
}
