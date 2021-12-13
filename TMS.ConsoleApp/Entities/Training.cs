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
        public Training(string description)
        {
            Desctription = description;
        }
        public bool IsPractical()
        {
            return trainings.All(x => x is PracticalLesson);
        }
        void Clone()
        {

        }
    }
}
