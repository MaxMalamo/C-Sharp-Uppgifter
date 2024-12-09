using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFieldsExerciseInC_
{
    class Product
    {
        private string name;

        private double price;

        private int stock;

        public Product(string name, double price, int stock)
        {
            this.name = name;
            this.price = price;
            this.stock = stock;
        }

        // Gets name
        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        // Gets price
        public void SetPrice(double price)
        {
            this.price = price;
        }

        public double GetPrice()
        {
            return price;
        }

        // Gets stock
        public void SetStock(int stock)
        {
            this.stock = stock;
        }

        public int GetStock()
        {
            return stock;
        }

        // Product details
        public string GetDetails()
        {
            return $"Name: {name}, Price: {price}, Stock: {stock}";
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Product product = new Product("Phone", 599, 5);

                Console.WriteLine("Initial product details:");
                Console.WriteLine(product.GetDetails());

                product.SetName("Laptop");
                product.SetPrice(999.99);
                product.SetStock(10);

                Console.WriteLine("Updated product details:");
                Console.WriteLine(product.GetDetails());

                Console.ReadLine();
            }
        }
    }
}
