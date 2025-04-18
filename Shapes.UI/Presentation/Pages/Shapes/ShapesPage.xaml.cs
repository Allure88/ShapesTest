using System.Windows.Controls;

namespace Shapes.UI.Presentation.Pages.Shapes
{
    /// <summary>
    /// Логика взаимодействия для ShapesPage.xaml
    /// </summary>
    public partial class ShapesPage : Page
    {
        ShapesViewModel ViewModel { get; set; }
        public ShapesPage(ShapesViewModel viewModel)
        {
            InitializeComponent();
            ViewModel = viewModel;
            DataContext = ViewModel;
        }
    }
}
