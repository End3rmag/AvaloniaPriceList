using System;
using System.Collections.ObjectModel;
using Avalonia.Controls;
using Avalonia.Controls.Notifications;
using Avalonia.Interactivity;

namespace AvaloniaTovar
{
    public partial class MainWindow : Window
    {
        private static ProductManager _productManager = new ProductManager();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var name = TovarName.Text;
            var quantityText = quantityTovar.Text;
            var priceText = TovarPrice.Text;
            if (!string.IsNullOrEmpty(TovarName.Text) && !string.IsNullOrEmpty(quantityTovar.Text) && !string.IsNullOrEmpty(TovarPrice.Text))
            {

                foreach (var product in _productManager.Products)
                {
                    if (product.Name == name)
                    {
                        new Window3("Товар уже добавлен").ShowDialog(this);
                        return;
                    }
                }
                if(int.Parse(quantityText) < 0 || decimal.Parse(priceText) < 0)
                    {
                    new Window3("Кол-во и цена не могут быть отрицательными").ShowDialog(this);
                    return;
                }
            }
            

            if (int.TryParse(quantityText, out var quantity) && decimal.TryParse(priceText, out var price))
            {
                _productManager.AddProduct(name, quantity, price);
                TovarName.Text = string.Empty;
                quantityTovar.Text = string.Empty;
                TovarPrice.Text = string.Empty;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            new Window1(_productManager.Products).Show();
            Close();
        }
    }
}