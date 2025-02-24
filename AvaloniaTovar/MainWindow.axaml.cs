using System.Collections.ObjectModel;
using Avalonia.Controls;
using Avalonia.Controls.Notifications;
using Avalonia.Interactivity;

namespace AvaloniaTovar
{
    public partial class MainWindow : Window
    {
        private ProductManager _productManager;

        public MainWindow()
        {
            InitializeComponent();
            _productManager = new ProductManager();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var name = TovarName.Text;
            var quantityText = quantityTovar.Text;
            var priceText = TovarPrice.Text;

            if (int.TryParse(quantityText, out var quantity) && decimal.TryParse(priceText, out var price))
            {
                _productManager.AddProduct(name, quantity, price);
                InitializeComponent();
            }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            new Window1(_productManager.Products).Show();
            Close();
        }
    }
}