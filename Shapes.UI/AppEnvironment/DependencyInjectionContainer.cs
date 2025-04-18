using Microsoft.Extensions.DependencyInjection;
using Shapes.UI.Domain;
using Shapes.UI.Presentation;

namespace Shapes.UI.AppEnvironment
{
    internal class DependencyInjectionContainer
    {
        public static bool IsViewTestMode = false;
        public ServiceProvider ServiceProvider { get; }


        public DependencyInjectionContainer()
        {
            ServiceCollection services = new();

            services.RegisterPresentationLayer();
            services.RegisterDomainLayer();

            ServiceProvider = services.BuildServiceProvider();
        }

    }
}
