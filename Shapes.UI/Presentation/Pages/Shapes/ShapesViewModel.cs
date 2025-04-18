using DrawingsMaker.Presentation.Pages.utils;
using Shapes.UI.Domain;
using Shapes.UI.Presentation.Router;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace Shapes.UI.Presentation.Pages.Shapes;

public class ShapesViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;
    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
      => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    private ShapesInteractor ShapesInteractor { get; }
    private ViewRouter Router { get; }
    public BindingCommand OnAddCircleCommand { get; }
    public BindingCommand OnAddTriangleCommand { get; }

    private ObservableCollection<string> _shapes = [];
    public ObservableCollection<string> Shapes
    {
        get => _shapes;
        set
        {
            _shapes = value;
            OnPropertyChanged();
        }
    }

    public double radius;
    public double Radius
    {
        get
        {
            return radius;
        }
        set
        {
            radius = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Radius)));
        }
    }

    public double sideA;
    public double SideA
    {
        get
        {
            return sideA;
        }
        set
        {
            sideA = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SideA)));
        }
    }
    public double sideB;
    public double SideB
    {
        get
        {
            return sideB;
        }
        set
        {
            sideB = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SideB)));
        }
    }
    public double sideC;
    public double SideC
    {
        get
        {
            return sideC;
        }
        set
        {
            sideC = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SideC)));
        }
    }

    public ShapesViewModel(ShapesInteractor shapesInteractor, ViewRouter router)
    {
        ShapesInteractor = shapesInteractor;
        Router = router;
        OnAddCircleCommand = new BindingCommand(async _ =>
        {
            try
            {
                await ShapesInteractor.AddShape(new(Radius));
                Shapes = [.. await ShapesInteractor.GetDescriptions()];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        });
        OnAddTriangleCommand = new BindingCommand(async _ =>
        {
            try
            {
                await ShapesInteractor.AddShape(new(SideA, SideB, SideC));
                Shapes = [.. await ShapesInteractor.GetDescriptions()];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        });
    }
}
