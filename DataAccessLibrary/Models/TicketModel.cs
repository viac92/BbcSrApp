using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class TicketModel
    {
        public int TicketId { get; set; }
        public DateTime OpenTime { get; set; }
        public int SiteId { get; set; }
        public string Text { get; set; }
        public string Subject { get; set; }
        public string Contact { get; set; }
        public DateTime CloseTime { get; set; }
    }
}
