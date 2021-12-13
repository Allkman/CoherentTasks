using System.Collections.Generic;
using System.Linq;

namespace TMS.ConsoleApp.Entities
{
    internal class Training : EntityBase
    {
        private List<EntityBase> trainings = new List<EntityBase>();

        public void Add(EntityBase training)
        {
            trainings.Add(training);
        }
        public Training( string description)
        {
            Desctription = description;
        }
        public bool IsPractical()
        {
            return trainings.All(l => l is PracticalLesson);
        }
        void Clone()
        {

        }
    }
}
