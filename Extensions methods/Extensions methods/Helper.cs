using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Extensions_methods
{
    


public static class Helper
    {
       
        public static bool IsOdd(this int number)
        {
            return number % 2 != 0;
        }

     
        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }

       
        public static bool HasDigit(this string str)
        {
            return Regex.IsMatch(str, @"\d");
        }
        public static bool CheckPassword(this string password)
        {
            if (string.IsNullOrEmpty(password) || password.Length < 8)
                return false;

            bool hasUpperCase = password.Any(char.IsUpper);
            bool hasLowerCase = password.Any(char.IsLower);
            bool hasDigit = password.Any(char.IsDigit);

            return hasUpperCase && hasLowerCase && hasDigit;
        }





        public static string Capitalize(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return str;

            return char.ToUpper(str[0]) + str.Substring(1).ToLower();
        }
    }

}
