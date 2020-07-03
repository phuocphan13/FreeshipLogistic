using System;
using System.Collections.Generic;
using System.Linq;

namespace FSLogistic.Core.Helpers
{
    public class GenerateCodeHelper : IDisposable
    {
        public GenerateCodeHelper()
        {
        }

        public string GenerateCode(string firstName, string lastName, IEnumerable<string> listCodes)
        {
            var code = $"{firstName.ToUpper()}{lastName.Substring(2).ToUpper()}";
            bool firstCheck = true;
            while(listCodes.Any(x => x == code))
            {
                if(firstCheck)
                {
                    code += "1";
                    firstCheck = false;
                }
                else
                {
                    var count = int.Parse(code.Substring(code.Length - 1, 1)) + 1;
                    code += count.ToString();
                }
            }

            return code;
        }

        public void Dispose()
        {
        }
    }
}
