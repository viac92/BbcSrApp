using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BbcSrUI.Data.Models
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            await roleManager.CreateAsync(new IdentityRole("Administrators"));

            var BruniGlass = new ApplicationUser { UserName = "BruniGlass", BrandId = 738, EnableNewCall = false, EnableNewEvent = false, EnableCalls = false, EnableEvents = false };
            await userManager.CreateAsync(BruniGlass, "******");

            var enria = new ApplicationUser { UserName = "enria", BrandId = 9, EnableNewCall = true, EnableNewEvent = true, EnableCalls = true, EnableEvents = true };
            await userManager.CreateAsync(enria, "******");

            var feltrinelli = new ApplicationUser { UserName = "feltrinelli", BrandId = 638, EnableNewCall = false, EnableNewEvent = false, EnableCalls = true, EnableEvents = true };
            await userManager.CreateAsync(feltrinelli, "******");

            var fjId = new ApplicationUser { UserName = "fJId", BrandId = 572, EnableNewCall = false, EnableNewEvent = false, EnableCalls = true, EnableEvents = true };
            await userManager.CreateAsync(fjId, "******");

            var Karatti = new ApplicationUser { UserName = "Karatti", BrandId = 769, EnableNewCall = false, EnableNewEvent = false, EnableCalls = false, EnableEvents = false };
            await userManager.CreateAsync(Karatti, "******");

            var Legami = new ApplicationUser { UserName = "Legami", BrandId = 759, EnableNewCall = false, EnableNewEvent = false, EnableCalls = false, EnableEvents = false };
            await userManager.CreateAsync(Legami, "******");

            var Lush = new ApplicationUser { UserName = "Lush", BrandId = 756, EnableNewCall = false, EnableNewEvent = false, EnableCalls = false, EnableEvents = false };
            await userManager.CreateAsync(Lush, "******");

            var nau = new ApplicationUser { UserName = "nau", BrandId = 769, EnableNewCall = false, EnableNewEvent = false, EnableCalls = true, EnableEvents = true };
            await userManager.CreateAsync(nau, "******");

            var percassi = new ApplicationUser { UserName = "percassi", BrandId = 663, EnableNewCall = false, EnableNewEvent = false, EnableCalls = true, EnableEvents = true };
            await userManager.CreateAsync(percassi, "******");

            var sev = new ApplicationUser { UserName = "sev", BrandId = 501, EnableNewCall = false, EnableNewEvent = false, EnableCalls = true, EnableEvents = true };
            await userManager.CreateAsync(sev, "******");

            var Trussardi = new ApplicationUser { UserName = "Trussardi", BrandId = 706, EnableNewCall = false, EnableNewEvent = false, EnableCalls = false, EnableEvents = false };
            await userManager.CreateAsync(Trussardi, "******");




            string adminUserName = "BBC";
            var adminUser = new ApplicationUser { UserName = adminUserName };
            await userManager.CreateAsync(adminUser, "******");
            
            adminUser = await userManager.FindByNameAsync(adminUserName);
            await userManager.AddToRoleAsync(adminUser, "Administrators");
        }
    }
}
