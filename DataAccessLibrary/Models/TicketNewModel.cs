using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class TicketNewModel
    {
        public int TicketId { get; set; }
        public string StoreName { get; set; }
        public string Subject { get; set; }
        public string Text { get; set; }
        public string Contact { get; set; }
        public DateTime OpenTime { get; set; }
        public int BrandId { get; set; }
        public string StatoTicket { get; set; }
    }
}
