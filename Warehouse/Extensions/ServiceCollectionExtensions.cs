using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using Warehouse.Repository;

namespace Warehouse.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void RegisterDatabase(this IServiceCollection services, DbContext? dbContext)
        {
            if (dbContext == null)
            {
                throw new ArgumentNullException(nameof(dbContext));
            }

            services.AddSingleton<IUnitOfWork>(new UnitOfWork(dbContext));
        }
    }
}
