using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FSLogistic.Core.UoW
{
    public class UnitOfWorkBase<TContext> : IUnitOfWork where TContext : DbContext
    {
        private readonly TContext _gmcContext;
        private readonly ILogger _logger;

        public UnitOfWorkBase(TContext gmcContext, ILogger<UnitOfWorkBase<TContext>> logger)
        {
            _gmcContext = gmcContext;
            _logger = logger;
        }

        public bool SaveChanges()
        {
            try
            {
                return _gmcContext.SaveChanges() > 0;
            }
            catch (DbUpdateConcurrencyException e)
            {
                _logger.LogError("Some errors happen while committing", e);
                throw;
                //throw new AppException(e.Message, e);
            }
        }

        public async Task<bool> SaveChangesAsync()
        {
            try
            {
                return await _gmcContext.SaveChangesAsync() > 0;
            }
            catch (DbUpdateConcurrencyException e)
            {
                _logger.LogError("Some errors happen while committing", e);
                throw;
                //throw new AppException(e.Message, e);
            }
        }
    }
}
