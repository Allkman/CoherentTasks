using System.Globalization;
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
            var year2021 = GetYearRange();
            var dates = new List<DateTime>();
            var dtates2 = _allVacations
                .
            foreach (var item in _allVacations)
            {
                for (var vacationDate = item.StartDate; vacationDate <= item.EndDate; vacationDate = vacationDate.AddDays(1))
                {
                    dates.Add(vacationDate);
                }
            }

            var workDays = year2021.Except(dates);


            Console.WriteLine(workDays.Count()); // 296

            return workDays;

        }
        private IEnumerable<DateTime> GetYearRange()
        {
            var dateRange = new List<DateTime>();
            for (var date = new DateTime(2021, 01, 01); date <= new DateTime(2021, 12, 31); date = date.AddDays(1))
            {
                dateRange.Add(date);
            }
            return dateRange;
        }
        
    }
}
