using System.Collections.ObjectModel;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using static AvaloniaTovar.MainWindow;

namespace AvaloniaTovar;

public partial class Window1 : Window
{
    public Window1() 
    {
        InitializeComponent();
    }
    public ObservableCollection<Product> Products { get; set; }

    public Window1(ObservableCollection<Product> products)
    {
        InitializeComponent();
        if (products == null)
        {
            products = new ObservableCollection<Product>();
        }

        ProductListBox.ItemsSource = products;
    }

    private void Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        Close();
    }
}
