
using System;

namespace TechnologyExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Computer test = new Computer(8, 128, true);
            Console.WriteLine(test.Ram);
            Console.WriteLine(test.IncreaseRam(4));
            Console.WriteLine();
            Console.WriteLine(test.Storage);
            Console.WriteLine(test.IncreaseStorage(128));


            //creating studente xamples that work for parts 1 & 2
            //currently laptop and smartphone commented out - testing computer class
        }
    }
}
