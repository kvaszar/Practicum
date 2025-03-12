using CommunityToolkit.Mvvm.ComponentModel;

namespace PracticumUI.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty] private ButtonsViewModel _buttonsVm = new();
    [ObservableProperty] private MatrixViewModel _matrixVm = new();
}