namespace HM_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[]
        {
            new Product { Id = 1, Name = "Product 1", Price = 10.99m },
            new Product { Id = 2, Name = "Product 2", Price = 19.99m },
            new Product { Id = 3, Name = "Product 3", Price = 7.99m },
            new Product { Id = 4, Name = "Product 4", Price = 12.49m },
            new Product { Id = 5, Name = "Product 5", Price = 8.99m },
            new Product { Id = 6, Name = "Product 6", Price = 10.99m },
            new Product { Id = 7, Name = "Product 7", Price = 19.99m },
            new Product { Id = 8, Name = "Product 8", Price = 7.99m },
            new Product { Id = 9, Name = "Product 9", Price = 12.49m },
            new Product { Id = 10, Name = "Product 10", Price = 8.99m },
            new Product { Id = 11, Name = "Product 11", Price = 10.99m },
            new Product { Id = 12, Name = "Product 12", Price = 19.99m },
            new Product { Id = 13, Name = "Product 13", Price = 7.99m },
            new Product { Id = 14, Name = "Product 14", Price = 12.49m },
            new Product { Id = 15, Name = "Product 15", Price = 8.99m }
        };

            ShoppingCart cart = new ShoppingCart();
            cart.AddToCart(products[0]);
            cart.AddToCart(products[2]);
            cart.AddToCart(products[4]);
            cart.AddToCart(products[1]);
            cart.AddToCart(products[3]);
            cart.AddToCart(products[5]);
            cart.AddToCart(products[6]);
            cart.AddToCart(products[7]);
            cart.AddToCart(products[10]);
            cart.AddToCart(products[12]);
            cart.AddToCart(products[8]);
            cart.AddToCart(products[9]);

            cart.PlaceOrder();


            Console.ReadLine();
        }
    }
}