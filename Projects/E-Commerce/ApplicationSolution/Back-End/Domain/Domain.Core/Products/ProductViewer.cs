using Domain.Core.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Core.Products
{
    public class ProductViewer : EntityFullAudit<long>
    {
        public long ProductId { get; private set; }
        public long? UserId { get; private set; }
        public Product Product { get; private set; }
    }
}
