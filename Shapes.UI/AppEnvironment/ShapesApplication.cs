using Microsoft.Extensions.DependencyInjection;
using Shapes.UI.Presentation.Router;

namespace Shapes.UI.AppEnvironment;
public class ShapesApplication
{
    private ViewRouter Router { get; }

    public ShapesApplication()
    {
        var dependencyInjectionContainer = new DependencyInjectionContainer();
        Router = dependencyInjectionContainer.ServiceProvider.GetRequiredService<ViewRouter>();
    }

    public void Start()
    {
        Router.ShowMainWindow();
    }
}