using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GroceryStore2
{
    public partial class RemoveItemForm : Form
    {
        public event EventHandler ItemRemovedOrNotFound;
        public event EventHandler DictEmpty;
        string itemToRemove;
        public RemoveItemForm()
        {
            InitializeComponent();
            
        }

        private void RemoveItemForm_Load(object sender, EventArgs e)
        {
            inventoryListBox.Items.Clear();
            bool isEmpty = true;  // Assume the inventory is empty until proven otherwise

            // Loop through the dictionary
            foreach (KeyValuePair<string, List<InventoryItem>> kvp in Inventory.inventoryItems)
            {
                // Check if the list of InventoryItem objects is not empty
                if (kvp.Value.Count > 0)
                {
                    isEmpty = false;  // Found at least one item, so not empty
                    foreach (InventoryItem item in kvp.Value)
                    {
                        // Add the item's name to the ListBox
                        inventoryListBox.Items.Add(item.Name);
                    }
                }
            }

            // If after checking all entries, it is still true that it's empty
            if (isEmpty)
            {
                MessageBox.Show("The inventory is empty.", "No Inventory Items", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DictEmpty?.Invoke(this, EventArgs.Empty);
            }
        }


        private void inventoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (inventoryListBox.SelectedItem == null)
            {
                MessageBox.Show("Please select an item from the list.");
                return; 
            }
            string itemToRemoveName = inventoryListBox.SelectedItem.ToString();
            InventoryItem itemToRemove = null;
            foreach (var category in Inventory.inventoryItems)
            {
                // Search for the item in the list
                itemToRemove = category.Value.FirstOrDefault(item => item.Name == itemToRemoveName);

                // If found, break out of the loop
                if (itemToRemove != null)
                    break;
            }
            if (itemToRemove != null)
            {
                // Pass the InventoryItem object to the RemoveItem method
                Inventory.RemoveItem(itemToRemove);  // Assuming 'inventory' is your Inventory class instance
                MessageBox.Show("Removed: " + itemToRemove.Name);
            }
            else
            {
                MessageBox.Show("Item not found.");
            }
            ItemRemovedOrNotFound?.Invoke(this, EventArgs.Empty);
        }

    }
}
