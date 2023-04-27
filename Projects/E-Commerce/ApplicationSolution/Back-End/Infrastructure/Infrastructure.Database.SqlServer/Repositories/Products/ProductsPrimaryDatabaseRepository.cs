using Domain.Core.Products;
using Domain.InfrastructureInterfaces.Databases.PrimaryDatabase.Repositories;
using Domain.InfrastructureInterfaces.Databases.Shared;
using Infrastructure.Database.SqlServer.EntityFrameworkCore;
using Infrastructure.Database.SqlServer.QueryBuilders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Database.SqlServer.Repositories
{
    public class ProductsSqlServerDatabaseRepository : GenericRepository<Product,long> , IProductsPrimaryDatabaseRepository
    {
        public ProductsSqlServerDatabaseRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
           
        }

        public async Task<Product> GetProductById(long productId)
        {
            return await this._databaseSet
                            .AsQueryable()
                            .Include(product => product.Price)
                            .Include(product => product.ProductAttributes)
                            .Include(product => product.ProductLikes)
                            .Include(product => product.ProductViewers)
                            .Include(product => product.ProductFiles)
                            .ThenInclude(productFile => productFile.ProductFileType)
                            .Where(product => product.Id == productId)
                            .FirstOrDefaultAsync();

        }

        public async Task<List<Product>> GetProductsOrderedDescByTotalNumbersOfLikes(ListParameters<Product> listParameters)
        {
            return await this._databaseSet
                            .AsQueryable()
                            .WhereConditionsQueryBuilder(listParameters.WhereConditions)
                            .PagingQueryBuilder(listParameters.PagingParameters)
                            .OrderByDescending(p => p.TotalCountOfLikes)
                            .AsNoTracking()
                            .ToListAsync();

        }

       
    }
}
