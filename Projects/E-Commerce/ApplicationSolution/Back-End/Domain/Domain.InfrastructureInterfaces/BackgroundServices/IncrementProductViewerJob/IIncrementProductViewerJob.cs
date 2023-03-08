using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.InfrastructureInterfaces.BackgroundServices
{
    public interface IIncrementProductViewerJob
    {
        void Execute(IncrementProductViewerJobParameters Parameters);
    }
}
