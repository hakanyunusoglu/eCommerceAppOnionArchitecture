using eCommerceApp.Application.Abstraction;
using eCommerceApp.Persistence.Concrete;
using eCommerceApp.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceApp.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<eCommerceAPIDbContext>(options => options.UseNpgsql("User ID=postgres;Password=123456;Host=localhost;Port=5432;Database=xxx;"));
        }
    }
}
