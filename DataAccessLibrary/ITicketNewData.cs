using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface ITicketNewData
    {
        Task<List<TicketNewModel>> GetNewTicket(int brandId);
        Task<List<TicketNewModel>> GetNewTicketFromTicketId(int ticketId);
    }
}