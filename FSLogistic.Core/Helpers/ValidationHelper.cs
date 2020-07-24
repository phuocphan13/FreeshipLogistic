using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;
using System.Reflection;
using Microsoft.Extensions.Caching.Memory;

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

        public static bool ValidationForName(string data)
        {
            var regularExpression = @"^[a-zA-Z aàảãáạăằẳẵắặâầẩẫấậbcdđĐeèẻẽéẹêềểễếệfghiìỉĩíịjklmnoòỏõóọôồổỗốộơờởỡớợpqrstuùủũúụưừửữứựvwxyỳỷỹýỵz]+$";
            var r = new Regex(regularExpression);
            return r.IsMatch(data);
        }

        public static bool ValidationForCode(string data)
        {
            var regularExpression = @"^[a-zA-Z0-9-_]+$";
            var r = new Regex(regularExpression);
            return r.IsMatch(data);
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

        public static bool CheckNullObject<T>(T data) where T : class
        {
            foreach (PropertyInfo propertyInfo in data.GetType().GetProperties())
            {
                if (propertyInfo.GetValue(data, null) == null)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool CheckNumberObject(object data)
        {
            foreach (PropertyInfo propertyInfo in data.GetType().GetProperties())
            {
                var propertyValue = propertyInfo.GetValue(data).ToString();
                var regularExpression = @"^[0-9]*$";
                var r = new Regex(regularExpression);
                var isMatched = r.IsMatch(propertyValue);
                if (!isMatched)
                    return false;
            }
            return true;
        }
    }
}
