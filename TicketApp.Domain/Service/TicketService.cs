using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketApp.Domain.Model;

namespace TicketApp.Domain.Service
{
    public class TicketService
    {
        public void SaveTicketToTextFile(string ownerNameSurname,decimal price)
        {
            Random random =new Random();
            Ticket ticket = new()
            {
                Id=random.Next(1,100),
                OwnerNameSurname = ownerNameSurname,
                Price = price
            };
            string ticketInfo = $"{ticket.Id},{ticket.OwnerNameSurname},{ticket.Price}";
            File.AppendAllText("C:\\Users\\sappho\\Desktop\\MEXT\\HakanHoca\\Custify\\TicketApp.Domain\\ticket.txt", ticketInfo);
        }
    }
}
