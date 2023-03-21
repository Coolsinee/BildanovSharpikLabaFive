using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RandomDop4
{
    internal class Support
    {
        public static string[] GetSentences(string input)
        {
            Regex regex = new Regex(@"(?<=[.?!])\s+");
            return regex.Split(input.Trim());
        }
    }
}
