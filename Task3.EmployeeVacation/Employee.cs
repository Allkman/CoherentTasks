using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.EmployeeVacation
{
    internal class Employee : Person
    {
        private int employeeId;

        public int EmployeeId
        {
            get
            {
                int count = 0;
                while (employeeId > 0)
                {
                    employeeId = employeeId / 10;
                    count++;
                }
                if (employeeId == 10)
                {

                    return employeeId;
                }
                else
                {
                    throw new Exception("Employee ID must consist of 10 digits");
                }
            }
            set
            {
                employeeId = value;
            }
        }
        public Employee(string firstName, string lastName, int employeeId) : base(firstName, lastName)
        {
            EmployeeId = employeeId;
        }

    }
}
