using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class BrandsData : IBrandsData
    {
        private readonly ISqlDataAccess _db;
        public BrandsData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<BrandModel>> GetBrand()
        {
            string sql = "select BrandId, Name from dbo.Brands";

            return _db.LoadData<BrandModel, dynamic>(sql, new { });
        }
    }
}
