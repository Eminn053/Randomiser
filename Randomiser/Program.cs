using System;
using System.Threading;

namespace Randomiser
{
    class Program
    {
        static void RandName()
        {
            int TimeOut = 500;
            string[] maleNames = { "aaron", "abdul", "abe", "abel", "abraham", "adam", "adan", "adolfo", "adolph", "adrian" };
            string[] femaleNames = { "abby", "abigail", "adele", "adrian" };
            string[] lastNames = { "abbott", "acosta", "adams", "adkins", "aguilar", "smith", "johnson", "williams", "jones", "brown", "davis", "miller", "wilson", "moore", "taylor", "anderson", "thomas", "jackson", "whıte", "harrıs", "martın", "thompson", "garcıa", "martınez", "robınson", "clark", "rodrıguez", "lewıs", "lee" };

            Random name = new Random();

            int inxm = name.Next(maleNames.Length);
            int inxl = name.Next(lastNames.Length);
            int inxf = name.Next(femaleNames.Length);

            Console.WriteLine("Which gender are you?");
            Console.WriteLine("m-male");
            Console.WriteLine("f-female");
            if (Convert.ToChar(Console.ReadLine()) == 'm')
            {
                Thread.Sleep(TimeOut);
                Console.WriteLine($"Your name is {maleNames[inxm]} {lastNames[inxl]}");
            }
            else
            {
                Thread.Sleep(TimeOut);
                Console.WriteLine($"Your name is {femaleNames[inxf]} {lastNames[inxl]}");
            }

        }

        static void Main(string[] args)
        {
            RandName();
        }
    }
}
