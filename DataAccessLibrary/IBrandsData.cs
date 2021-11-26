using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface IBrandsData
    {
        Task<List<BrandModel>> GetBrand();
    }
}