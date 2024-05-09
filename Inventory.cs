using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Windows.Forms;


namespace GroceryStore2
{
    internal class Inventory
    {
        
        public static Dictionary<string, List<InventoryItem>> inventoryItems = new Dictionary<string, List<InventoryItem>>();

        public static Stack<InventoryItem> inventoryStack = new Stack<InventoryItem>();

        public static Queue<InventoryItem> restockQueue = new Queue<InventoryItem>();

        public static void AddItem(InventoryItem item)
        {
            if (inventoryItems.ContainsKey(item.Category))
            {
                inventoryItems[item.Category].Add(item);
                inventoryStack.Push(item);
            }
            else
            {
                inventoryItems.Add(item.Category, new List<InventoryItem>());
                inventoryItems[item.Category].Add(item);
            }
        }

        public static void RemoveItem(InventoryItem item)
        {
            inventoryItems[item.Category].Remove(item);
            if (inventoryStack.Count > 0 && inventoryStack.Peek().Equals(item))
            {
                inventoryStack.Pop();
            }
        }


        public static void DisplayInventory()
        {
            StringBuilder sb = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();

                foreach (var category in inventoryItems)
                {
                    sb.AppendLine($"Category: {category.Key}");

                    foreach (var item in category.Value)
                    {
                        sb.AppendLine($"- Name: {item.Name}, Price: R{item.Price}, Quantity: {item.Quantity}");
                        if (item.Quantity <= 10)
                        {
                            restockQueue.Enqueue(item);
                            sb2.AppendLine($"{item.Name} added to restock queue.");
                        }
                    }
                    sb.AppendLine(); 
                }

                MessageBox.Show(sb.ToString(), "Inventory Items", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(sb2.ToString(), "Restocking", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
