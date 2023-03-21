using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RandomDop6.Support;

namespace RandomDop6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "aaaaabb1122ccdd3344eeff";
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];

                if (i > 0 && currentChar == input[i - 1])
                {
                    sb.Append(currentChar);
                }
                else
                {
                    int count = sb.Length;

                    if (count > 1)
                    {
                        string wordForm = GetWordForm(count, "повторение", "повторения", "повторений");
                        Console.WriteLine($"Найдено {count} {wordForm} символа '{sb[0]}'");
                    }

                    sb.Clear();
                    sb.Append(currentChar);
                }
            }

            int finalCount = sb.Length;
            if (finalCount > 1)
            {
                string wordForm = GetWordForm(finalCount, "повторение", "повторения", "повторений");
                Console.WriteLine($"Найдено {finalCount} {wordForm} символа '{sb[0]}'");
            }

            Console.ReadKey();
        }
    }
}
