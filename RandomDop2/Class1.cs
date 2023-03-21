using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomDop2
{
    internal class Support
    {
        public static string FindLongestWord(string input)
        {
            StringBuilder currentWord = new StringBuilder();
            string longestWord = "";
            // Перебираем каждый символ во входной строке.
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                // Если текущий символ является символом пробела, проверьте, не длиннее ли текущее слово,
                // чем самое длинное слово, найденное до сих пор.
                // Если это так, установите его как новое самое длинное слово.
                if (char.IsWhiteSpace(c))
                {
                    if (currentWord.Length > longestWord.Length)
                    {
                        longestWord = currentWord.ToString();
                    }
                    currentWord.Clear();
                }
                // Если текущий символ является буквой или цифрой, добавляем его в currentWord StringBuilder.
                else if (char.IsLetterOrDigit(c))
                {
                    currentWord.Append(c);
                }
            }
            // Проверяем последнее слово во входной строке (после него не может быть пробела).
            if (currentWord.Length > longestWord.Length)
            {
                longestWord = currentWord.ToString();
            }

            return longestWord;
        }
        public static int CountOccurrences(string input, string word)
        {
            int count = 0;
            int index = 0;

            // Перебираем входную строку, находя каждое вхождение слова и увеличивая переменную count.
            while ((index = input.IndexOf(word, index, StringComparison.OrdinalIgnoreCase)) != -1)
            {
                count++;
                index += word.Length;
            }
            return count;
        }
    }
}
