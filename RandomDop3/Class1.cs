using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomDop3
{
    internal class Support
    {
        public static string CountOccurrences(string input)
        {
            StringBuilder output = new StringBuilder();
            // Перебрать каждый символ во входной строке.
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                int count = 1;

                // Проверяем, был ли уже подсчитан символ. Если это так, перейдите к следующему символу.
                if (output.ToString().IndexOf(c) != -1)
                {
                    continue;
                }

                // Перебрать оставшуюся часть входной строки, подсчитывая каждое вхождение текущего символа.
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[j] == c)
                    {
                        count++;
                    }
                }

                // Добавляем символ и его количество к выходу StringBuilder.
                output.Append($"{c}: {count}\n");
            }

            return output.ToString();
        }
    }
}
