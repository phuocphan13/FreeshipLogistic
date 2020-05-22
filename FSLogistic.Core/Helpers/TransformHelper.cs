using System;
using System.Collections.Generic;
using System.Text;

namespace FSLogistic.Core.Helpers
{
    public static class TransformHelper
    {
        public static string TimeIntToString(int time)
        {
            var hours = time / 60;
            var minutes = time - hours * 60;

            var stringHour = hours.ToString();
            var stringMinute = minutes < 10 ? $"0{minutes.ToString()}" : minutes.ToString();

            return $"{stringHour} hr {stringMinute} min";
        }


        public static string ConvertPhoneNumber(decimal? phoneNumber)
        {
            if (phoneNumber.HasValue)
            {
                return $"0{phoneNumber}";
            }
            return "";
        }

        public static string ConvertDatetimeToString(DateTime? data)
        {
            if (!data.HasValue)
            {
                return "";
            }
            var day = data.Value.Day < 10 ? $"0{data.Value.Day}" : $"{data.Value.Day}";
            var month = data.Value.Month < 10 ? $"0{data.Value.Month}" : $"{data.Value.Month}";
            return $"{day}-{month}-{data.Value.Year}";
        }
    }
}
