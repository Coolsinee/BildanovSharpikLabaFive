using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 6
            Console.WriteLine("Введите строки (пустая строка - конец ввода):");
            // Создаем StringBuilder для формирования итогового текста
            StringBuilder result = new StringBuilder();
            // Цикл для ввода строк
            while (true)
            {
                string input = Console.ReadLine();
                // Если пользователь ввел пустую строку - завершаем ввод
                if (string.IsNullOrEmpty(input))
                {
                    break;
                }
                // Добавляем точку в конец строки
                input += ".";
                // Разбиваем строку на слова, используя пробел в качестве разделителя
                string[] words = input.Split(' ');
                // Индекс для обработки слов в строке
                int index = 0;
                // Обрабатываем каждое слово в строке
                foreach (string word in words)
                {
                    // Если слово не пустое, обрабатываем его
                    if (!string.IsNullOrEmpty(word))
                    {
                        // Добавляем первое слово без изменений
                        if (index == 0)
                        {
                            result.Append(word);
                        }
                        // Добавляем второе слово в обратном порядке
                        else if (index == 1)
                        {
                            char[] letters = word.ToCharArray();
                            Array.Reverse(letters);
                            result.Append(new string(letters));
                        }
                        // Увеличиваем индекс, чтобы пропустить третье слово и так далее
                        index++;
                        // Если индекс больше или равен количеству слов в строке, сбрасываем его
                        if (index >= words.Length)
                        {
                            index = 0;
                        }
                        // Добавляем пробел после каждого слова (кроме последнего)
                        if (index != 0 && index != words.Length - 1)
                        {
                            result.Append(" ");
                        }
                    }
                }
            }

            // Выводим итоговый текст
            Console.WriteLine(result.ToString());
        }
    }
}
