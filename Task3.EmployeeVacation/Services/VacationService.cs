using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.EmployeeVacation.Entities;

namespace Task3.EmployeeVacation
{
    internal class VacationService
    {
        private Vacation _vacation;
        private Employee _employee;
        private List<Vacation> _allVacations;

        public VacationService()
        {
            _allVacations = new List<Vacation>();
        }
        public void Post(Vacation vacation)
        {
            _allVacations.Add(vacation);
        }
        public double AverageVacationLength()
        {
            return _allVacations
                .Select(v => v.VacationDays).Average();
        }
        public List<Employee> AverageEmployeeVacationsLength()
        {
            //var employeeVacations = new List<Vacation>();
            //foreach (var item in _allVacations)
            //{
            //    if (item.Employee == employee)
            //    {
            //        employeeVacations.Add(item);
            //    }
            //}
            //return employeeVacations.
            //    Select(v => v.VacationDays).Average();
            return _allVacations.Where(e => e.Employee == _employee).ToList();
        }

    }
}
