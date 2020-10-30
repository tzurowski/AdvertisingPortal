using System;
using AdvertisingPortal.Areas.Identity.Data;
using AdvertisingPortal.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(AdvertisingPortal.Areas.Identity.IdentityHostingStartup))]
namespace AdvertisingPortal.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<AdvertisingPortalDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("AdvertisingPortalDbContextConnection")));

                services.AddDefaultIdentity<AdvertisingPortalUser>(options => options.SignIn.RequireConfirmedAccount = false)
                    .AddEntityFrameworkStores<AdvertisingPortalDbContext>();
            });
        }
    }
}