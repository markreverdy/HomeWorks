using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_6
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    class ShoppingCart
    {
        private Product[] products;
        private int count;

        public ShoppingCart()
        {
            products = new Product[10];
            count = 0;
        }

        public void AddToCart(Product product)
        {
            if (count < 10)
            {
                products[count] = product;
                count++;
                Console.WriteLine("Product added to the shopping cart.");
            }
            else
            {
                Console.WriteLine("Shopping cart is full. Cannot add more products.");
            }
        }

        public void PlaceOrder()
        {
            if (count > 0)
            {
                Console.WriteLine("Order placed for the following products:");
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine($"{products[i].Id}: {products[i].Name} - {products[i].Price}");
                }
                Console.WriteLine("Thank you for your order!");
                count = 0; // Clear the shopping cart after placing the order
            }
            else
            {
                Console.WriteLine("Shopping cart is empty. Cannot place an order.");
            }
        }
    }
}
