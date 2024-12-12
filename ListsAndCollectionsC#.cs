using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Jag var tvungen att googla ganska mycket hjälp för den här uppgiften

namespace ListsAndCollectionsC_
{
    class Inventory
    {
        private List<string> items = new List<string>();
        private Dictionary<string, (double price, int stock)> itemDetails = new Dictionary<string, (double price, int stock)>();
        public void AddItem(string name, double price, int stock)
        {
            items.Add(name);
            itemDetails[name] = (price, stock);
        }

        public void RemoveItem(string name)
        {
            if (items.Contains(name))
            {
                items.Remove(name);
                itemDetails.Remove(name);
                Console.WriteLine($"{name} has been removed from the inventory.");
            }
            else
            {
                Console.WriteLine($"{name} not found in the inventory.");
            }
        }

        public void UpdateStock(string name, int newStock)
        {
            if (itemDetails.ContainsKey(name))
            {
                var (price, _) = itemDetails[name];
                itemDetails[name] = (price, newStock);
                Console.WriteLine($"Stock of {name} updated to {newStock}.");
            }
            else
            {
                Console.WriteLine($"{name} not found in the inventory.");
            }
        }

        public void PrintAllItems()
        {
            Console.WriteLine("Current Inventory:");
            foreach (var name in items)
            {
                var (price, stock) = itemDetails[name];
                Console.WriteLine($"Product: {name}, Price: {price}, Stock: {stock}");
            }
        }
        public void PrintMostExpensiveItem()
        {
            if (itemDetails.Count > 0)
            {
                var mostExpensive = itemDetails.OrderByDescending(x => x.Value.price).First();
                Console.WriteLine($"Most expensive item: {mostExpensive.Key}, Price: {mostExpensive.Value.price}");
            }
            else
            {
                Console.WriteLine("Inventory is empty.");
            }
        }

        public void PrintTotalInventoryValue()
        {
            double totalValue = itemDetails.Sum(x => x.Value.price * x.Value.stock);
            Console.WriteLine($"Total Inventory Value: {totalValue:F2}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();

            inventory.AddItem("Laptop", 1200.50, 7);
            inventory.AddItem("Smartphone", 799.99, 12);
            inventory.AddItem("Tablet", 399.99, 15);

            inventory.PrintAllItems();

            inventory.UpdateStock("Laptop", 5);

            inventory.RemoveItem("Tablet");

            inventory.PrintMostExpensiveItem();

            inventory.PrintTotalInventoryValue();

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
