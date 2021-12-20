using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface ITicketApertiDateData
    {
        Task<List<TicketApertiDateModel>> GetTicketApertiLastMonth(int brandId);
    }
}