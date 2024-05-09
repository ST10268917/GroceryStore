namespace GroceryStore2
{
    partial class AddItemForm
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
            label1 = new Label();
            label2 = new Label();
            nameTB = new TextBox();
            label3 = new Label();
            quantityTB = new TextBox();
            label4 = new Label();
            priceTB = new TextBox();
            label5 = new Label();
            categoryTB = new TextBox();
            addButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Coral;
            label1.Location = new Point(332, 38);
            label1.Name = "label1";
            label1.Size = new Size(113, 31);
            label1.TabIndex = 0;
            label1.Text = "Add Item";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(270, 129);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // nameTB
            // 
            nameTB.Location = new Point(369, 126);
            nameTB.Name = "nameTB";
            nameTB.Size = new Size(125, 27);
            nameTB.TabIndex = 2;
            nameTB.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(270, 196);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 3;
            label3.Text = "Quantity:";
            // 
            // quantityTB
            // 
            quantityTB.Location = new Point(369, 196);
            quantityTB.Name = "quantityTB";
            quantityTB.Size = new Size(125, 27);
            quantityTB.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(270, 259);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 5;
            label4.Text = "Price:";
            // 
            // priceTB
            // 
            priceTB.Location = new Point(369, 259);
            priceTB.Name = "priceTB";
            priceTB.Size = new Size(125, 27);
            priceTB.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(270, 320);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 7;
            label5.Text = "Category:";
            // 
            // categoryTB
            // 
            categoryTB.Location = new Point(369, 317);
            categoryTB.Name = "categoryTB";
            categoryTB.Size = new Size(125, 27);
            categoryTB.TabIndex = 8;
            // 
            // addButton
            // 
            addButton.Location = new Point(332, 389);
            addButton.Name = "addButton";
            addButton.Size = new Size(94, 29);
            addButton.TabIndex = 9;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // AddItemForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(addButton);
            Controls.Add(categoryTB);
            Controls.Add(label5);
            Controls.Add(priceTB);
            Controls.Add(label4);
            Controls.Add(quantityTB);
            Controls.Add(label3);
            Controls.Add(nameTB);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddItemForm";
            Text = "AddItemForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox nameTB;
        private Label label3;
        private TextBox quantityTB;
        private Label label4;
        private TextBox priceTB;
        private Label label5;
        private TextBox categoryTB;
        private Button addButton;
    }
}