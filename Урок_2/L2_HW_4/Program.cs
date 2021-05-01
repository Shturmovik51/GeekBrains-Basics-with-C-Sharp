using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_HW_4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task
            /* Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. 
             * На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
             * Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, 
             * программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля 
             * тремя попытками.
             * Коновалов П.С.
             */
            #endregion

            int countOfTries = 3;

            do
            {
                Console.WriteLine("Введите Логин");
                string log = Console.ReadLine();
                Console.WriteLine("Введите Пароль");
                string pas = Console.ReadLine();
                
                ComparePassLog(log, pas);
            }
            while (countOfTries != 0);
                 
            void ComparePassLog(string log1, string pas1)
            {
                if (log1.CompareTo("root") == 0 && pas1.CompareTo("GeekBrains") == 0)
                {
                    Console.WriteLine("\n Вы авторизированы, продолжайте работу \n");
                    countOfTries = 0;
                }
                else
                {
                    countOfTries--;
                    if (countOfTries != 0)  
                        Console.WriteLine($"\n Попробуйте еще раз, у вас осталось {countOfTries} попыток \n");
                    else
                        Console.WriteLine("\n Пашоль Нафик \n");
                }
                    
            }

        }
    }
}
