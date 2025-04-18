using Microsoft.Extensions.DependencyInjection;

namespace Shapes.UI.Domain;

public static class DomainServicesRegistration
{
    public static IServiceCollection RegisterDomainLayer(this IServiceCollection services)
    {
        services.AddSingleton<ShapesInteractor>();

        return services;
    }
}
