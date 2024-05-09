namespace GroceryStore2
{
    partial class RemoveItemForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            inventoryListBox = new ListBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(249, 129);
            label2.Name = "label2";
            label2.Size = new Size(283, 20);
            label2.TabIndex = 4;
            label2.Text = "Select the item you would like to remove:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Coral;
            label1.Location = new Point(310, 47);
            label1.Name = "label1";
            label1.Size = new Size(154, 31);
            label1.TabIndex = 3;
            label1.Text = "Remove Item";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(250, 109);
            label3.Name = "label3";
            label3.Size = new Size(282, 20);
            label3.TabIndex = 6;
            label3.Text = "The following items are in your inventory:";
            // 
            // inventoryListBox
            // 
            inventoryListBox.FormattingEnabled = true;
            inventoryListBox.Location = new Point(326, 175);
            inventoryListBox.Name = "inventoryListBox";
            inventoryListBox.Size = new Size(150, 104);
            inventoryListBox.TabIndex = 7;
            inventoryListBox.SelectedIndexChanged += inventoryListBox_SelectedIndexChanged;
            // 
            // RemoveItemForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(inventoryListBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RemoveItemForm";
            Text = "RemoveItemForm";
            Load += RemoveItemForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private Label label3;
        private ListBox inventoryListBox;
    }
}