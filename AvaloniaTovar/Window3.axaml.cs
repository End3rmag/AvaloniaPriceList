using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AvaloniaTovar;

public partial class Window3 : Window
{
    public Window3()
    {
        InitializeComponent();
    }
    public Window3(string a)
    {
        InitializeComponent();
        Eror.Text = a;
    }

    private void Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        Close();
    }
}