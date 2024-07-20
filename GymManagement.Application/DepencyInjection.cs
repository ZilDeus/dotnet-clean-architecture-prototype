namespace GymManagement.Application;
using Microsoft.Extensions.DependencyInjection;

public static class DepencyInjection{
  public static IServiceCollection AddApplication(this IServiceCollection services){
    services.AddMediatR( ops => {
          ops.RegisterServicesFromAssemblyContaining(typeof(DepencyInjection));
        });
    return services;
  }
}
