using System;
using System.Collections.Generic;

namespace AutoService
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new Dictionary<string, int>();
            var buyers = new Dictionary<string, int>();

            while (true)
            {
                Console.WriteLine("Enter a command:");
                Console.WriteLine("1. Register new product");
                Console.WriteLine("2. Add quantity to existing product");
                Console.WriteLine("3. Sell product");
                Console.WriteLine("4. Register buyer");
                Console.WriteLine("5. Quit");

                var input = Console.ReadLine();

                if (input == "1")
                {
                    Console.WriteLine("Enter the name of the product:");
                    var productName = Console.ReadLine();

                    Console.WriteLine("Enter the quantity:");
                    var quantity = Convert.ToInt32(Console.ReadLine());

                    products[productName] = quantity;

                    Console.WriteLine("Product registered successfully");
                }
                else if (input == "2")
                {
                    Console.WriteLine("Enter the name of the product:");
                    var productName = Console.ReadLine();

                    if (products.ContainsKey(productName))
                    {
                        Console.WriteLine("Enter the quantity to add:");
                        var quantity = Convert.ToInt32(Console.ReadLine());

                        products[productName] += quantity;

                        Console.WriteLine("Quantity added successfully");
                    }
                    else
                    {
                        Console.WriteLine("Product not found");
                    }
                }
                else if (input == "3")
                {
                    Console.WriteLine("Enter the name of the product:");
                    var productName = Console.ReadLine();

                    Console.WriteLine("Enter the buyer's name:");
                    var buyerName = Console.ReadLine();

                    if (products.ContainsKey(productName) && buyers.ContainsKey(buyerName))
                    {
                        Console.WriteLine("Enter the quantity to sell:");
                        var quantity = Convert.ToInt32(Console.ReadLine());

                        if (products[productName] >= quantity)
                        {
                            products[productName] -= quantity;
                            buyers[buyerName] += quantity;

                            Console.WriteLine("Sell successful");
                        }
                        else
                        {
                            Console.WriteLine("Not enough quantity in stock");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Product or buyer not found");
                    }
                }
                else if (input == "4")
                {
                    Console.WriteLine("Enter the buyer's name:");
                    var buyerName = Console.ReadLine();

                    buyers[buyerName] = 0;

                    Console.WriteLine("Buyer registered successfully");
                }
                else if (input == "5")
                {
                    break;
                }
            }
        }
    }
}
