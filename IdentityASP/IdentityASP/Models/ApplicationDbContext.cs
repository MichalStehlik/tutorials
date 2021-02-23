using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityASP.Models
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "ADMIN", Name = "Administrátor", NormalizedName = "ADMINISTRÁTOR" });
            builder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "USER", Name = "Uživatel", NormalizedName = "UŽIVATEL" });
            var hasher = new PasswordHasher<IdentityUser>();
            builder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "ADMIN",
                UserName = "admin@gmail.com",
                NormalizedUserName = "ADMIN@GMAIL.COM",
                Email = "admin@gmail.com",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = string.Empty,
                PasswordHash = hasher.HashPassword(null, "Admin-1234")
            });
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string> { RoleId = "ADMIN", UserId = "ADMIN" });
        }
    }
}
