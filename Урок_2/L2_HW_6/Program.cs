using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_HW_6
{
    class Program
    {
        #region Task
        /* Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000.
         * «Хорошим» называется число, которое делится на сумму своих цифр. Реализовать подсчёт времени 
         * выполнения программы, используя структуру DateTime.
         * Коновалов П.С.
         */
        #endregion

        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;
            int count = 0;
          
            Console.WriteLine("Нажмите ENTER для старта программы");
            Console.ReadLine();

            for (int i = 1; i < 1000000000; i++)
                Division(i);
            DateTime finish = DateTime.Now;
            Console.WriteLine($"количество 'хороших' чисел = {count}, программа пыполнялась {finish-start} сек");
            

            void Division(int number)
            {
                int summ = 0;
                int storedNumber = number;
                while(number >= 1)
                {
                    int digit = number % 10;
                    summ += digit;
                    number = number / 10;
                }
                if (storedNumber % summ == 0)
                    count++;
            }
        }
    }
}
