using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 2
            string input = "Я люблю шиши и пиши прикол шоли.";
            string[] words = input.Split(' '); // разбиваем строку на массив слов
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length == 4) // если слово содержит 4 символа
                {
                    words[i] = "love_Is"; // заменяем его на "love_Is"
                }
            }
            string output = string.Join(" ", words); // объединяем массив слов в строку с пробелами
            Console.WriteLine(output);
        }
    }
}
