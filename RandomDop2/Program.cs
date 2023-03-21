using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RandomDop2.Support;

namespace RandomDop2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите какой-то текст:");
            string input = Console.ReadLine();
            string longestWord = FindLongestWord(input);
            int count = CountOccurrences(input, longestWord);
            Console.WriteLine($"Самое длинное слово - '{longestWord}', появлений в тексте - {count}");
        }
    }
}
