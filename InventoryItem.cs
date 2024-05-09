using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore2
{
    internal class InventoryItem
    {
        public string Name { get; set; }
        public string Price { get; set; }
        public int? Quantity { get; set; }
        public string Category { get; set; }

        public InventoryItem(string name, string price, int? quantity, string category)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            Category = category;
        }
    }
}
