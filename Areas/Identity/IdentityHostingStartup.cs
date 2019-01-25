//using System;
//using ASRWebApp.Areas.Identity.Data;
//using ASRWebApp.Models;
//using Microsoft.AspNetCore.Hosting;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Identity.UI;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.DependencyInjection;

//[assembly: HostingStartup(typeof(ASRWebApp.Areas.Identity.IdentityHostingStartup))]
//namespace ASRWebApp.Areas.Identity
//{
//    public class IdentityHostingStartup : IHostingStartup
//    {
//        public void Configure(IWebHostBuilder builder)
//        {
//            builder.ConfigureServices((context, services) => {
//                services.AddDbContext<AsrContext>(options =>
//                    options.UseSqlServer(
//                        context.Configuration.GetConnectionString("ASRWebAppIdentityDbContextConnection")));

//                services.AddDefaultIdentity<ASRWebAppUser>()
//                    .AddEntityFrameworkStores<AsrContext>();
//            });
//        }
//    }
//}

using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(ASRWebApp.Areas.Identity.IdentityHostingStartup))]
namespace ASRWebApp.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => { });
        }
    }
}