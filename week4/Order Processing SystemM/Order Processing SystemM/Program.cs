using System;
using System.Collections.Generic;

namespace Project_Solution01
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // CUSTOMER
           
            Customer customer = new Customer(
                "1",
                "Moza",
                "Moza@email.com"
            );

            
            // PRODUCTS
            
            Product p1 = new ElectronicsProduct(
                "1",
                "Laptop",
                1000,
                5
            );

            Product p2 = new ClothingProduct(
                "2",
                "T-Shirt",
                50,
                10
            );

            
            // ORDER
            
            Order order = new Order("100", customer);

            order.AddProduct(p1, 1);
            order.AddProduct(p2, 2);

            
            // PAYMENT
            
            order.SetPayment(new CashPayment());

          
            // PROCESS ORDER
            
            order.ProcessOrder();

            
            // PRINT SUMMARY
           
            order.PrintSummary();

            Console.ReadKey();
        }
    }

    
    // ENUM
    
    public enum OrderStatus
    {
        Pending,
        Processing,
        Shipped,
        Delivered
    }

    
    // INTERFACES
    
    public interface IPayable
    {
        void Pay(decimal amount);
    }

    public interface IShippable
    {
        void Ship();
    }

    
    // CUSTOMER
    
    public class Customer
    {
        public string Id { get; private set; }

        public string Name { get; private set; }

        public string Email { get; private set; }

        public List<Order> Orders { get; private set; }

        public Customer(string id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;

            Orders = new List<Order>();
        }
    }

  
    // PRODUCT (ABSTRACTION)
    
    public abstract class Product
    {
        public string Id { get; private set; }

        public string Name { get; private set; }

        public decimal Price { get; protected set; }

        public int StockQuantity { get; set; }

        public Product(
            string id,
            string name,
            decimal price,
            int stockQuantity)
        {
            Id = id;
            Name = name;
            Price = price;
            StockQuantity = stockQuantity;
        }

        public virtual decimal CalculatePrice()
        {
            return Price;
        }
    }

    // ELECTRONICS PRODUCT
    
    public class ElectronicsProduct : Product
    {
        public ElectronicsProduct(
            string id,
            string name,
            decimal price,
            int stockQuantity)
            : base(id, name, price, stockQuantity)
        {
        }

        public override decimal CalculatePrice()
        {
            // 10% extra fee
            return Price * 1.10m;
        }
    }

    
    // CLOTHING PRODUCT
    
    public class ClothingProduct : Product
    {
        public ClothingProduct(
            string id,
            string name,
            decimal price,
            int stockQuantity)
            : base(id, name, price, stockQuantity)
        {
        }

        public override decimal CalculatePrice()
        {
            // 5% discount
            return Price * 0.95m;
        }
    }

    
    // ORDER ITEM
   
    public class OrderItem
    {
        public Product Product { get; private set; }

        public int Quantity { get; private set; }

        public decimal SubTotal
        {
            get
            {
                return Product.CalculatePrice() * Quantity;
            }
        }

        public OrderItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }
    }

    
    // PAYMENT (ABSTRACTION)
    
    public abstract class Payment : IPayable
    {
        public abstract void Pay(decimal amount);
    }

    // CASH PAYMENT
    
    public class CashPayment : Payment
    {
        public override void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount:C} using Cash.");
        }
    }

    
    // CREDIT CARD PAYMENT
    
    public class CreditCardPayment : Payment
    {
        public override void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount:C} using Credit Card.");
        }
    }

    
    // PAYPAL PAYMENT
    
    public class PaypalPayment : Payment
    {
        public override void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount:C} using PayPal.");
        }
    }

    
    // ORDER
    
    public class Order : IShippable
    {
        public string Id { get; private set; }

        public Customer Customer { get; private set; }

        public List<OrderItem> Items { get; private set; }

        public decimal TotalPrice { get; private set; }

        public OrderStatus Status { get; private set; }

        private Payment payment;

        public Order(string id, Customer customer)
        {
            Id = id;
            Customer = customer;

            Status = OrderStatus.Pending;

            Items = new List<OrderItem>();

            // Add order to customer
            customer.Orders.Add(this);
        }

        
        // ADD PRODUCT
        
        public void AddProduct(Product product, int quantity)
        {
            if (product.StockQuantity < quantity)
            {
                Console.WriteLine(
                    $"Not enough stock for {product.Name}"
                );

                return;
            }

            product.StockQuantity -= quantity;

            Items.Add(new OrderItem(product, quantity));

            Console.WriteLine(
                $"{product.Name} added successfully."
            );
        }

        
        // CALCULATE TOTAL
        
        public void CalculateTotal()
        {
            TotalPrice = 0;

            foreach (OrderItem item in Items)
            {
                TotalPrice += item.SubTotal;
            }
        }

        
        // SET PAYMENT
        
        public void SetPayment(Payment paymentMethod)
        {
            payment = paymentMethod;
        }

        // PROCESS ORDER
        
        public void ProcessOrder()
        {
            if (payment == null)
            {
                Console.WriteLine(
                    "Payment method not selected!"
                );

                return;
            }

            Console.WriteLine("\nProcessing Order...");

            Status = OrderStatus.Processing;

            CalculateTotal();

            payment.Pay(TotalPrice);

            Ship();
        }

        
        // SHIP ORDER
        
        public void Ship()
        {
            Console.WriteLine("Shipping Order...");

            Status = OrderStatus.Shipped;
        }

        
        // DELIVER ORDER
       
        public void Deliver()
        {
            Console.WriteLine("Order Delivered.");

            Status = OrderStatus.Delivered;
        }

        
        // PRINT SUMMARY
        
        public void PrintSummary()
        {
            Console.WriteLine("\n=======");
            Console.WriteLine("        ORDER SUMMARY         ");
            Console.WriteLine("=========");

            Console.WriteLine($"Order ID : {Id}");
            Console.WriteLine($"Customer : {Customer.Name}");
            Console.WriteLine($"Email    : {Customer.Email}");
            Console.WriteLine($"Status   : {Status}");
            Console.WriteLine($"Total    : {TotalPrice:C}");

            Console.WriteLine("\nItems:");

            foreach (OrderItem item in Items)
            {
                Console.WriteLine(
                    $"{item.Product.Name} x{item.Quantity}" +
                    $" = {item.SubTotal:C}"
                );
            }

            Console.WriteLine("======");
        }
    }
}