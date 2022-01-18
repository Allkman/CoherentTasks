using System.Collections.Generic;
using System.Linq;

namespace TMS.ConsoleApp.Entities
{
    internal class Training : EntityBase
    {
        public List<EntityBase> _trainingTypes = new List<EntityBase>();
        public Training(string description, List<EntityBase> trainingTypes)
        {
            Description = description;

            _trainingTypes = trainingTypes;
        }
        public Training() { }
        public void Add(EntityBase training) 
        {
            _trainingTypes.Add(training);
        }
        public bool IsPractical()
        {
            for (var item = 0; item < _trainingTypes.Count;)
            {
                //if any other training type is NOT Lecture return true
                //if its Lecture DONT execute the return true; go to esle and return false
                if(!_trainingTypes.Any(i => i is Lecture)) return true;
                else return false;
            }
            return false;
        }
        public Training Clone()
        {
            return new Training(this.Description, this._trainingTypes);
        }
    }
}
