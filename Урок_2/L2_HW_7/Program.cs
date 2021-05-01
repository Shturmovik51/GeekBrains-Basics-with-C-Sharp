using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_HW_7
{
    class Program
    {
        #region Task
        /* a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
         * б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
         * Коновалов П.С.
         */
        #endregion

        static void Main(string[] args)
        {
            Console.Write("Введите число a ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите число b ");
            int b = int.Parse(Console.ReadLine());
            int count = 0;
            int summ = 0;

            Numbers(a, b);

            void Numbers(int a1, int b1)
            {
                if (a1 <= b1)
                {
                    Console.Write("{0,4}", a1);
                    summ += a1;
                    a1++;
                    count++;

                    if (count == 10)
                    {
                        Console.WriteLine();
                        count = 0;
                    }

                    Numbers(a1, b1);
                }
                else
                    Console.WriteLine($"\n\nСумма чисел = {summ}");
            }
        }
    }
}
