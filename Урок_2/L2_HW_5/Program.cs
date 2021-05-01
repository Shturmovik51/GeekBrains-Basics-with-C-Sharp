using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_HW_5
{
    class Program
    {
        #region Task
        /* а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, 
         * нужно ли человеку похудеть, набрать вес или всё в норме.
         * б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
         * Коновалов П.С.
         */
        #endregion

        static void Main(string[] args)
        {
            Console.Write("Введите свой рост (м) ");
            float hight = float.Parse(Console.ReadLine());
            Console.Write("Введите свой вес (кг) ");
            float mass = float.Parse(Console.ReadLine());

            float bodyMassIndex = mass / (hight * hight);
            Console.WriteLine($"Ваш ИМТ = {bodyMassIndex}");

            if(bodyMassIndex < 18.5f)
            {
                Console.WriteLine($"Вам нужно набрать вес");
                Sovet();
            }
            else if (bodyMassIndex >= 18.5 && bodyMassIndex <= 25)
            {
                Console.WriteLine($"Ваш ИМТ в норме");
            }
            else if (bodyMassIndex > 25)
            {
                Console.WriteLine($"Вам нужно похудеть");
                Sovet();
            }

            void Sovet()
            {
                float bestMass = 20 * (hight * hight);
                float neededMass = mass - bestMass;

                if (neededMass > 0)
                    Console.WriteLine($"Вам нужно похудеть в идеале на {Math.Abs(neededMass)} кг");
                else
                    Console.WriteLine($"Вам нужно набрать в идеале {Math.Abs(neededMass)} кг");
            }
        }
    }
}
