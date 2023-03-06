using Domain.Core.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Core.Products
{
    public class ProductPrice : ValueObject
    {
        public decimal PriceValue { get; private set; }

        public ProductPrice() { }

        public ProductPrice(decimal priceValue)
        {
            PriceValue = priceValue;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            // Using a yield return statement to return each element one at a time
            yield return PriceValue;
        }
    }
}
