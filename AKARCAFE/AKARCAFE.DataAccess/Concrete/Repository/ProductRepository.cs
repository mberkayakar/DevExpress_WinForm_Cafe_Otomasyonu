using AKARCAFE.Core.DataAccess.Concrete;
using AKARCAFE.DataAccess.Abstract;
using AKARCAFE.Entities.Concrete;
using System.Data.Entity;

namespace AKARCAFE.DataAccess.Concrete.Repository
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(DbContext db) : base(db)
        {
        }
    }
}
