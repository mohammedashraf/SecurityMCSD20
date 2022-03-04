using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SecurityWebAppMC20.Areas.Identity.Data;
using SecurityWebAppMC20.Data;

[assembly: HostingStartup(typeof(SecurityWebAppMC20.Areas.Identity.IdentityHostingStartup))]
namespace SecurityWebAppMC20.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<SecurityWebAppMC20Context>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("SecurityWebAppMC20ContextConnection")));

                services.AddDefaultIdentity<ApplicationUser>(options => {
                    options.SignIn.RequireConfirmedAccount = false;
                    options.Password.RequiredLength = 8;
                    options.Password.RequireNonAlphanumeric = true;
                    options.User.RequireUniqueEmail = true;
                })
                    .AddEntityFrameworkStores<SecurityWebAppMC20Context>();
            });
        }
    }
}