using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.EmployeeVacation
{
    internal class Developer : Employee
    {
        public Developer(string firstName, string lastName, int employeeId)
            :base(firstName, lastName, employeeId)
        {
        }
    }
}
