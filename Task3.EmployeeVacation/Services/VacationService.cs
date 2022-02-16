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
        public IEnumerable<DateTime> NonVacationDates(DateTime year)
        {   
            var dates = new List<DateTime>();
            foreach (var item in _allVacations)
            {
                
            }
            return dates;
        }
    }
}
