using System.Collections.ObjectModel;
using Avalonia.Controls;
using Avalonia.Controls.Notifications;
using Avalonia.Interactivity;

namespace AvaloniaTovar
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
        }
        public class Product
        {
            public string Name { get; set; }
            public int Quantity { get; set; }
            public decimal Price { get; set; }

            public override string ToString()
            {
                return $"{Name} ({Quantity}רע) - {Price:C} חא רע";
            }
        }

        private ObservableCollection<Product> products;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var name = TovarName.Text;
            var quantityText = quantityTovar.Text;
            var priceText = TovarPrice.Text;

            if (int.TryParse(quantityText, out var quantity) && decimal.TryParse(priceText, out var price))
            {
                products.Add(new Product
                {
                    Name = name,
                    Quantity = quantity,
                    Price = price
                });

                TovarName.Text = string.Empty;
                quantityTovar.Text = string.Empty;
                TovarPrice.Text = string.Empty;
            }
            else
            {

            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            new Window1(products).Show();
            Close();
        }
    }
}