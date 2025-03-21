
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;


namespace AvaloniaTovar;

public partial class Window1 : Window
{
    private List<Product> _products;

    public Window1()
    {
        InitializeComponent();
    }
    public Window1(List<Product> products)
    {
        InitializeComponent();
        _products = products;
        ProductListBox.ItemsSource = _products;
        ProductListBox.SelectionChanged += ProductListBox_SelectionChanged;
    }

    private void ProductListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (ProductListBox.SelectedItem is Product selectedProduct)
        {
            new Window2(selectedProduct, _products).Show();
            Close();
        }
    }

    private void Button_Click(object? sender, RoutedEventArgs e)
    {
        Close();
    }

    private void Del_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        if (sender is Button button)
        {

            Product productToRemove = (Product)button.DataContext;

            if (ProductManager.Obnovlenie.Products.Count == 0) 
            {
                ProductListBox.ItemsSource = null;
            }

            if (_products.Contains(productToRemove))
            {
                _products.Remove(productToRemove);
                ProductListBox.ItemsSource = null;
                ProductListBox.ItemsSource = _products;
            }
        }
    }

    private void BackButton_Click(object? sender, RoutedEventArgs e)
    {
        new MainWindow().Show();
        Close();
    }
}
