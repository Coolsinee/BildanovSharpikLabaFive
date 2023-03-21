using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 3
            Console.Write("Введите текст: ");
            string input = Console.ReadLine();
            Console.Write("Введите число символов n: ");
            int n = int.Parse(Console.ReadLine());
            string output = "";

            for (int i = 0; i < input.Length; i++)
            {
                output += input[i];
                if ((i + 1) % n == 0)
                {
                    output += Convert.ToChar("\u263A");
                }
            }
            Console.WriteLine("Результат: " + output);
        }
    }
}
