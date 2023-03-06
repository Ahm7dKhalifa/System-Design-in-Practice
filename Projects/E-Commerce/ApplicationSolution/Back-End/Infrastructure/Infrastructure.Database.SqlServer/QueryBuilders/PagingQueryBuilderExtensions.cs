using Domain.InfrastructureInterfaces.Databases.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Database.SqlServer.QueryBuilders
{
    public static class PagingQueryBuilderExtensions
    {
        public static IQueryable<Type> PagingQueryBuilder<Type>(this IQueryable<Type> query, PagingParameters pagingParameters)
        {
            if (query != null && pagingParameters != null)
            {
                query = query
                        .Skip((pagingParameters.PageNumber - 1) * pagingParameters.PageSize)
                        .Take(pagingParameters.PageSize);
            }

            return query;
        }
    }
}
