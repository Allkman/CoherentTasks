using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.EmployeeVacation
{
    internal class VacationService
    {
        public Employee Employee { get; set; }
        private DateTime StartDate { get; set; }
        private DateTime EndDate { get; set; }
    }
}
