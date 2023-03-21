using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Task7.Suppik;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "Обезьяна апельсин нашатырь робот шишка";
            Console.WriteLine(RearrangeWords(input));
        }
    }
}
