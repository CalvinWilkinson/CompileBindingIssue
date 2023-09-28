using Avalonia.Controls;
using AvaPlayground.ViewModels;

namespace AvaPlayground;

public abstract class WindowBase<TViewModel> : Window
    where TViewModel : ViewModelBase
{
    public WindowBase()
    {
        if (Design.IsDesignMode)
        {
            return;
        }

        ViewModel =  App.Container.GetInstance<TViewModel>();
        DataContext = ViewModel;
    }

    public TViewModel ViewModel { get; protected set; }
}
