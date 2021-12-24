using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class BannerDate : IBannerDate
    {
        private readonly ISqlDataAccess _db;

        public BannerDate(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<BannerModel>> GetBanner()
        {
            string sql = "select * from dbo.Banner;";

            return _db.LoadData<BannerModel, dynamic>(sql, new { });
        }
    }
}
