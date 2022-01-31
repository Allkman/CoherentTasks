using System;
using System.Collections.Generic;
using System.Linq;

namespace TMS.ConsoleApp.Entities
{
    internal class Training : EntityBase
    {
        public List<EntityBase> TrainingTypes = new List<EntityBase>();
        public Training(string description, List<EntityBase> trainingTypes) :base(description)
        {
            Description = description;
            TrainingTypes = trainingTypes;
        }
        public Training(string description) : base(description)
        {
            Description = description;
        }
        public void Add(EntityBase training) 
        {
            TrainingTypes.Add(training);
        }
        public bool IsPractical()
        {
            for (var item = 0; item < TrainingTypes.Count;)
            {
                //I need at first check if the training has any Material and return false
                //then I add PracticalLesson and return true if training contains only PracticalLesson
                //then I add Lecture, check if training contains only PractcalLesson and return false.
                if (!TrainingTypes.Any(i => i is Lecture)) return true;
                else return false;
            }
            return false;
        }
        public override Training Clone()
        {
            var trainingClone = new Training(this.Description, this.TrainingTypes);
            for (int i = 0; i < TrainingTypes.Count; i++)
            {
                trainingClone.TrainingTypes[i] = this.TrainingTypes[i].Clone() as EntityBase;
            }
            return trainingClone;
        }
    }
}
