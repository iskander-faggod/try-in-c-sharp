using System;

namespace B_Console
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            int n = 5;
            int[] fib = new int[n];

            int a0 = 0;
            int a1 = 1;

            for (int i = 0; i<n; i++)
            {
                int a = a0 + a1;
                fib[i] = a;

                a0 = a1;
                a1 = a;
            }

            foreach (var cur in fib)
            {
                Console.WriteLine(cur);
            }
        }
        public static void ForDoubleFor(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }

            Console.WriteLine("-------------------");
            
            foreach (var num in nums)
            {
                Console.WriteLine(num);
            }

            int[] numbers = { 1, -2, -4, -7, 5, 3, 2, -1, -3, 2, 7, -1, -3, 1, 7 };
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i+1; j<numbers.Length; j++)
                {
                    int ati = numbers[i];
                    int atj = numbers[j];

                    if (ati + atj == 0)
                    {
                        Console.WriteLine($"{ati} + {atj} == 0");
                    }
                    else
                    {
                        Console.WriteLine($"{ati} + {atj} != 0");
                    }
                }
            }
        }
        public static void DZ1(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            Console.WriteLine(firstNum > secondNum ? firstNum: secondNum);
        }
        public static void IfElse(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double weight = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double bodyMassIndex = weight / (height * height);

            bool isToLow = bodyMassIndex <= 18.5;
            bool isNormal = bodyMassIndex > 18.5 && bodyMassIndex < 25;
            bool isAboveNormal = bodyMassIndex >= 25 && bodyMassIndex <= 30;
            bool isTooFat = bodyMassIndex > 30;

            bool isFat = isAboveNormal || isTooFat;

            if (isFat)
            {
                Console.WriteLine("Вы толстенький");
            }
            else
            {
                Console.WriteLine("Все супер)");
            }

            string advice = age >= 18 ? "Можешь пить алкоголь" : "Не стоит пить братишка";

        }
    }
}