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
        public string Test(string stringToTest)
        {
            string str = Regex.Replace(stringToTest.ToLower(), @"\s", "");
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
