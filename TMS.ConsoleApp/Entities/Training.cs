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
            for (var item = 0; item < trainingTypes.Count;)
            {
                //if any other training type is NOT Lecture return true
                //if its Lecture DONT execute the return true; go to esle and return false
                if(!trainingTypes.Any(i => i is Lecture)) return true;
                else return false;
            }
            return false;
        }
        public Training Clone()
        {
            //creating a new empty object
            var trainingClone = new Training();
            //adding all training types to a newly created objects list(trainingTypes).
            trainingClone.trainingTypes.AddRange(trainingTypes);
          
            return trainingClone;
        }
    }
}
