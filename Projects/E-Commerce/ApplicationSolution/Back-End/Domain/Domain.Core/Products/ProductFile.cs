using Domain.Core.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Core.Products
{
    public class ProductFile : EntityFullAudit<long>
    {
        public long ProductId { get; private set; }
        public int ProductFileTypeId { get; private set; }
        public string FileName { get; private set; }
        public Product Product { get; private set; }
        public ProductFileType ProductFileType {get; private set; }
    }
}
