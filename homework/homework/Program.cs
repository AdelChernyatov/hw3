using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
   
    class Program
    {
        public static string Sizes()
        {
            Console.WriteLine("task3");
            Console.WriteLine("Введите название животного");
            string names = Console.ReadLine();
            string mouthSize1 = "small";
            string mouthSize2 = "wide";
            if (names == "аллигатор")
            {
                return mouthSize1;      // задание 3
            }
            else
            {
                return mouthSize2;
            }
        }
        public static void Main(string[] args)
        { //1.1
            Console.WriteLine("task 1.1");
            Console.WriteLine("Введите число ");
            double enternumber = double.Parse(Console.ReadLine());
            double[] myarray = { enternumber, (-1) * enternumber };
            for (int i = 0; i < myarray.Length; i++)
            {
                if (myarray[i] >= 0)
                {
                    Console.WriteLine("Абсолютная величина " + myarray[i]);
                }
            }
            //задание1.2
            Console.WriteLine("task1.2");
            Console.WriteLine("Введите второе число");
            double enternum = double.Parse(Console.ReadLine());
            if (Math.Abs(enternumber) > Math.Abs(enternum))
            {
                Console.WriteLine(enternumber / 2);
            }
            else
            {
                Console.WriteLine("Второе число больше или равно первого в абсолютном значении");
            }
            //задание 1.3
            string size = Sizes();
            Console.WriteLine(size);
            //задание1.4
            Console.WriteLine("task 1.4");
            Console.WriteLine("Введите название напитка");
            string drink = Console.ReadLine();
            string lowdrink = drink.ToLower();
            switch (lowdrink)
            {
                case "jabroni":
                    Console.WriteLine("Patron Tequila");
                    break;
                case "school counselor":
                    Console.WriteLine("Anything with Alcohol");
                    break;
                case "programmer":
                    Console.WriteLine("Hipster Craft Beer");
                    break;
                case "bike gang member":
                    Console.WriteLine("Moonshine");
                    break;
                case "politician":
                    Console.WriteLine("Your tax dollars");
                    break;
                case "rapper":
                    Console.WriteLine("Cristal");
                    break;
                default:
                    Console.WriteLine("Beer");
                    break;
            }   
            //1.5
            Console.WriteLine("task 1.5");          
            Console.WriteLine("Ввести строку");
            string symbols = Console.ReadLine();
            string lowersymbols = symbols.ToLower();
            bool strenglish = lowersymbols.Contains("english");
            Console.WriteLine("English в строке: " + strenglish);
            //2.1
            Console.WriteLine("task2.1");
            double summ = 1;
            double summand = 3;
            for (int i = 1; i <= 8; i++)
            {
                for (int j = 0; j <= i - 1; j++)
                    summand *= 3;
                summ += 1 / summand;
                summand = 3;
            }
            Console.WriteLine(summ);

            // 2.2
            Console.WriteLine("Упражнение 2.2");
            double n = 2;
            double distance = 1;
            double distancetohome = 1;
            while (n <= 100)
            {
                double partway = 1 / n;
                double new_distance = 1 / (n - 1);
                distance += partway * new_distance;
                if (n % 2 == 0)
                {
                    distancetohome -= partway * new_distance;
                }
                else
                {
                    distancetohome += partway * new_distance;
                }
                n += 1;
            }
            Console.WriteLine(distancetohome);
            Console.WriteLine(distance);
            // 2.3
            Console.WriteLine("Упражнение 2.3");
            int[] january = new int[31];
            int[] march = new int[31];
            Random random = new Random();
            for (int i = 0; i < 31; i++)
            {
                january[i] = random.Next(1000);
            }
            for (int j = 0; j < 31; j++)
            {
                march[j] = random.Next(1000);
            }
            Console.WriteLine("Среднедневное количество осадков за январь: " + january.Sum() / january.Length);
            Console.WriteLine("Среднедневное количество осадков за март: " + march.Sum() / march.Length);
            //3.1
            Console.WriteLine("ex 3.1");
            double nominator1 = 1;
            double denominator1 = 1;
            double nominator2 = 2;
            double denominator2 = 1;
            double dissapear;
            while (Math.Abs((nominator1 / denominator1) - (nominator2 / denominator2)) > 0.001)
            {

                dissapear= nominator2;
                nominator2 += nominator1;
                nominator1 = dissapear;
                dissapear = denominator2;
                denominator2 += denominator1;
                denominator1 = dissapear;
            }
            Console.WriteLine(nominator2 / denominator2);
            Console.WriteLine(nominator2 + " " + denominator2);

            //Упражнение 3.2
            Console.WriteLine("Упражнение 3.2");
            Console.WriteLine("Введите число n:");
            n = int.Parse(Console.ReadLine());
            int member = 0;
            while (member * member <= n)
            {
                member += 1;
            }
            Console.WriteLine(member * member);
            //Упражнение 3.3
            Console.WriteLine("Упражнение 3.3");
            int number = 100;
            //оператор с предусловием
            while (number != 79)
            {
                Console.WriteLine(number);
                number -= 1;
            }
            //оператор с постусловием
            number = 100;
            do
            {
                Console.WriteLine(number);
                number -= 1;
            }
            while (number != 79);
            //Упражнение 3.4
            Console.WriteLine("Упражнение 3.4");
            int num = 0;
            for (int i = 0; i <= 5000; i += 39)
            {
                num = i;
                if (5000 - i < 39)
                {
                    break;
                }
            }
            Console.WriteLine(num);
            //Упражнение 3.5
            Console.WriteLine("Упражнение 3.5");
            num = 5;
            for (int i = 1; i < 6; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
            num = 1;
            for (int i = 1; i < 6; i++)
            {
                for (int j = 6; j > i; j--)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();


            }

 }    }   }                 
    

