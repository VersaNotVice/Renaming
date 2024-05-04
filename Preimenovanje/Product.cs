using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rppoon_Zad_2_Refaktoriranje
{
    class Product
    {
        public string Name { get; private set; } 
        public string Price { get; private set; } 
        public bool IsInStock { get; set; } 

        public Product(string name, string price)
        {
            this.Name = name;
            this.Price = price;
            this.IsInStock = false;
        }
    }

    class ProductHandler
    {
        List<Product> products; 

        public ProductHandler(List<Product> products) 
        {
            this.products = products;
        }

        public void FindProduct(Product product)
        {
            foreach (Product prod in products)
            {
                if (product == prod)
                    prod.IsInStock = true;
            }
        }
        public void RemoveSoldProducts()
        {
            products.RemoveAll(product => product.IsInStock == false);
        }
    }
}
