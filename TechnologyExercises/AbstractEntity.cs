using System;
namespace TechnologyExercises
{
    public class AbstractEntity
    {
        //creating ids for computers (computer extends AbstractEntity)
        public int Id { get; set; }
        private static int nextId = 1;

        //updating the next id number
        public AbstractEntity()
        {
            Id = nextId;
            nextId++;
        }
    }
}
