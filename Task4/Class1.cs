using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Support
    {
        // Метод, который повторяет слово столько раз, сколько в нем символов
        public static string RepeatWord(string word)
        {
            string repeatedWord = string.Empty;

            for (int i = 0; i < word.Length; i++)
            {
                repeatedWord += word;
            }

            return repeatedWord;
        }
    }
}
