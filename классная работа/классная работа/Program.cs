using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace классная_работа
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("task1");
            Console.WriteLine("Введите трехзначное число");
            int entered_number = int.Parse(Console.ReadLine());
            if ((entered_number > 99) && (entered_number < 999))
            {
                int hundreds = entered_number / 100;
                int units = entered_number % 10;
                if (units == hundreds)
                {
                    Console.WriteLine("Число " + entered_number + " является полиндромом");
                }
                else
                {
                    Console.WriteLine("Число " + entered_number + " не является полиндромом");
                }
            }
            else
            {
                Console.WriteLine("Вы ввели не трехзначное число");

            } //задание 2
            Console.WriteLine("task2");
            Console.WriteLine("Введите ширину форточки");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите длину форточки");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите диаметр головы");
            int d = int.Parse(Console.ReadLine());
             if ((b - d >= 1) && (a - d >= 1))
             {
                Console.WriteLine("Голова Васи влезет");
             }
             else
             {
                Console.WriteLine("Голова Васи не влезет");
             }
                //задание 3
             Console.WriteLine("task3");
             string[] dayofweeks = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };
             int numberday = int.Parse(Console.ReadLine());
             Console.WriteLine(dayofweeks[numberday - 1]);
            // 4 task
            Console.WriteLine("task4");
            try
            {
                string[] gamecards = { "шестерка", "семерка", "восьмерка", "девятка", "десятка", "валет", "дама", "король", "туз" };
                Console.WriteLine("Введите число от 6 до 14");
                int enternumber = int.Parse(Console.ReadLine());
                string cards = gamecards[enternumber - 6];
                Console.WriteLine(cards);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Возникло исключение");
            }
            //задание 5
            Console.WriteLine("task5");
            int radius = 6370;
            Console.WriteLine("Введите высоту от 1 до 10 км");
            byte height = byte.Parse(Console.ReadLine());
            if ((height > 0) && (height < 10))
            {
               double gorizont = Math.Sqrt((radius + height) * (radius + height) - radius * radius);
               Console.WriteLine("Расстояние до линии горизонта " + Math.Round(gorizont,2));
            }
            else
            {
              Console.WriteLine("Введите число от 1 до 10");
            } 
           //задание 6
            Console.WriteLine("task6");
            Console.WriteLine("Введите число от 1 до 9");
            int n = int.Parse(Console.ReadLine());
            int[] tablenumber = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for (int i = 0; i < tablenumber.Length; i++)
            {
                Console.Write(tablenumber[i]*n+" " );
            } 
            //задание 7
            Console.WriteLine("task7");
            int[] posledovatelnost = { 11, 9, 7, 5, 3, 1, -1 };
            int[] positive = Array.FindAll(posledovatelnost, i => i >= 0);
            int average = (positive.Sum()/(positive.Length));
            Console.WriteLine("Среднее арифметическое положительных элементов массива " + average);
            //задание 8
             Console.WriteLine("task 8");
             int[] sequence =new int [10];
             int j = 1;
             int number = sequence[0];
             Console.WriteLine("Введите элементы последовательности из 10 чисел");
             for (int i = 0; i < sequence.Length; i++)
             {
                 sequence[i] = int.Parse(Console.ReadLine());

             };
             for(;j<sequence.Length;j++)
             {
                 if (sequence[j] <= number)
                     break;
                 number = sequence[j];               
             }
             Console.WriteLine(j);
            //задания 9
            Console.WriteLine("task9");
            Console.WriteLine("Введите кол-во элементов массива");
            int element = int.Parse(Console.ReadLine());
            int[] sequence9 = new int [element];
            sequence9[element-1] = 0;
            int sum = 0;
            for(int i =0;i<(element-1);i++)
            {
                sequence9[i] = int.Parse(Console.ReadLine());
            }
            for (int h = 0; h<n; h++)
            {
                if (!(h % 3 == 2))
                    continue;
                sum+= sequence9[h];
            }
            Console.WriteLine("Сумма элементов индексы которых кратных трем индексов "+sum);
            
            // задание 10
            Console.WriteLine("task10");
            //из задания 9 берем последовательность
            int sumequence = 0;
            for (int i = 0; i < (element - 1); i++)
            {
                while (sequence9[i] != sequence9[element - 1])
                {
                    goto sum;
                }
                sum:
                 sumequence += sequence9[i];
            }
            Console.WriteLine("Сумма элементов последовательности " + sumequence);
            
            




        }
    }
}

