using Domain.Core.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Core.Products
{
    public class ProductAttribute : EntityFullAudit<long>
    {
        public long ProductId { get; private set; }
        public string Name { get; private set; }
        public string Value { get; private set; }
        public Product Product { get; private set; }

    }
}
