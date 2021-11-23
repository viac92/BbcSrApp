using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    interface IUserData
    {
        Task<List<UserModel>> GetUser();
    }
}