
using System;

namespace TechnologyExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Computer testComputer = new Computer(8, 128, true);
            Console.WriteLine(testComputer.Ram);
            Console.WriteLine(testComputer.IncreaseRam(4));
            Console.WriteLine();
            Console.WriteLine(testComputer.Storage);
            Console.WriteLine(testComputer.IncreaseStorage(128));

            Laptop testLaptop = new Laptop(8, 236, true, 2.6);
            Console.WriteLine(testLaptop.IsClunky());

            Smartphone testPhone = new Smartphone(12, 128, true, 50);
            Console.WriteLine(testPhone.NumberOfSelfies);
            Console.WriteLine(testPhone.TakeSelfies());
            Console.WriteLine(testPhone.NumberOfSelfies);


            //creating student examples that work for parts 1 & 2
            //currently laptop and smartphone commented out - testing computer class
        }
    }
}
