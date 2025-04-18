using Microsoft.Extensions.DependencyInjection;
using Shapes.UI.AppEnvironment;
using Shapes.UI.Presentation.Router;
using System.Windows;

namespace Shapes.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private ViewRouter Router { get; set; } = null!;
        private void App_OnStartup(object sender, StartupEventArgs e)
        {
            var dependencyInjectionContainer = new DependencyInjectionContainer();
            Router = dependencyInjectionContainer.ServiceProvider.GetRequiredService<ViewRouter>();
            Router.ShowMainWindow();
        }
    }

}
