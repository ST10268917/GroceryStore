using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.DataFormats;

namespace GroceryStore2
{
    public partial class AddItemForm : Form
    {
        public event EventHandler ItemAdded;

        public AddItemForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string name = nameTB.Text;
            int? quantity = null;
            string quantityAsString = quantityTB.Text;
            if (ErrorHandler.checkIfInt(quantityAsString) == true)
            {
                quantity = Int32.Parse(quantityTB.Text);
            }
            else
            {
                MessageBox.Show("Please enter an integer value for quantity!");
            }

            string price = priceTB.Text;
           


            string category = categoryTB.Text.ToUpper();

            if (InputValidator.checkIfEmpty(name) && InputValidator.checkIfEmpty(quantity) && InputValidator.checkIfEmpty(price) && InputValidator.ContainsDigits(price) && InputValidator.checkIfEmpty(category))
            {
                InventoryItem inventoryItem = new InventoryItem(name, price, quantity, category);
                Inventory.AddItem(inventoryItem);
                MessageBox.Show("Item Added Successfully!");
                ItemAdded?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("Please fill out all values correctly!");
            }


            

            
        }
    }
}
