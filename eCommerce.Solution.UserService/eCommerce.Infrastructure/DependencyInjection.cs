using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace eCommerce.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        //TODO: Add Services to IoC Container 
        //Infrastructure services often include data access, logging, caching, and other cross-cutting concerns.
        return services;


    }

}
