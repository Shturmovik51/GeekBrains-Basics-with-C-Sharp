using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1_Task_5
{
    class Program
    {
        #region Task
        /* а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
         * б) Сделать задание, только вывод организовать в центре экрана.
         * Коновалов П.С.
         */
        #endregion
        static void Main(string[] args)
        {
            List<string> strings = new List<string>();

            Console.Write("Введите имя ");
            strings.Add(Console.ReadLine());
            Console.Write("Введите фамилию ");
            strings.Add(Console.ReadLine());
            Console.Write("Введите город проживания ");
            strings.Add(Console.ReadLine());
            
            foreach (string str in strings)
            {
                var x = Console.CursorTop;
                Console.SetCursorPosition(Console.WindowWidth / 2 - str.Length / 2, x);
                Console.WriteLine(str);
            }

        }
    }
}
