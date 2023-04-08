using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Core.Products
{
    public class ProductSholudBeOfGoldCategory
    {
        public static Expression<Func<Product, bool>> Expression()
        {
            Expression<Func<Product, bool>> isProductOfGoldCategory = (product) => 
                                                                       product.TotalCountOfLikes >= 100
                                                                    && product.TotalCountOfViewers >= 1000
                                                                    && product.TotalNumberOfOrders >= 200
                                                                    && product.TotalMoneyOfSales >= 5000
                                                                    && product.Rate >= 4.5;

            return isProductOfGoldCategory;
        }

    }
}
