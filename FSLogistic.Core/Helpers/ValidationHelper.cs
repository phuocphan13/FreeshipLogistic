using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

namespace FSLogistic.Core.Helpers
{
    public static class ValidationHelper
    {
        public static bool CheckExisted<T>(T value, IEnumerable<T> listChecking)
        {
            return listChecking.Any(x => x.Equals(value));
        }

        public static bool CheckNullForString(string data)
        {
            if (data == null || data.Trim() == "")
            {
                return false;
            }
            return true;
        }

        public static bool ValidationForNumber(string data)
        {
            var isNumber = decimal.TryParse(data, out decimal result);
            if (isNumber)
            {
                var regularExpression = @"^[0-9]*$";
                var r = new Regex(regularExpression);
                return r.IsMatch(data);
            }
            return false;
        }
    }


}
