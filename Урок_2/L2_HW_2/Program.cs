using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_HW_2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task
            /* Написать метод подсчета количества цифр числа.
             * Коновалов П.С.
             */
            #endregion

            Console.Write("Введите любое число ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine($"Количество цифр в числе = {NumberOfDigits(number)}");

            int NumberOfDigits(int a)
            {
                if (a != 0)
                {
                    int count = 0;
                    while (a != 0)
                    {
                        count++;
                        a = a / 10;
                    }
                    return count;
                }
                else
                    return 1;
            }
        }
    }
}
