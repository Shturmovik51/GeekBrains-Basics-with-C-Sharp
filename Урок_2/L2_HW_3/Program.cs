using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_HW_3
{
    class Program
    {
        #region Task
        /* С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
         * Коновалов П.С.
         */
        #endregion
        static void Main(string[] args)
        {
            Console.WriteLine("Вводите числа, стопцифра - 0");
            float summOfNumbers = 0;
            float number = 1;

            while (number != 0)
            {
                number = float.Parse(Console.ReadLine());
                Summ(number);
            }

            Console.WriteLine(summOfNumbers);

            void Summ(float a)
            {
                if (a % 2 == 0 || a < 0)
                    return;
                summOfNumbers += number;
            }
        }
    }
}
