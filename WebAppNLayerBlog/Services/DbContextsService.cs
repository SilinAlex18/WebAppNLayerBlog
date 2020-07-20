using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppNLayerBlog.DataAccessLayer.Data;

namespace WebAppNLayerBlog.Services
{
    public static class DbContextsService
    {
        public static void AddDbContextService(this IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>();

            //services.AddIdentityCore<User>(options => options.SignIn.RequireConfirmedAccount = true)
            //    .AddEntityFrameworkStores<ApplicationDbContext>();
        }
    }
}
