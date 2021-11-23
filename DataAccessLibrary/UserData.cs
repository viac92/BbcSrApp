using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    class UserData : IUserData
    {
        private readonly ISqlDataAccess _db;

        public UserData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<UserModel>> GetUser()
        {
            string sql = "select * from dbo.WebUsers";

            return _db.LoadData<UserModel, dynamic>(sql, new { });
        }
    }
}
