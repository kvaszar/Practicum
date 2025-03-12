using System;
using Avalonia;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace PracticumUI.ViewModels;

public partial class ButtonsViewModel : ViewModelBase
{
    private Random _random = new();
    [ObservableProperty] private Thickness _margin = new Thickness(0, 0, 0, 0);

    [RelayCommand]
    private void MoveButton()
    {
        Margin = new Thickness(_random.Next(0, 400), _random.Next(0, 400), 0, 0);
    }
}