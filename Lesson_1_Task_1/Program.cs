using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("А Н К Е Т А \n");
            Console.Write("Имя  ");
            string name = Console.ReadLine();
            Console.Write("Фамилия  ");
            string surName = Console.ReadLine();
            Console.Write("Возраст  ");
            string age = Console.ReadLine();
            Console.Write("Рост  ");
            string hight = Console.ReadLine();
            Console.Write("Вес  ");
            string weight = Console.ReadLine();


            Console.WriteLine("Вас зовут: " + name + " " + surName + ", Ваши ТТХ: возраст - " + age + ", рост - " + hight +
                                                ", вес - " + weight);

            Console.WriteLine(string.Format("Вас зовут: {0} {1}, Ваши ТТХ: возраст - {2}, рост - {3}, вес - {4}",
                                                name, surName, age, hight, weight));

            Console.WriteLine($"Вас зовут: {name} {surName}, Ваши ТТХ: возраст - {age}, рост - {hight}, вес - {weight}");
        }
    }
}
