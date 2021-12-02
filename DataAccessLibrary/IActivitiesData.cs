using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface IActivitiesData
    {
        Task<List<ActivitieModel>> GetActiviteFromTicketId(int ticketId);
    }
}