using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLibrary.Models;

namespace DataAccessLibrary
{
    public class ActivitiesData : IActivitiesData
    {
        private readonly ISqlDataAccess _db;

        public ActivitiesData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<ActivitieModel>> GetActiviteFromTicketId(int ticketId)
        {
            string sql = $"select * from dbo.Activities where TicketId = {ticketId}";

            return _db.LoadData<ActivitieModel, dynamic>(sql, new { });
        }
    }
}
