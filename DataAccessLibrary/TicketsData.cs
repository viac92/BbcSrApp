using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class TicketsData : ITicketsData
    {
        private readonly ISqlDataAccess _db;

        public TicketsData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<TicketModel>> GetTicket()
        {
            string sql = "select * from dbo.Ticket";

            return _db.LoadData<TicketModel, dynamic>(sql, new { });
        }

        public Task InsertTiket(TicketModel ticket)
        {
            string sql = @"insert into dbo.Ticket (CreateTime, Store, Description, Fault, Caller, CloseTime)
                         values (@CreateTime, @Store, @Description, @Fault, @Caller, @CloseTime);";

            return _db.SaveDate(sql, ticket);
        }
    }
}
