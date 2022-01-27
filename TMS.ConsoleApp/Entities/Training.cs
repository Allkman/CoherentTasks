using System.Collections.Generic;
using System.Linq;

namespace TMS.ConsoleApp.Entities
{
    internal class Training : EntityBase
    {
        public List<EntityBase> _trainingTypes = new List<EntityBase>();
        //A copy ctor for cloning the class where I simply re-initialize the props
        public Training(string description, List<EntityBase> trainingTypes)
        {
            Description = description;
            _trainingTypes = trainingTypes;
        }
        public Training() { }//empty ctor for Training obj creation
        public void Add(EntityBase training) 
        {
            _trainingTypes.Add(training);
        }
        public bool IsPractical()
        {
            return _trainingTypes.All(x => x is PracticalLesson);
        }
        public Training Clone()
        {
            return new Training(this.Description, this._trainingTypes);
        }
    }
}
