using Domain.Core.Shared;
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
    public class GenericRepository<Type, Id> : IGenericRepository<Type, Id> where Type : AggregationRoot<Id>
    {
        protected readonly DatabaseContext _databaseContext;
        protected readonly DbSet<Type> _databaseSet;
        public GenericRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
            _databaseSet = _databaseContext.Set<Type>();
        }

        public Type GetById(Id id)
        {
            return _databaseSet.Find(id);
        }

        public async Task<Type> GetByIdAsync(Id id)
        {
            return await _databaseSet.FindAsync(id);
        }

        public List<Type> GetAll(ListParameters<Type> listParameters)
        {
            var query = _databaseSet
                        .AsQueryable()
                        .WhereConditionsQueryBuilder(listParameters.WhereConditions)
                        .PagingQueryBuilder(listParameters.PagingParameters);

            return query.ToList();
        }

        public async Task<List<Type>> GetAllAsync(ListParameters<Type> listParameters)
        {
            var query = _databaseSet
                        .AsQueryable()
                        .WhereConditionsQueryBuilder(listParameters.WhereConditions)
                        .PagingQueryBuilder(listParameters.PagingParameters);

            return await query.ToListAsync();
        }

       

    }
}
