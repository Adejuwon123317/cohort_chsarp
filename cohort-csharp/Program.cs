// See https://aka.ms/new-console-template for more information
using System.Net.Http.Headers;

namespace cohort_csharp
{
    /// <summary>
    /// This class allows the user to add, remove,and view the cart
    /// </summary>
    class program
    {
        /// <summary>
        /// This method contains the list of the products available 
        /// </summary>
        public static void Main()
        {
            List<Product> products = new List<Product>()
            {
                new Product(1, "Shoes", 50000),
                new Product(2, "Earpods", 12000),
                new Product(3, "Headphones", 25000),
                new Product(4, "Jerseys", 15000),
                new Product(5, "Scrunchies", 3000),
                new Product(6, "Snack box", 4000),
                new Product(7, "Electric Fan", 15000),
                new Product(8, "Electric Kettle", 20000),
                new Product(9, "Saxophone", 100000),
                new Product(10, "shirt", 12000)
            };
            List<Product> carts = new List<Product>();
            while (true)
            {
                Console.WriteLine("\t\t\t Welcome To Phantom Stores");
                Console.WriteLine("\t\t\t SHOP MENU \t\t\t\n");
                Console.WriteLine("1.\tView Products\n");
                Console.WriteLine("2.\tAdd Products\n");
                Console.WriteLine("3.\tRemove Products\n");
                Console.WriteLine("4.\tView Cart\n");
                Console.WriteLine("5.\tTotal price  \n");
                Console.WriteLine("6.\tExit\n");

                Console.WriteLine("Enter an option: ");
                string choice = Console.ReadLine();
                
                if (choice == "1")
                {
                    ViewProducts(products);
                }
                else if (choice == "2")
                {
                    AddProducts(products, carts);
                }
                else if (choice == "3")
                {
                    RemoveProduct(carts);
                }
                else if (choice == "4")
                {
                    ViewCart(carts);
                }
                else if (choice == "5")
                {
                    double total = carts.Sum(p => p.Price);
                    Console.WriteLine($"\nTotal Price: ${total}");
                }
                else if (choice == "6")
                {
                    Console.WriteLine("Thank You For Shopping At PHANTOM STORES");
                    break;
                }
            }
            
        }
        public static void ViewProducts(List<Product> products)
        {
            Console.WriteLine("\t\t Available products\t\t\n");
            foreach (var p in products)
            {
                Console.WriteLine($"{p.Id}. {p.Name} - {p.Price}");
            } 
        }
        public static void AddProducts(List<Product> products, List<Product> carts)
        {
            ViewProducts(products);
            Console.WriteLine("Enter the id of the product you want to add");
            int id = int.Parse(Console.ReadLine());

            Product product = products.Find(p => p.Id == id);
            if (product != null)
            {
                carts.Add(product);
                Console.WriteLine($"\n{product.Name} has been added to your cart");
            }
            else
            {
                Console.WriteLine("Invalid Product Id");
            }
        }
        public static void RemoveProduct(List<Product> carts)
        {
            ViewCart(carts);
            Console.WriteLine("\nEnter The Product Id To Remove: ");
            int id = int.Parse(Console.ReadLine());

            Product product = carts.FirstOrDefault(p => p.Id == id);
            if (product != null) 
            {
                carts.Remove(product);
                Console.WriteLine($"{product.Name} Has Been Removed From Your Cart");
            }
            else
            {
                Console.WriteLine("Product Not Found In Cart");
            }
        }
        public static void ViewCart(List<Product> carts)
        {
            Console.WriteLine("\n\tYour Cart: ");
            if (carts.Count == 0)
            {
                Console.WriteLine("Cart Is Empty");
                return;
            }
            foreach (var p in carts)
            {
                Console.WriteLine($"{p.Id}. {p.Name} - ${p.Price}");
            }
        }
    }
}

