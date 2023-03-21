using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RandomDop3.Support;

namespace RandomDop3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string input = Console.ReadLine();
            string result = CountOccurrences(input);
            Console.WriteLine(result);
        }
    }
}
