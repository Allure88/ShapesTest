using Microsoft.Extensions.DependencyInjection;
using Shapes.UI.Presentation.Router;

namespace Shapes.UI.Presentation;

public static class PresentationServicesRegistration
{
    public static IServiceCollection RegisterPresentationLayer(this IServiceCollection services)
    {
        services.AddSingleton(provider => new ViewRouter(provider));

        services.AddTransient<MainWindow>();
        services.AddTransient<Pages.Shapes.ShapesPage>();
        services.AddSingleton<Pages.Shapes.ShapesViewModel>();

        return services;
    }
}
