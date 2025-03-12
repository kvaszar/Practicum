using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Tracing;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace PracticumUI.ViewModels;

public partial class MatrixViewModel : ViewModelBase
{
    [ObservableProperty] private ObservableCollection<string> _matrixItems = [];
    private int _rows = 4;
    private int _columns = 4;

    public int Rows
    {
        get => _rows;
        set
        {
            _rows = value;
            MatrixItems = [];
            for (var i = 0; i < _rows; i++)
            {
                for (var j = 0; j < _columns; j++)
                {
                    MatrixItems.Add($"{i}|{j}");
                }
            }

            OnPropertyChanged(nameof(Rows));
        }
    }

    public int Columns
    {
        get => _columns;
        set
        {
            _columns = value;
            MatrixItems = [];
            for (var i = 0; i < _rows; i++)
            {
                for (var j = 0; j < _columns; j++)
                {
                    MatrixItems.Add($"{i}|{j}");
                }
            }

            OnPropertyChanged(nameof(Columns));
        }
    }

    

    public MatrixViewModel()
    {
        for (int i = 0; i < _rows; i++)
        {
            for (int j = 0; j < _columns; j++)
            {
                MatrixItems.Add($"{i}|{j}");
            }
        }
    }
}