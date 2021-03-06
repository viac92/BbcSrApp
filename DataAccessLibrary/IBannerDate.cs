using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface IBannerDate
    {
        Task<List<BannerModel>> GetBanner();
    }
}