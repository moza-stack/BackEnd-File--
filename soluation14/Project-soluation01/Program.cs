#region E-Commerce System


using System;
using System.Collections.Generic;
using System.IO;

class Product
{
    public int Id;
    public string Name = "";  
    public double Price;
    public int Quantity;
}

class Program
{
    static List<Product> products = new List<Product>();
    static List<Product> cart = new List<Product>();

    static void Main()
    {
        int choice = 0;

        do
        {
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. View All Products");
            Console.WriteLine("3. Search Product");
            Console.WriteLine("4. Add to Cart");
            Console.WriteLine("5. View Cart");
            Console.WriteLine("6. Checkout");
            Console.WriteLine("7. Exit");

            choice = ReadInt("Enter choice");

            switch (choice)
            {
                case 1: AddProduct(); break;
                case 2: ViewProducts(); break;
                case 3: SearchMenu(); break;
                case 4: AddToCartMenu(); break;
                case 5: ViewCart(); break;
                case 6: Checkout(); break;
                case 7: SaveToFile(); break;
                default: Console.WriteLine("Invalid choice"); break;
            }

        } while (choice != 7);
    }

    //  
    static int ReadInt(string message)
    {
        while (true)
        {
            Console.Write(message);
            string input = Console.ReadLine() ?? "";

            int number = 0;
            bool isValid = true;

            foreach (char c in input)
            {
                if (c < '0' || c > '9')
                {
                    isValid = false;
                    break;
                }

                number = number * 10 + (c - '0');
            }

            if (isValid && input.Length > 0)
                return number;

            Console.WriteLine("Invalid number, try again");
        }
    }

    static double ReadDouble(string message)
    {
        while (true)
        {
            Console.Write(message);
            string input = Console.ReadLine() ?? "";

            double number = 0;
            double decimalPart = 0;
            double divisor = 10;

            bool isDecimal = false;
            bool isValid = true;

            foreach (char c in input)
            {
                if (c == '.')
                {
                    if (isDecimal)
                    {
                        isValid = false;
                        break;
                    }
                    isDecimal = true;
                    continue;
                }

                if (c < '0' || c > '9')
                {
                    isValid = false;
                    break;
                }

                if (!isDecimal)
                {
                    number = number * 10 + (c - '0');
                }
                else
                {
                    decimalPart += (c - '0') / divisor;
                    divisor *= 10;
                }
            }

            if (isValid && input.Length > 0)
                return number + decimalPart;

            Console.WriteLine("Invalid number, try again!");
        }
    }

    // Add Product 
    static void AddProduct()
    {
        Product p = new Product();

        p.Id = ReadInt("Id");

        Console.Write("Name");
        p.Name = Console.ReadLine() ?? ""; 

        p.Price = ReadDouble("Price");

        p.Quantity = ReadInt("Quantity");

        products.Add(p);
        Console.WriteLine("Product added successfully!");
    }

    // View Products
    static void ViewProducts()
    {
        foreach (var p in products)
        {
            Console.WriteLine($"Id: {p.Id}, Name: {p.Name}, Price: {p.Price}, Qty: {p.Quantity}");
        }
    }

    // Search 
    static void SearchMenu()
    {
        Console.WriteLine("1. Search by Id");
        Console.WriteLine("2. Search by Name");

        int choice = ReadInt("Enter choice");

        if (choice == 1)
        {
            int id = ReadInt("Enter Id");

            if (SearchProduct(id, out Product? result)) 
                PrintProduct(result!);
            else
                Console.WriteLine("Product not found");
        }
        else
        {
            Console.Write("Enter Name");
            string? name = Console.ReadLine(); 

            var result = SearchProduct(name!);

            if (result != null)
                PrintProduct(result);
            else
                Console.WriteLine("Product not found");
        }
    }

    // Overload 1
    static bool SearchProduct(int id, out Product? found) 
    {
        foreach (var p in products)
        {
            if (p.Id == id)
            {
                found = p;
                return true;
            }
        }

        found = null; 
        return false;
    }

    // Overload 2
    static Product? SearchProduct(string name) 
    {
        foreach (var p in products)
        {
            if (p.Name.ToLower() == name.ToLower())
                return p;
        }
        return null;
    }

    static void PrintProduct(Product p)
    {
        Console.WriteLine($"Product: {p.Name}, Price: {p.Price}, Quantity: {p.Quantity}");
    }

    // Add To Cart 
    static void AddToCartMenu()
    {
        int id = ReadInt("Enter Product Id ");
        int qty = ReadInt("Enter Quantity");

        AddToCart(id, qty);
    }

    static void AddToCart(int productId, int quantity)
    {
        if (SearchProduct(productId, out Product? p))
        {
            if (p != null && p.Quantity >= quantity)
            {
                UpdateQuantity(ref p.Quantity, quantity);

                cart.Add(new Product
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price,
                    Quantity = quantity
                });

                Console.WriteLine("Added to cart");
            }
            else
            {
                Console.WriteLine("Not enough quantity");
            }
        }
        else
        {
            Console.WriteLine("Product not found");
        }
    }

    // ref
    static void UpdateQuantity(ref int stock, int qty)
    {
        stock -= qty;
    }

    //  View Cart (Recursion) 
    static void ViewCart()
    {
        if (cart.Count == 0)
        {
            Console.WriteLine("Cart is empty");
            return;
        }

        PrintCartRecursive(0);
    }

    static void PrintCartRecursive(int index)
    {
        if (index >= cart.Count)
            return;

        var p = cart[index];

        Console.WriteLine($"Product: {p.Name}, Qty: {p.Quantity}, Price: {p.Price}");

        PrintCartRecursive(index + 1);
    }

    //  Checkout 
    static void Checkout()
    {
        double total = 0;

        foreach (var item in cart)
        {
            total += item.Price * item.Quantity;
        }

        Console.WriteLine($"Total Price = {total}");

        cart.Clear();
    }

    // File Handling 
    static void SaveToFile()
    {
        using (StreamWriter sw = new StreamWriter("products.txt"))
        {
            foreach (var p in products)
            {
                sw.WriteLine($"{p.Id},{p.Name},{p.Price},{p.Quantity}");
            }
        }

        Console.WriteLine("Saved to file");
#endregion
    }
}
