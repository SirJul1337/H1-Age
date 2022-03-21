using System;

namespace Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your age");
            int age = int.Parse(Console.ReadLine());
            if (age <= 3)
            {
                Console.WriteLine(name + ", du må gå med ble");
            }
            else if (age > 3 && age <= 15)
            {
                Console.WriteLine(name + ", du må ingenting");
            }
            else if (age > 15 && age < 18)
            {
                Console.WriteLine(name + ", du må drikke");
            }
            else
            {
                Console.WriteLine(name + ", du må stemme og køre bil");
            }
        }
    }
}
