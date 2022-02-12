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
        private Vacation _vacation = new Vacation();
        private List<Vacation> _allVacations;
        //private DateTime StartDate;
        //private DateTime EndDate;

        public VacationService()
        {
            _allVacations = new List<Vacation>();
        }
        //TODO 
        public void Post(Vacation vacation)
        {
            _allVacations.Add(vacation);
        }
        public double AverageVacationLength()
        {
            //var vacationDays = EndDate - StartDate;
            //return _allVacations.Where(vacation => vacation.VacationDays == _vacation.VacationDays).Select(vacation => vacation.VacationDays).Average();
            return _allVacations
                .Select(v => v.VacationDays).Average();
        }

    }
}
