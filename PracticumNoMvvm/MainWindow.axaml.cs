using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Media;

namespace PracticumNoMvvm;

public partial class MainWindow : Window
{
    private int _count = 0;

    public MainWindow()
    {
        InitializeComponent();
        for (int i = 0; i < 5; i++)
        {
            var b = new Button
            {
                Content = _count,
                Width = 100,
                Height = 100,
                Margin = new Thickness(i * 100, i * 100, 0, 0),
            };
            b.Click += button_Click;
            b.PointerPressed += MyButton_OnPointerPressed;
            b.PointerReleased += button_MouseUp;
            this.Panel.Children.Add(b);
            if (i > 0)
            {
                var b2 = new Button
                {
                    Content = _count,
                    Width = 100,
                    Height = 100,
                    Margin = new Thickness(i * 100, -i * 100, 0, 0),
                };
                b2.Click += button_Click;
                b2.PointerPressed += MyButton_OnPointerPressed;
                b2.PointerReleased += button_MouseUp;
                this.Panel.Children.Add(b2);
            }
        }
        //LogicalChildren.Add(b);
        //VisualChildren.Add(b);
    }

    private void button_Click(object? sender, RoutedEventArgs e)
    {
        if (sender is Button b)
        {
            b.Content = (int)b.Content + 1;
        }
    }

    private void MyButton_OnPointerPressed(object? sender, PointerPressedEventArgs e)
    {
        Console.WriteLine("md");
        if (sender is Button b)
        {
            b.Background = Brushes.Red;
        }
    }

    private void button_MouseUp(object? sender, EventArgs e)
    {
        if (sender is Button b)
        {
            b.Foreground = Brushes.Green;
        }
    }
}