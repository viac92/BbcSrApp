using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class SitesData : ISitesData
    {
        private readonly ISqlDataAccess _db;
        public SitesData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<SiteModel>> GetSite()
        {
            string sql = "select * from dbo.Sites";

            return _db.LoadData<SiteModel, dynamic>(sql, new { });
        }
    }
}
