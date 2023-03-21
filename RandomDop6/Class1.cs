using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomDop6
{
    internal class Support
    {
        public static string GetWordForm(int count, string one, string two, string many)
        {
            if (count == 1)
            {
                return one;
            }
            if (count >= 2 && count <= 4)
            {
                return two;
            }

            return many;
        }
    }
}
