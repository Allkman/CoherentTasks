using System;
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
        public Training() { }//empty ctor for Training obj creation
        public void Add(EntityBase training) 
        {
            _trainingTypes.Add(training);
        }
        public bool IsPractical()
        {
            for (var item = 0; item < _trainingTypes.Count;)
            {
                //I need at first check if the training has any Material and return false
                //then I add PracticalLesson and return true if training contains only PracticalLesson
                //then I add Lecture, check if training contains only PractcalLesson and return false.
                if (!_trainingTypes.Any(i => i is Lecture)) return true;
                else return false;
            }
            return false;
        }

        public override object Clone()
        {
            var trainingClone = new Training(this.Description, this._trainingTypes);
            for (int i = 0; i < _trainingTypes.Count; i++)
            {
                trainingClone._trainingTypes[i] = this._trainingTypes[i].Clone() as EntityBase;
            }
            return trainingClone;
        }
    }
}
