using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    internal class Suppik
    {
        public static string RearrangeWords(string input)
        {
            StringBuilder result = new StringBuilder();
            string[] words = input.Split(' ');

            // Начинаем с первого слова и добавляем его к результату.
            string currentWord = words[0];
            result.Append(currentWord);
            result.Append(' ');

            // Прокручиваем оставшиеся слова, находя то, которое начинается с той же буквы, что и предыдущее слово.
            // Если найдено, добавляем его к результату и повторяем со следующим словом.
            // Если не найдено, начинаем с первого слова.
            bool foundMatch;
            do
            {
                foundMatch = false;
                char lastLetter = char.ToLower(currentWord[currentWord.Length - 1]);
                foreach (string word in words)
                {
                    if (char.ToLower(word[0]) == lastLetter && !result.ToString().Contains(word))
                    {
                        result.Append(word);
                        result.Append(' ');
                        currentWord = word;
                        foundMatch = true;
                        break;
                    }
                }
                if (!foundMatch && !result.ToString().Contains(words[0]))
                {
                    result.Append(words[0]);
                    result.Append(' ');
                    currentWord = words[0];
                    foundMatch = true;
                }
            } while (foundMatch);

            // Удалить последний пробел из результата и вернуть его.
            return result.ToString().TrimEnd();
        }
    }
}
