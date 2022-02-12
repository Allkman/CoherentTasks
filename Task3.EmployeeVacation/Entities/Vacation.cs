using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.EmployeeVacation.Entities
{
    internal class Vacation
    {
        public Employee Employee = new Employee();
        private DateTime _startDate;
        private DateTime _endDate;
        public double VacationDays
        {
            get =>  (_endDate - _startDate).TotalDays;
        }
        public Vacation(Employee employee, DateTime startDate, DateTime endDate)
        {
            Employee = employee;
            _startDate = startDate;
            _endDate = endDate;
        }
        public Vacation() { }
    }
}
