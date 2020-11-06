using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdvertisingPortal.Areas.Identity.Data;
using AdvertisingPortal.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AdvertisingPortal.Data
{
    public class AdvertisingPortalDbContext : IdentityDbContext<AdvertisingPortalUser>
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Advertisement> Advertisements { get; set; }
        public AdvertisingPortalDbContext(DbContextOptions<AdvertisingPortalDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
