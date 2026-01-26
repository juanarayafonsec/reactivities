using Application.Activities.Queries;
using Dommain;
using Infrastructure.Messaging;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Extensions;

public static class ApplicationServicesExtension
{
  public static IServiceCollection AddApplicationServices(this IServiceCollection services)
  {
    // Register query handlers
    services.AddTransient<IQueryHandler<GetActivitiesQuery, List<Activity>>, GetActivitiesQueryHandler>();

    return services;
  }
}
