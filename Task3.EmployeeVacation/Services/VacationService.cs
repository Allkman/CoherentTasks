﻿using System.Globalization;
using Task3.EmployeeVacation.Entities;

namespace Task3.EmployeeVacation
{
    internal class VacationService
    {
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
        public IEnumerable<(string, double)> AverageEmployeeVacationsLength()
        {
            return _allVacations
                .GroupBy(e => (e.Employee.FirstName, e.Employee.LastName), vd => vd.VacationDays)
                .Select(res => (res.Key.ToString(), res.Average())).ToList();
        }
        public IEnumerable<(int, int)> VacationMonthForEmployees()
        {
            foreach (var month in Enumerable.Range(1, 12))
            {
                yield return (
                    month, //to return all months
                    _allVacations
                    // to return result for each month and 0 if no record is at specific month
                    .Count(s => s.StartDate.Month <= month && s.EndDate.Month >= month)
                    );
            }
        }
        public IEnumerable<DateTime> NonVacationDates()
        {
            var start2021 = new DateTime(2021, 01, 01);
            var end2021 = new DateTime(2021, 12, 31);
            var year2021 = Enumerable.Range(0, end2021
                                                   .Subtract(start2021).Days + 1)
                                                   .Select(d => start2021
                                                   .AddDays(d)
                                                   );

            var allVacationDatesFlattened = _allVacations
                                                   .SelectMany(x => Enumerable.Range(0, x.EndDate.Subtract(x.StartDate).Days + 1)
                                                   .Select(d => x.StartDate.AddDays(d)))
                                                   .ToList();

            var allNonVacationDays = year2021.Except(allVacationDatesFlattened);
            return allNonVacationDays;
        }
        public bool DoEmployeeDatesOverlap()
        {
            return _allVacations
                   .Any(vacation => _allVacations
                   .Where(emplyeeVacation => emplyeeVacation != vacation)
                   .Any(emplyeeVacation => emplyeeVacation.Employee.Equals(vacation.Employee) && 
                        emplyeeVacation.EndDate >= vacation.StartDate && 
                        emplyeeVacation.StartDate <= vacation.EndDate));
        }
    }
}
