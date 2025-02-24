using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaloniaTovar
{
    public class ProductManager
    {
        public List<Product> Products { get; private set; }

        public ProductManager()
        {
            Products = new List<Product>();
        }

        public void AddProduct(string name, int quantity, decimal price)
        {
            Products.Add(new Product
            {
                Name = name,
                Quantity = quantity,
                Price = price
            });
        }
    }
}
