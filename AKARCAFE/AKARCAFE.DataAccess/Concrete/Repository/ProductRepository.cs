using AKARCAFE.Core.DataAccess.Concrete;
using AKARCAFE.DataAccess.Abstract;
using AKARCAFE.Entities.Concrete;

namespace AKARCAFE.DataAccess.Concrete.Repository
{
    public class ProductRepository : GenericRepository<Product> , IProductRepository
    {
    }
}
