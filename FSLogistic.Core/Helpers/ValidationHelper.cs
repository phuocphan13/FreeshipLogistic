using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace FSLogistic.Core.Helpers
{
    public static class ValidationHelper
    {
        public static bool CheckExisted<T>(T value, IEnumerable<T> listChecking)
        {
            return listChecking.Any(x => x.Equals(value));
        }
    }
}
