using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.ClassesDemo.Utils
{
    public static class PersonHelper
    {
        public static  string GenerateINumber(string prefix)
        {
            // Implementation for generating ID number
            var randomNumber = RandomNumberGenerator
                .GetInt32(100000, 999999)
                .ToString();
            return $"{prefix}-{randomNumber}";

        }
    }
}
