using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class ActivitieModel
    {
        public int TicketId { get; set; }
        public string Text { get; set; }
        public DateTime PlannedTime { get; set; }
        public DateTime PlannedStartTime { get; set; }
        public DateTime PlannedEndTime { get; set; }
        public bool CloseTicket { get; set; }
    }
}
