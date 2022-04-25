using System;
namespace TechnologyExercises
{
    public class Smartphone : Computer
    {
        public int NumberOfSelfies { get; set; }

       
        public Smartphone( double ram, double storage, bool hasKeyboard, int numberOfSelfies) : base(ram, storage, hasKeyboard)
        {
            NumberOfSelfies = numberOfSelfies;
        }


        public int TakeSelfies()
        {
            return NumberOfSelfies++;
        }





    }
}
