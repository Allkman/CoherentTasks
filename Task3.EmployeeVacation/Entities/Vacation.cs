namespace Task3.EmployeeVacation.Entities
{
    internal class Vacation
    {
        public Employee Employee = new Employee();
        public DateTime StartDate;
        public DateTime EndDate;
        public double VacationDays
        {
            get =>  (EndDate - StartDate).TotalDays;
        }
        public Vacation(Employee employee, DateTime startDate, DateTime endDate)
        {
            Employee = employee;
            StartDate = startDate;
            EndDate = endDate;
        }
        public Vacation() { }
       
    }
}
