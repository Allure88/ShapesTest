using DrawingsMaker.Presentation.Pages;
using Microsoft.Extensions.DependencyInjection;
using System.Windows.Controls;

namespace Shapes.UI.Presentation.Router;

public enum PageType { shapes }
public class ViewRouter(IServiceProvider provider)
{
    private MainWindow? MainWindow { get; set; }

    public void ShowMainWindow()
    {
        if (MainWindow == null || !MainWindow.IsLoaded)
        {
            MainWindow = provider.GetRequiredService<MainWindow>();
        }
        MainWindow.Show();
        NavigateTo(PageType.shapes);
    }


    public void NavigateTo(PageType pageType)
    {
        Page page = pageType switch
        {
            PageType.shapes => provider.GetRequiredService<Pages.Shapes.ShapesPage>(),
            _ => throw new NotImplementedException(),
        };
        if (MainWindow != null)
        {
            MainWindow.Content = page;
        }
    }
}

