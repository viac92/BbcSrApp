using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BbcSrUI.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        public int BrandId { get; set; }
        public bool EnableNewCall { get; set; }
        public bool EnableNewEvent { get; set; }
        public bool EnableCalls { get; set; }
        public bool EnableEvents { get; set; }
    }
}
