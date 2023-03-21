using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            string names = "Андрей Борис Маша Василий Георгий Денис Юрий";
            string[] namesArray = names.Split(' '); // разбиваем строку на массив строк
            List<string> sortedNames = new List<string>();
            foreach (string name in namesArray)
            {
                if (name.CompareTo("Маша") < 0) // если имя идет перед Машей в алфавитном порядке
                {
                    sortedNames.Add(name); // добавляем в список отсортированных имен
                }
            }
            sortedNames.Sort(); // сортируем список по алфавиту
            foreach (string name in sortedNames)
            {
                Console.WriteLine(name); // выводим имена по одному в столбик
            }
        }
    }
}
