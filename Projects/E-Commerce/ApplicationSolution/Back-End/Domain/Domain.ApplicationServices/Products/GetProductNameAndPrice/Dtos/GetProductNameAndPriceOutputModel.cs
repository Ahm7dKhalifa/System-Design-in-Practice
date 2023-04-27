using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ApplicationServices.Products.GetProductNameAndPrice.Dtos
{
    public class GetProductNameAndPriceOutputModel
    {
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
    }
}
