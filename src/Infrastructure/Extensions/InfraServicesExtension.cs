using Infrastructure.Messaging;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Extensions;

public  static class InfraServicesExtension
{
  public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        // Register CQRS mediator
        services.AddScoped<IMediator, Mediator>();
       
        return services;
    }
}
