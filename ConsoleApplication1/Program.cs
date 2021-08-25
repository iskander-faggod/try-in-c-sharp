using System;
using System.Linq;

namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {
            
        }
        
        static void DateTimeStatic()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            DateTime dt = new DateTime(2016, 2, 28);
        }

        static void Arrays()
        {
            int[] arr1;
            arr1 = new int[10];

            int[] a2 = new int[5] { 1, 2, 3, 4, 5 };
            int[] a3 = { 1, 3, 2, 4, 5 };
        }

        static void Parsing()
        {
            string name = Console.ReadLine();
            string str = $"Your name is {name}";
            Console.WriteLine(str);
            
            string age = Console.ReadLine();
            int intAge = int.Parse(age);
            string str2 = $"Your age is {intAge}";
            Console.WriteLine(str2);
        }
        
        static void StringEqual()
        {
            string str1 = "hello";
            string str2 = "hеllo";
            bool isEqual = string.Equals(str1, str2, StringComparison.Ordinal);
            Console.WriteLine(isEqual);
        }
 
        static void StringFormat()
        {
            string name = "Iskander";
            int age = 18;
            string str1 = $"My name is {name} and i'm {age} years old";
        }
        
        static void QueryingStrings()
        {
            string str = "abrasukaletter";
            bool endsWithLetter = str.EndsWith("Letter");
            bool endsWithULetter = str.EndsWith("letter");
            Console.WriteLine(endsWithLetter);
            Console.WriteLine(endsWithULetter);

            bool startWithA = str.StartsWith("a");
            Console.WriteLine(startWithA);

            int indexOfS = str.IndexOf("su");
            Console.WriteLine(indexOfS);
        }

        static void StaticAndInstanceMembers()
        {
            string name = "abracadabra"; // экземпляр типа string
            bool containsA = name.Contains('a');
            bool containsE = name.Contains('e');
            
            Console.WriteLine(containsA);
            Console.WriteLine(containsE);

            string abc = string.Concat("a", "b", "с");
            Console.WriteLine(abc);
        }
        
        static void Literals()
        {
            int x = 0b11;
            int y = 0b1001;
            int k = 0b10001001;

            int m = 0b1000_1001;
            
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(k);
            Console.WriteLine(m);
        }

        static void Variables()
        {
            int x, y;
            x = 1;
            y = 2;

            float f = 1.1f;
            double d = 2.3;

            var a = 1;
            decimal money = 3.0m;
            
            Console.WriteLine(x+y);
            Console.WriteLine(a);
            Console.WriteLine(money);
            Console.WriteLine(f+d);
        }
        
        
    }
}

