using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketApp.Domain.Model
{
    public class Ticket
    {
        public int Id { get; set; }
        public string OwnerNameSurname { get; set; }
        public decimal Price { get; set; }
    }
}
