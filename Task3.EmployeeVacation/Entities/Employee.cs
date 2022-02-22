using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.EmployeeVacation.Entities;

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
        //used in VacationService -> DoEmployeeDatesOverlap()
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (this.GetType() != obj.GetType()) return false;
            Employee emp = (Employee)obj;
            return (this.FirstName, this.LastName) == (emp.FirstName, emp.LastName);
        }
    }
}
