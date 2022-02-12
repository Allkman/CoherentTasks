using Task3.EmployeeVacation;
using Task3.EmployeeVacation.Entities;

Employee developerTom = new Developer("Tom", "Anderson", 240007);
//Console.WriteLine(developerTom.EmployeeId);

var tomVacation = new Vacation(new Developer("Tom", "Anderson", 240007), new DateTime(2021, 03, 12), new DateTime(2021, 03, 26));
var alanVacation = new Vacation(new Developer("Alan", "Smith", 240012), new DateTime(2021, 03, 24), new DateTime(2021, 04, 08));
var kellyVacation = new Vacation(new Developer("Kelly", "Clark", 240101), new DateTime(2021, 07, 01), new DateTime(2021, 07, 22));
Console.WriteLine(tomVacation.VacationDays); 
Console.WriteLine(alanVacation.VacationDays); 
Console.WriteLine(kellyVacation.VacationDays); 
var vacationService = new VacationService();
vacationService.Post(tomVacation);
vacationService.Post(alanVacation);
vacationService.Post(kellyVacation);

Console.WriteLine(vacationService.AverageVacationLength()); 
//vacationService.AverageEmployeeVacationLength();
//vacationService.VacationMonthForEmployees();
//vacationService.NoVacationDateIntervals();
//vacationService.DoIntersect(allVacations);

