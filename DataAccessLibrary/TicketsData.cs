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
            string sql = "select * from dbo.Tickets";

            return _db.LoadData<TicketModel, dynamic>(sql, new { });
        }

        public Task<List<TicketModel>> GetTicketFromSite(IList<int> siteId)
        {
            string sql = $"select * from dbo.Tickets where SiteId in ({String.Join(",", siteId)})";

            return _db.LoadData<TicketModel, dynamic>(sql, new { });
        }

        public Task<List<TicketModel>> GetTicketFromBrandId(int brandId)
        {
            string sql = $"select Ticket.* from dbo.Tickets Ticket where Ticket.SiteId in (select Site.SiteId from dbo.Sites Site where Site.BrandId = {brandId}) order by Ticket.OpenTime desc";

            return _db.LoadData<TicketModel, dynamic>(sql, new { });
        }

        public Task<List<TicketModel>> GetTicketFromTicketId(int ticketId)
        {
            string sql = $"select * from dbo.Tickets where TicketId = {ticketId}";

            return _db.LoadData<TicketModel, dynamic>(sql, new { });
        }

        public Task<List<TicketModel>> GetTicketLastWeek(int brandId)
        {
            string sql = $"select Ticket.* from dbo.Tickets Ticket where Ticket.OpenTime >= DATEADD(day,-30, GETDATE()) and Ticket.SiteId in (select Site.SiteId from dbo.Sites Site where Site.BrandId = {brandId}) order by Ticket.OpenTime desc";

            return _db.LoadData<TicketModel, dynamic>(sql, new { });
        }


        //public Task InsertTiket(TicketModel ticket)
        //{
        //    string sql = @"insert into dbo.Ticket (CreateTime, Store, Description, Fault, Caller, CloseTime)
        //                 values (@CreateTime, @Store, @Description, @Fault, @Caller, @CloseTime);";

        //    return _db.SaveDate(sql, ticket);
        //}
    }
}
