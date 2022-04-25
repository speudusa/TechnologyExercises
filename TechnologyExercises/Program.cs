
using System;

namespace TechnologyExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //checking out Computer class
            Console.WriteLine("Hello, Computer!!");
            Computer testComputer = new Computer(8, 128, true);
            Console.WriteLine("Inital ram: " + testComputer.Ram);
            Console.WriteLine("Increased ram: " + testComputer.IncreaseRam(4));
            Console.WriteLine("Inital storage: " + testComputer.Storage);
            Console.WriteLine("Increased Storage: " + testComputer.IncreaseStorage(128));


            //checking out Laptop class
            Console.WriteLine("\nHello, Laptop!");
            Laptop testLaptop = new Laptop(8, 236, true, 2.6);
            Console.WriteLine("Laptop weight:" + testLaptop.Weight);
            Console.WriteLine("Laptop weighs more than 5 pounds: " + testLaptop.IsClunky());
           
            Laptop testLaptop2 = new Laptop(8, 236, true, 7.6);
            Console.WriteLine("Laptop weight:" + testLaptop2.Weight);
            Console.WriteLine("Laptop weighs more than 5 pounds: " + testLaptop2.IsClunky());


            //checking Smartphone class
            Console.WriteLine("\nHello, Smartphone!");
            Smartphone testPhone = new Smartphone(12, 128, true, 50);
            Console.WriteLine("Initial # of selfies: " + testPhone.NumberOfSelfies);
            testPhone.TakeSelfies();
            Console.WriteLine("Increased # of selfies: " + testPhone.NumberOfSelfies);
            
        }
    }
}
