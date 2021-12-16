using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface ITicketsData
    {
        Task<List<TicketModel>> GetTicket();
        //Task InsertTiket(TicketModel ticket);
        Task<List<TicketModel>> GetTicketFromSite(IList<int> siteId);

        Task<List<TicketModel>> GetTicketFromBrandId(int brandId);

        Task<List<TicketModel>> GetTicketFromTicketId(int ticketId);

        Task<List<TicketModel>> GetTicketLastWeek(int brandId);
    }
}