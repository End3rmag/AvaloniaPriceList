using System.Collections.Generic;
using System.Collections.ObjectModel;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using static AvaloniaTovar.MainWindow;

namespace AvaloniaTovar;

public partial class Window1 : Window
{
    public Window1() 
    {
        InitializeComponent();
    }

    public Window1(List<Product> products)
    {
        InitializeComponent();
        ProductListBox.ItemsSource = products;
    }

    private void Button_Click(object? sender, RoutedEventArgs e)
    {
        Close();
    }
}
