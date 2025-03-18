using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaloniaTovar
{
    public class ProductManager
    {
        public static ProductManager? _obnova;
        public List<Product> Products { get; private set; }

        public ProductManager()
        {
            Products = new List<Product>();
        }

        public static ProductManager Obnovlenie
        {
            get 
            {
                if (_obnova == null) 
                {
                    _obnova = new ProductManager();
                }
                return _obnova;
            }
        }

        public void AddProduct(string name, int quantity, decimal price)
        {
            Products.Add(new Product { Name = name, Quantity = quantity, Price = price });
        }



        public void RemoveProduct(Product product)
        {
            if (product != null && Products.Contains(product))
            {
                Products.Remove(product);
            }
        }
    }
}
