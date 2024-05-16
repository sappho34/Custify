// See https://aka.ms/new-console-template for more information
using Custify.Domain.Models;
using Custify.Domain.Services;

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


