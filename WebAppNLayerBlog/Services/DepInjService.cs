using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppNLayerBlog.BusinessLogicLayer.Managers;
using WebAppNLayerBlog.BusinessLogicLayer.Profiles;

namespace WebAppNLayerBlog.Services
{
    public static class DepInjService
    {
        public static void AddDependencyInjectionService(this IServiceCollection services)
        {
            services.AddTransient<GuestManager>();

            services.AddAutoMapper(typeof(GuestProfile));
        }
    }
}
