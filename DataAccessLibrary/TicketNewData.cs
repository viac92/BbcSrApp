using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class TicketNewData : ITicketNewData
    {
        private readonly ISqlDataAccess _db;

        public TicketNewData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<TicketNewModel>> GetNewTicket(int brandId)
        {
            string sql = $@"select T.TicketId, S.Name as StoreName, T.Subject, T.Text, T.Contact, T.OpenTime, B.BrandId,
                            case
	                            when T.CloseTime is null then 'Aperto'
	                            when T.CloseTime is not null then 'Chiuso'
                            end as StatoTicket
                            from Tickets T
                            join Sites S on T.SiteId = S.SiteId
                            join Brands B on S.BrandId = B.BrandId
                            where B.BrandId = {brandId}
                            order by StatoTicket, OpenTime desc;";

            return _db.LoadData<TicketNewModel, dynamic>(sql, new { });
        }

        public Task<List<TicketNewModel>> GetNewTicketFromTicketId(int ticketId)
        {
            string sql = $@"select T.TicketId, S.Name as StoreName, T.Subject, T.Text, T.Contact, T.OpenTime, B.BrandId,
                            case
	                            when T.CloseTime is null then 'Aperto'
	                            when T.CloseTime is not null then 'Chiuso'
                            end as StatoTicket
                            from Tickets T
                            join Sites S on T.SiteId = S.SiteId
                            join Brands B on S.BrandId = B.BrandId
                            where T.TicketId = {ticketId}
                            order by StatoTicket, OpenTime desc;";

            return _db.LoadData<TicketNewModel, dynamic>(sql, new { });
        }

        public Task<List<TicketNewModel>> GetNewTicketFromTicketIdLastTen(int brandId2)
        {
            string sql = $@"select top 10 T.TicketId, S.Name as StoreName, T.Subject, T.Text, T.Contact, T.OpenTime, B.BrandId,
                            case
	                            when T.CloseTime is null then 'Aperto'
	                            when T.CloseTime is not null then 'Chiuso'
                            end as StatoTicket
                            from Tickets T
                            join Sites S on T.SiteId = S.SiteId
                            join Brands B on S.BrandId = B.BrandId
                            where B.BrandId = {brandId2}
                            order by StatoTicket, OpenTime desc;";

            return _db.LoadData<TicketNewModel, dynamic>(sql, new { });
        }
    }
}
