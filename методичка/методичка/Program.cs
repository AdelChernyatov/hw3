using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace методичка
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("task 1");
            Console.WriteLine("Введите число от 1 до 365 ");
            int dayofyear = int.Parse(Console.ReadLine());
            int[] months = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            string[] nameofmonth = { "январь", "февраль", "март", "апрель", "май", "июнь", "июль", "август", "сентябрь", "октябрь", "ноябрь", "декабрь", };
            int num = 0;
            while (dayofyear - months[num] > 0)
            {
                dayofyear -= months[num];
                num++;
            }
            Console.WriteLine(dayofyear + " " + nameofmonth[num]);
            //задание 2
            Console.WriteLine("task 2");
            Console.WriteLine("Введите число от 1 до 365 ");
            int num2 = 0;
            int dayinyear = int.Parse(Console.ReadLine());
            if ((dayinyear < 366) && (dayinyear > 0))
            {
                while (dayinyear - months[num2] > 0)
                {
                    dayinyear -= months[num2];
                    num2++;
                }
                Console.WriteLine(dayinyear + " " + nameofmonth[num2]);
            }
            else
            {
                Console.WriteLine("Вы ввели неверное значение");
            }
            Console.WriteLine("task 3");
            Console.WriteLine("Введите год");
            int year = int.Parse(Console.ReadLine());

            if ((dayinyear < 366) & (dayinyear > 0))
            {
                if ((year % 4 == 0 & year % 100 != 0) | (year % 400 == 0))
                {
                    months[1]++;
                    while (dayinyear - months[num2] > 0)
                    {
                        dayinyear -= months[num2];
                        num2++;
                    }
                    Console.WriteLine(dayinyear + " " + nameofmonth[num2]);
                }
                else
                {
                    while (dayinyear - months[num2] > 0)
                    {
                        dayinyear -= months[num2];
                        num2++;
                    }
                    Console.WriteLine(dayinyear + " " + nameofmonth[num2]);
                }
            }
            else
            {
                Console.WriteLine("Вы ввели неверное значение");

            }
        }
    }
}
