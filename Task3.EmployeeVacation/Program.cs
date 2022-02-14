using Task3.EmployeeVacation;
using Task3.EmployeeVacation.Entities;

//Console.WriteLine(developerTom.EmployeeId);
var tomVacation1st = new Vacation(new Developer("Tom", "Anderson", 240007), new DateTime(2021, 03, 12), new DateTime(2021, 03, 26));
var tomVacation2nd = new Vacation(new Developer("Tom", "Anderson", 240007), new DateTime(2021, 12, 24), new DateTime(2021, 12, 31));
var alanVacation1st = new Vacation(new Developer("Alan", "Smith", 240012), new DateTime(2021, 03, 24), new DateTime(2021, 04, 07));
var alanVacation2nd = new Vacation(new Developer("Alan", "Smith", 240012), new DateTime(2021, 07, 14), new DateTime(2021, 07, 16));
var kellyVacation1st = new Vacation(new Developer("Kelly", "Clark", 240101), new DateTime(2021, 07, 01), new DateTime(2021, 07, 22));
var kellyVacation2nd = new Vacation(new Developer("Kelly", "Clark", 240101), new DateTime(2021, 08, 25), new DateTime(2021, 09, 05));

//Console.WriteLine(tomVacation1st.VacationDays); 
//Console.WriteLine(tomVacation2nd.VacationDays); 
//Console.WriteLine(alanVacation1st.VacationDays); 
//Console.WriteLine(alanVacation2nd.VacationDays); 
//Console.WriteLine(kellyVacation.VacationDays); 

var vacationService = new VacationService();
vacationService.Post(tomVacation1st);
vacationService.Post(tomVacation2nd);
vacationService.Post(alanVacation1st);
vacationService.Post(alanVacation2nd);
vacationService.Post(kellyVacation1st);
vacationService.Post(kellyVacation2nd);

Console.WriteLine(vacationService.AverageVacationLength());
var employeeVacations = vacationService.AverageEmployeeVacationsLength();
foreach (var item in employeeVacations)
{
    Console.WriteLine(item);
}
var months = vacationService.VacationMonthForEmployees();
foreach (var item in months)
{
    Console.WriteLine(item);
}
//vacationService.NoVacationDateIntervals();
//vacationService.DoIntersect(allVacations);

