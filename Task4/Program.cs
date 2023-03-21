using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Task4.Support;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Огромный дед прыгнул щучкой";
            string[] words = sentence.Split(' ');
            string longestWord = string.Empty;
            string shortestWord = words[0];
            // Находим самое длинное и самое короткое слово
            foreach (string word in words)
            {
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }

                if (word.Length < shortestWord.Length)
                {
                    shortestWord = word;
                }
            }

            // Создаем строку, в которой слова повторяются столько раз, сколько в них символов
            string repeatedWords = RepeatWord(longestWord) + ", " + RepeatWord(shortestWord);

            Console.WriteLine("Самое длинное слово: " + longestWord);
            Console.WriteLine("Самое короткое слово: " + shortestWord);
            Console.WriteLine("Повторяемые слова: " + repeatedWords);
        }
    }
}
