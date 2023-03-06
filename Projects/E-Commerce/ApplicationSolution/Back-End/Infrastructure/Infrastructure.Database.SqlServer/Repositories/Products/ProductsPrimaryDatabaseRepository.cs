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
    public class ProductsPrimaryDatabaseRepository : GenericRepository<Product,long> , IProductsPrimaryDatabaseRepository
    {
        public ProductsPrimaryDatabaseRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
           
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
