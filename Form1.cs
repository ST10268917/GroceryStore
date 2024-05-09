namespace GroceryStore2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Inventory.DisplayInventory();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddItemForm form2 = new AddItemForm();

            form2.ItemAdded += (s, args) =>
            {
                form2.Close(); 
            };
            form2.Show();
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            RemoveItemForm form3 = new RemoveItemForm();
            form3.DictEmpty += (s, args) =>
            {
                form3.Close();
            };
            form3.ItemRemovedOrNotFound += (s, args) =>
            {
                form3.Close(); 
            }; 
            form3.Show();
        }
    }
}
