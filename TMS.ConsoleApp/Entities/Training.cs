using System.Collections.Generic;
using System.Linq;

namespace TMS.ConsoleApp.Entities
{
    internal class Training : EntityBase
    {
        public List<EntityBase> trainingTypes = new List<EntityBase>();

        public void Add(EntityBase training)
        {
            trainingTypes.Add(training);
        }

        public bool IsPractical()
        {
            return trainingTypes.All(x => x is PracticalLesson);            
        }
        public Training Clone()
        {
            var trainingClone = new Training();
            trainingClone.trainingTypes.AddRange(this.trainingTypes);
          
            return trainingClone;
        }
    }
}
