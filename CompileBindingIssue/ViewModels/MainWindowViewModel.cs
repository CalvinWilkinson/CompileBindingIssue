using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CompileBindingIssue.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(TheClickCommand))]
    private bool enabled = true;

    [RelayCommand(CanExecute = nameof(Enabled))]
    private void TheClick()
    {
        Enabled = !Enabled;
        Console.WriteLine($"Executed {nameof(TheClick)}");
    }
}
