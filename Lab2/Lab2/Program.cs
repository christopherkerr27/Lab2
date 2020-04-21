using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            string response = "";
            do
            {
                Console.WriteLine("Enter Length:");
                var num = Console.ReadLine();
                float length = float.Parse(num);
                Console.Write("Enter Width:");
                var num2 = Console.ReadLine();
                float width = float.Parse(num2);
                var area = length * width;
                Console.WriteLine("Area: " + area);
                var perimeter = length + length + width + width;
                Console.WriteLine("Perimeter: " + perimeter);
                Console.WriteLine("Would you like to continue? (y/n)");
                response = Console.ReadLine();
                response = response.ToUpper();
            }
            while (response == "Y");
            Console.WriteLine("Goodbye!");
        }
    }
}
