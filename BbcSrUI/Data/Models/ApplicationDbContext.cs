using BbcSrUI.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BbcSrUI.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityUser>().ToTable("TicketUsers");
            builder.Entity<ApplicationUser>().ToTable("TicketUsers");
            builder.Entity<IdentityRole>().ToTable("TicketRoles");
            builder.Entity<IdentityUserLogin<string>>().ToTable("TicketUserLogins");
            builder.Entity<IdentityUserClaim<string>>().ToTable("TicketUserClaims");
            builder.Entity<IdentityRoleClaim<string>>().ToTable("TicketRoleClaims");
            builder.Entity<IdentityUserRole<string>>().ToTable("TicketUserRoles");
            builder.Entity<IdentityUserToken<string>>().ToTable("TicketUserTokens");
        }
    } 
}
