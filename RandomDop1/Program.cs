using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RandomDop1.Support;

namespace RandomDop1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите какой-то текст:");
            string input = Console.ReadLine();
            Console.Write("Введите максимальную длину слова: ");
            int maxLength = int.Parse(Console.ReadLine());
            int count = CountWordsOfMaxLength(input, maxLength);
            Console.WriteLine($"В тексте {count} слова, с максимальной длинной слова {maxLength}.");
        }
    }
}
