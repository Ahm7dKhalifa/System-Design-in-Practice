using Domain.Core.Products;
using Domain.InfrastructureInterfaces.Databases.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.InfrastructureInterfaces.Databases.PrimaryDatabase.Repositories
{
    public interface IProductsPrimaryDatabaseRepository : IGenericRepository<Product,long>
    {
        Task<List<Product>> GetProductsOrderedDescByTotalNumbersOfLikes(ListParameters<Product> listParameters);
    }
}
