using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_HW_1
{
    class Program
    {
        #region Task
        /* Написать метод, возвращающий минимальное из трёх чисел.
         * Коновалов П.С.
         */
        #endregion
        static void Main(string[] args)
        {
            Console.Write("Введите первое число ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Введите второе число ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("Введите третье число ");
            float c = float.Parse(Console.ReadLine());
            
            Console.WriteLine($"Минимальное число {MinNuber(a,b,c)}");
            
            float MinNuber(float a1, float b1, float c1)
            {
                if (a1 < b1 && a1 < c1)
                {
                    return a1;
                }
                else if (b1 < c1)
                {
                    return b1;
                }
                else return c1;
            }
        }                
    }
}
