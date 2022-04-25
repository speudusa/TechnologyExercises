using System;
namespace TechnologyExercises
{
    public class Laptop : Computer
    {
        public double Weight { get; set; }

        public Laptop(double ram, double storage, bool hasKeyboard, double weight) : base(ram, storage, hasKeyboard)
        {
            Weight = weight;
        }

        public bool IsClunky()
        {
            if (Weight > 5.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}


//commented out while testing Computer class