using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.EmployeeVacation.Entities
{
    internal class Vacation
    {
        private Employee _employee= new Employee();
        private DateTime _startDate;
        private DateTime _endDate;
        //private DateTime StartDate
        //{
        //    get
        //    {
        //        return _startDate;
        //    }
        //    set
        //    {
        //        _startDate = value;
        //    }
        //} 
        //private DateTime EndDate { get => _endDate; set => _endDate = value; }
        //private double _vacationDays;

        public double VacationDays
        {
            get =>  (_endDate - _startDate).TotalDays;
            
        }
        public Vacation(Employee employee, DateTime startDate, DateTime endDate)
        {
            _employee = employee;
            _startDate = startDate;
            _endDate = endDate;
        }
        public Vacation()
        {

        }
    }
}
