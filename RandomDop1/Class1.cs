using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomDop1
{
    internal class Support
    {
        public static int CountWordsOfMaxLength(string input, int maxLength)
        {
            StringBuilder currentWord = new StringBuilder();
            int count = 0;
            // Перебираем каждый символ во входной строке.
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                // Если текущий символ является символом пробела, добавляем текущее слово к счетчику,
                // если оно не длиннее maxLength, и сбрасываем currentWord StringBuilder для следующего слова.
                if (char.IsWhiteSpace(c))
                {
                    if (currentWord.Length <= maxLength)
                    {
                        count++;
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
            if (currentWord.Length <= maxLength)
            {
                count++;
            }

            return count;
        }
    }
}
