using eCommerce.Core.ServiceContracts;
using eCommerce.Core.Services;
using eCommerce.Core.Validators;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace eCommerce.Core;

public static class DependencyInjection
{
    public static IServiceCollection AddCore(this IServiceCollection services)
    {
        //TODO: Add Services to IoC Container 
        //core services often include business logic, domain services, and other core functionalities that are essential to the application's operation.
        services.AddTransient<IUsersService, UsersService>();
        services.AddValidatorsFromAssemblyContaining<LoginRequestValidator>();
        return services;
    }
}
