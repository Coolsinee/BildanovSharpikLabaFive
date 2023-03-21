using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RandomDop4.Support;

namespace RandomDop4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");
            string input = Console.ReadLine();
            string[] sentences = GetSentences(input);
            Array.Sort(sentences, (s1, s2) => s2.Length.CompareTo(s1.Length));
            foreach (string sentence in sentences)
            {
                Console.WriteLine(sentence);
            }
        }
    }
}
