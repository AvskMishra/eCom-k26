using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace eCommerce.Core;

public static class DependencyInjection
{
    public static IServiceCollection AddCore(this IServiceCollection services)
    {
        //TODO: Add Services to IoC Container 
        //core services often include business logic, domain services, and other core functionalities that are essential to the application's operation.

        return services;


    }

}
