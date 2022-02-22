﻿using Task3.EmployeeVacation;
using Task3.EmployeeVacation.Entities;

var tomVacation1st = new Vacation(new Developer("Tom", "Anderson", 240007), new DateTime(2021, 03, 12), new DateTime(2021, 03, 26));//overlap
var tomVacation2nd = new Vacation(new Developer("Tom", "Anderson", 240007), new DateTime(2021, 03, 23), new DateTime(2021, 03, 31));//overlap
var alanVacation1st = new Vacation(new SalesRepresentative("Alan", "Smith", 240012), new DateTime(2021, 03, 24), new DateTime(2021, 04, 07));
var alanVacation2nd = new Vacation(new SalesRepresentative("Alan", "Smith", 240012), new DateTime(2021, 07, 14), new DateTime(2021, 07, 16));
var kellyVacation1st = new Vacation(new Developer("Kelly", "Clark", 240101), new DateTime(2021, 07, 01), new DateTime(2021, 07, 22));
var kellyVacation2nd = new Vacation(new Developer("Kelly", "Clark", 240101), new DateTime(2021, 08, 25), new DateTime(2021, 09, 05));

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
var dates = vacationService.NonVacationDates();
foreach (var item in dates)
{
    Console.WriteLine(item);
}
var overlapingEmployeeVacations = vacationService.DoEmployeeDatesOverlap();
Console.WriteLine(overlapingEmployeeVacations); //true

