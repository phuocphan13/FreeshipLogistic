using FSLogistic.Core.UoW;
using FSLogistic.Domain.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSLogistic.Domain.UoW
{
    public class UnitOfWork : UnitOfWorkBase<FreeShipLogisticResourceContext>
    {
        public UnitOfWork(FreeShipLogisticResourceContext gmcContext, ILogger<UnitOfWork> logger) : base(gmcContext, logger)
        {
        }
    }
}
