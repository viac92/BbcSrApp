using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface ISitesData
    {
        Task<List<SiteModel>> GetSite();
        Task<List<SiteModel>> GetSiteFromBrand(int brandId);

        Task<List<SiteModel>> GetSiteFormSiteId(int siteId);
    }
}