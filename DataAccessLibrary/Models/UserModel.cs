using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    class UserModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string CustomerId { get; set; }
        public int BrandId { get; set; }
    }
}
