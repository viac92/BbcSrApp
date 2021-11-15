using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class TicketModel
    {
        public int Id { get; set; }
        public DateTime CreateTime { get; set; }
        public string Store { get; set; }
        public string Description { get; set; }
        public string Fault { get; set; }
        public string Caller { get; set; }
        public DateTime CloseTime { get; set; }
    }
}
