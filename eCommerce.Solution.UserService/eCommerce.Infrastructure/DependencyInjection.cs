using eCommerce.Core.RepositoryContracts;
using eCommerce.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace eCommerce.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        //TODO: Add Services to IoC Container 
        //Infrastructure services often include data access, logging, caching, and other cross-cutting concerns.
        services.AddSingleton<IUsersRepository, UsersRepository>();
        return services;
    }
}
