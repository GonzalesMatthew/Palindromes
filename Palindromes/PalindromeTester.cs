using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Palindromes
{
    public class PalindromeTester
    {
        public bool Test(string stringToTest)
        {
            
            string str = Regex.Replace(stringToTest.ToLower(), @"\s", "");
            str = Regex.Replace(str, @"[^0-9a-zA-Z]+", "");
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);

            if (new string(charArray) == str)
            {
                return true;
            }
            return false;
        }
    }
}
