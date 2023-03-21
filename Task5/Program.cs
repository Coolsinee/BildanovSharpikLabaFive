using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 5
            string sentence = "огромная рыба прыгнула огромная кишмиш опа опа дрипа ципа";
            // Разделить предложение на слова, используя пробел в качестве разделителя.
            string[] words = sentence.Split(' ');
            // Используйте строку для отслеживания слов, которые уже встречались.
            string occurred = "";
            // Используйте строку для построения нового предложения без повторяющихся слов.
            string newSentence = "";
            // Прокручиваем каждое слово в предложении.
            foreach (string word in words)
            {
                // Проверяем, встречалось ли слово до этого.
                if (!occurred.Contains(word))
                {
                    // Если слово не встречалось, добавляем его к появившейся строке и новому предложению.
                    occurred += word + " ";
                    newSentence += word + " ";
                }
            }
            // Показать новое предложение без повторяющихся слов.
            Console.WriteLine(newSentence);
        }
    }
}
