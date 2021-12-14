using System.Collections.Generic;
using System.Linq;
using TMS.ConsoleApp.Interfaces;

namespace TMS.ConsoleApp.Entities
{
    internal class Training : EntityBase, IDeepClonable<Training>
    {
        public List<EntityBase> trainingTypes = new List<EntityBase>();
        private Training _training;

        public void Add(EntityBase training)
        {
            trainingTypes.Add(training);
        }

        public bool IsPractical()
        {
            if (trainingTypes.Count == 0)
            {
                return false;
            }
            if (trainingTypes.All(x => x is PracticalLesson))
            {
                return true;
            }
            return false;            
        }
        //https://stackoverflow.com/questions/129389/how-do-you-do-a-deep-copy-of-an-object-in-net
        public Training Clone()
        {
            var trainingClone = new Training();

            if (_training != null)
            {
                trainingClone._training = _training.Clone(); //reference type .Clone() that does the same
            }
           
            return trainingClone;
        }
    }
}
