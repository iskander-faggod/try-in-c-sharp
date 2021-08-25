using System;

namespace B_Console
{
    internal class Program
    {
        public static void Main(string[] args)
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