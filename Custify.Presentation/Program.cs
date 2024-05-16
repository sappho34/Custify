// See https://aka.ms/new-console-template for more information
using Custify.Domain;
using Custify.Domain.Services;
using System.Security.AccessControl;

CustomerService customerService = new();
customerService.Add("Aslı");
customerService.Add("Merve");
customerService.Add("Ela");
customerService.Add("Berna");


var customers = customerService.GetAll();

foreach (var customer in customers)
{
    Console.WriteLine(customer.CustomerName);  
}


