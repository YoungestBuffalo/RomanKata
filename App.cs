
using System;

namespace Kata
{
    class App
    {
        static void Main(string[] vs)
        {
            Console.WriteLine("Please enter a number");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            RomanConverter converter = new RomanConverter();
            string finalResult = converter.Convert(userNumber);
            Console.WriteLine($"Your result is {finalResult}.");
            Console.ReadLine();
        }
    }
}
