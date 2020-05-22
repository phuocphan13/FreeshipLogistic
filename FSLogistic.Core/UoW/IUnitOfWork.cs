using System;
using System.Collections.Generic;
using System.Text;

namespace FSLogistic.Core.UoW
{
    public interface IUnitOfWork
    {
        bool SaveChanges();
    }
}
