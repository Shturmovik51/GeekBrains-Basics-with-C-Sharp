using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1_Task_3
{
    class Program
    {
        #region Task
        /* а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 
         * по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, используя спецификатор 
         * формата .2f (с двумя знаками после запятой);
         * б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
         * Коновалов П.С.
         */
        #endregion
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты точки А ");
            Console.Write("x1 = ");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("y1 = ");
            int y1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите координаты точки B ");
            Console.Write("x2 = ");
            int x2 = int.Parse(Console.ReadLine());
            Console.Write("y2 = ");
            int y2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Расстояние между точками А и В = {Length(x1, x2, y1, y2):F2}");
        }
        static double Length(int x1, int x2, int y1, int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}
