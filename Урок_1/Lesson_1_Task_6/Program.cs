using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1_Task_6
{
    #region Task
    /* 6. *Создать класс с методами, которые могут пригодиться в вашей учебе
     * Коновалов П.С.
     */
    #endregion
    class Program : Barny
    {
        static void Main(string[] args)
        {
            SlapFace();
        }
    }

    class Barny
    {
        public static void SlapFace()
        {
            Console.WriteLine("Вам дали ободряющую пощечину =)");
        }

    }
}
