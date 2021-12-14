using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.ConsoleApp.Interfaces
{
    public interface IDeepClonable<T> where T : class
    {
        T Clone();
    }
}
