using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaObservableValidatorExample.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty] private PersonViewModel _personViewModelValue = new();
}