// See https://aka.ms/new-console-template for more information
using TicketApp.Domain.Service;


TicketService ticketService = new();

ticketService.SaveTicketToTextFile("aslı",150);
Console.WriteLine("kaydedildi");