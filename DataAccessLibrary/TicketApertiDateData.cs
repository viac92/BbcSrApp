using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class TicketApertiDateData : ITicketApertiDateData
    {
        private readonly ISqlDataAccess _db;

        public TicketApertiDateData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<TicketApertiDateModel>> GetTicketApertiLastMonth(int brandId)
        {
            string sql = $@"select count(case when T.OpenTime <= dateadd(day, -30, getdate()) and CloseTime is null then 1 else null end) as TrentaGiorni,
	                               count(case when T.OpenTime <= dateadd(day, -25, getdate()) and CloseTime is null then 1 else null end) as VentiCinqueGiorni,
	                               count(case when T.OpenTime <= dateadd(day, -20, getdate()) and CloseTime is null then 1 else null end) as VentiGiorni,
	                               count(case when T.OpenTime <= dateadd(day, -15, getdate()) and CloseTime is null then 1 else null end) as QuindiciGiorni,
	                               count(case when T.OpenTime <= dateadd(day, -10, getdate()) and CloseTime is null then 1 else null end) as DieciGiorni,
	                               count(case when T.OpenTime <= dateadd(day, -5, getdate()) and CloseTime is null then 1 else null end) as CinqueGiorni,
	                               count(case when T.OpenTime <= getdate() and CloseTime is null then 1 else null end) as Oggi
                                    from Tickets T
                                    join Sites S on T.SiteId = S.SiteId
                                    join Brands B on S.BrandId = B.BrandId
                                    where B.BrandId = {brandId};";
            return _db.LoadData<TicketApertiDateModel, dynamic>(sql, new { });
        }
    }
}
