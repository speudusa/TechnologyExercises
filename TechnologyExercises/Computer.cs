using System;
namespace TechnologyExercises
{
    public class Computer
    {
        public double Ram { get; set; }
        public double Storage { get; set; }
        public readonly bool hasKeyboard;

        //create computer object
        public Computer(double ram, double storage, bool hasKeyboard)
        {
            Ram = ram;
            Storage = storage;
            this.hasKeyboard = hasKeyboard;
        }

        //method 1 to add Ram
        public double IncreaseRam(double extraRam)
        {
            return Ram += extraRam;
        }

        //method 2 add Storage
        public double IncreaseStorage(double extraStorage)
        {
           return Storage += extraStorage;
        }
    }
}
