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
                var digitCount = (int)Math.Floor(Math.Log10(employeeId) + 1);
                
                if (digitCount == 6)
                {
                    return employeeId;
                }
                else
                {
                    throw new Exception("Employee ID must consist of 6 digits");
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
        public Employee() { }
    }
}
