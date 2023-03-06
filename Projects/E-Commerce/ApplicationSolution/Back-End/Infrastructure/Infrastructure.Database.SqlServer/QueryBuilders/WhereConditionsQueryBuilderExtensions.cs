using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Database.SqlServer.QueryBuilders
{
    public static class WhereConditionsQueryBuilderExtensions
    {
        public static IQueryable<Type> WhereConditionsQueryBuilder<Type>(this IQueryable<Type> query, List<Expression<Func<Type, bool>>> whereConditions)
        {
            if (whereConditions != null)
            {
                foreach (var where in whereConditions)
                {
                    query = query.Where(where);
                }
            }
            return query;
        }
    }
}
