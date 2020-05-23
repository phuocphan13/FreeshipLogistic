using FSLogistic.Core.Repositories;
using FSLogistic.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSLogistic.Domain.Repositories
{
    public class Repository<TEntity> : RepositoryBase<TEntity, FreeShipLogisticResourceContext>
        where TEntity : class
    {
        public Repository(FreeShipLogisticResourceContext context) : base(context)
        {
        }
    }
}
