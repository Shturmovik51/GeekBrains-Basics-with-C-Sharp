using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1_Task_2
{
    class Program
    {
        #region Task
        /* Ввести вес и рост человека. Рассчитать и вывести индекс массы тела(ИМТ) по формуле I=m/(h* h);
         * где m — масса тела в килограммах, h — рост в метрах.
         * Коновалов П.С.
         */
        #endregion
        static void Main(string[] args)
        {
            Console.Write("Введите массу (кг) ");
            float m = float.Parse(Console.ReadLine());
            Console.Write("Введите рост (м) ");
            float h = float.Parse(Console.ReadLine());
            

            Console.WriteLine($"Индекс массы: {IndexMassy(m,h)}");
        }

        static float IndexMassy(float a, float b)
        {
            return a / (b * b);
        }
    }
}
