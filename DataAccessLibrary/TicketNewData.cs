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
                            where B.BrandId = 706
                            order by StatoTicket, OpenTime desc;";

            return _db.LoadData<TicketNewModel, dynamic>(sql, new { });
        }
    }
}
