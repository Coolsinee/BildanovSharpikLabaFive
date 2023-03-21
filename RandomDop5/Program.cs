using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomDop5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder(input);
            string[] words = { "ноль", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };
            for (int i = 0; i < words.Length; i++)
            {
                sb.Replace(words[i], i.ToString());
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
