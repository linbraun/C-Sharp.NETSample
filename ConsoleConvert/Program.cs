using System;

namespace ConsoleConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringNumber = "";
            int intNumber = 0;
            double doubleNumber = 0;

            Console.WriteLine("Please enter a number: ");
            stringNumber = Convert.ToString(Console.ReadLine());
            doubleNumber = Convert.ToDouble(stringNumber);
            intNumber = Convert.ToInt32(stringNumber);

            Console.WriteLine("This number as a string: " + stringNumber);
            Console.WriteLine("This number as a double: " + doubleNumber);
            Console.WriteLine("This number as an int: " + intNumber);
        }
    }
}
