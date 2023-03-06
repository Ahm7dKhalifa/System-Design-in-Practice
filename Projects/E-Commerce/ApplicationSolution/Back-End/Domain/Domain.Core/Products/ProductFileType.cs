using Domain.Core.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Core.Products
{
    public class ProductFileType : EntityFullAudit<int>
    {
        public string FileTypeName { get; private set; }
    }
}
