using Task3.EmployeeVacation;
using Task3.EmployeeVacation.Entities;

//Console.WriteLine(developerTom.EmployeeId);
var developerTom = new Developer("Tom", "Anderson", 240007);
var tomVacation1st = new Vacation(developerTom, new DateTime(2021, 03, 12), new DateTime(2021, 03, 26));
var tomVacation2nd = new Vacation(new Developer("Tom", "Anderson", 240007), new DateTime(2021, 12, 24), new DateTime(2021, 12, 31));
var alanVacation = new Vacation(new Developer("Alan", "Smith", 240012), new DateTime(2021, 03, 24), new DateTime(2021, 04, 07));
var kellyVacation = new Vacation(new Developer("Kelly", "Clark", 240101), new DateTime(2021, 07, 01), new DateTime(2021, 07, 22));

Console.WriteLine(tomVacation1st.VacationDays); 
Console.WriteLine(tomVacation2nd.VacationDays); 
Console.WriteLine(alanVacation.VacationDays); 
Console.WriteLine(kellyVacation.VacationDays); 

var vacationService = new VacationService();
vacationService.Post(tomVacation1st);
vacationService.Post(tomVacation2nd);
vacationService.Post(alanVacation);
vacationService.Post(kellyVacation);

Console.WriteLine(vacationService.AverageVacationLength());
Console.WriteLine(vacationService.AverageEmployeeVacationsLength()); 
//vacationService.VacationMonthForEmployees();
//vacationService.NoVacationDateIntervals();
//vacationService.DoIntersect(allVacations);

