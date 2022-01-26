using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.ConsoleApp.Entities
{
    internal abstract class EntityBase : ICloneable
    {
        //if all classes have same prop Description,
        //I want them to inherit form this base class that will
        public string? Description { get; set; } = string.Empty;
        //virtual
        public abstract object Clone();
   
    }
}
