// See https://aka.ms/new-console-template for more information
using Custify.Domain;
using Custify.Domain.Services;
using System.Security.AccessControl;

CustomerService customerService = new();

customerService.Add("Aslı","0535459664");
customerService.Add("Merve","0535556647");
customerService.Add("Ela", "05355534567");
customerService.Add("Berna", "0535111647");


var customers = customerService.GetAll();

foreach (var customer in customers)
{
    Console.WriteLine($"{customer.CustomerName},{customer.PhoneNumber}");  
}


