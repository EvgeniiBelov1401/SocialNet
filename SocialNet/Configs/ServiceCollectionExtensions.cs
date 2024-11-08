﻿using SocialNet.Data.Repos;
using SocialNet.Data.UoW;
using IUnitOfWork = SocialNet.Data.Repos.IUnitOfWork;

namespace SocialNet.Configs
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddCustomRepository<TEntity, TRepository>(this IServiceCollection services)
            where TEntity : class
            where TRepository : class, IRepository<TEntity>
        {
            services.AddScoped<IRepository<TEntity>, TRepository>();

            return services;
        }
        public static IServiceCollection AddUnitOfWork(this IServiceCollection services)
        {
            //services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
