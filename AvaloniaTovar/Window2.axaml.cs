
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using System;
using System.Collections.Generic;

namespace AvaloniaTovar;

public partial class Window2 : Window
{
    public Product Product { get; private set; }
    public List<Product> products;
    public Window2()
    {
        InitializeComponent();
    }

    public Window2(Product product, List<Product> products)
    {
        InitializeComponent();
        Product = product;
        this.products = products;
        Name.Text = product.Name;
        Quantity.Text = product.Quantity.ToString();
        Price.Text = product.Price.ToString("F2");
    }

    private void Button_Click_1(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        Product.Name = Name.Text;
        Product.Quantity = int.Parse(Quantity.Text);
        Product.Price = decimal.Parse(Price.Text);
        new Window1(products).Show();
        Close();

    }

    private void Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        Close();
    }


}
