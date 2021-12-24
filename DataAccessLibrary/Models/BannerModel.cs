using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class BannerModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SourceImage { get; set; }
        public string LinkToSite { get; set; }
    }
}
