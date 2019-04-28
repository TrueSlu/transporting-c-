namespace _1050838_Lu_Sandwich
{
    partial class Form1
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
            this.pepper = new System.Windows.Forms.CheckBox();
            this.pickles = new System.Windows.Forms.CheckBox();
            this.tomato = new System.Windows.Forms.CheckBox();
            this.spinach = new System.Windows.Forms.CheckBox();
            this.lettuce = new System.Windows.Forms.CheckBox();
            this.buttonSummary = new System.Windows.Forms.Button();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.ordersBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.breadBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cheeseBox = new System.Windows.Forms.ComboBox();
            this.meatBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.doneButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pepper
            // 
            this.pepper.AutoSize = true;
            this.pepper.Location = new System.Drawing.Point(270, 280);
            this.pepper.Name = "pepper";
            this.pepper.Size = new System.Drawing.Size(60, 17);
            this.pepper.TabIndex = 28;
            this.pepper.Text = "Pepper";
            this.pepper.UseVisualStyleBackColor = true;
            // 
            // pickles
            // 
            this.pickles.AutoSize = true;
            this.pickles.Location = new System.Drawing.Point(319, 257);
            this.pickles.Name = "pickles";
            this.pickles.Size = new System.Drawing.Size(60, 17);
            this.pickles.TabIndex = 27;
            this.pickles.Text = "Pickles";
            this.pickles.UseVisualStyleBackColor = true;
            // 
            // tomato
            // 
            this.tomato.AutoSize = true;
            this.tomato.Location = new System.Drawing.Point(233, 257);
            this.tomato.Name = "tomato";
            this.tomato.Size = new System.Drawing.Size(62, 17);
            this.tomato.TabIndex = 26;
            this.tomato.Text = "Tomato";
            this.tomato.UseVisualStyleBackColor = true;
            // 
            // spinach
            // 
            this.spinach.AutoSize = true;
            this.spinach.Location = new System.Drawing.Point(319, 234);
            this.spinach.Name = "spinach";
            this.spinach.Size = new System.Drawing.Size(65, 17);
            this.spinach.TabIndex = 25;
            this.spinach.Text = "Spinach";
            this.spinach.UseVisualStyleBackColor = true;
            // 
            // lettuce
            // 
            this.lettuce.AutoSize = true;
            this.lettuce.Location = new System.Drawing.Point(233, 234);
            this.lettuce.Name = "lettuce";
            this.lettuce.Size = new System.Drawing.Size(62, 17);
            this.lettuce.TabIndex = 24;
            this.lettuce.Text = "Lettuce";
            this.lettuce.UseVisualStyleBackColor = true;
            // 
            // buttonSummary
            // 
            this.buttonSummary.Location = new System.Drawing.Point(196, 319);
            this.buttonSummary.Name = "buttonSummary";
            this.buttonSummary.Size = new System.Drawing.Size(78, 45);
            this.buttonSummary.TabIndex = 23;
            this.buttonSummary.Text = "Summary";
            this.buttonSummary.UseVisualStyleBackColor = true;
            this.buttonSummary.Click += new System.EventHandler(this.buttonSummary_Click);
            // 
            // buttonOrder
            // 
            this.buttonOrder.Location = new System.Drawing.Point(301, 319);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(78, 45);
            this.buttonOrder.TabIndex = 22;
            this.buttonOrder.Text = "Order";
            this.buttonOrder.UseVisualStyleBackColor = true;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // ordersBox
            // 
            this.ordersBox.FormattingEnabled = true;
            this.ordersBox.Location = new System.Drawing.Point(437, 150);
            this.ordersBox.Name = "ordersBox";
            this.ordersBox.Size = new System.Drawing.Size(164, 147);
            this.ordersBox.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nameBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.breadBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cheeseBox);
            this.groupBox1.Controls.Add(this.meatBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(177, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 155);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(74, 29);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(106, 20);
            this.nameBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // breadBox
            // 
            this.breadBox.FormattingEnabled = true;
            this.breadBox.Items.AddRange(new object[] {
            "Hearty Italian",
            "9-Grain Honey Oat",
            "Jalapeno Cheese",
            "Monterey Cheddar",
            "Parmesan Oregano",
            "Roasted Garlic",
            "Rosemary & Sea Salt",
            "Rye Bread",
            "Gluten-Free Bread"});
            this.breadBox.Location = new System.Drawing.Point(74, 56);
            this.breadBox.Name = "breadBox";
            this.breadBox.Size = new System.Drawing.Size(106, 21);
            this.breadBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cheese";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bread";
            // 
            // cheeseBox
            // 
            this.cheeseBox.FormattingEnabled = true;
            this.cheeseBox.Items.AddRange(new object[] {
            "Feta",
            "Mozzarella",
            "Cheddar",
            "Pepperjack",
            "Provolone",
            "Swiss"});
            this.cheeseBox.Location = new System.Drawing.Point(74, 110);
            this.cheeseBox.Name = "cheeseBox";
            this.cheeseBox.Size = new System.Drawing.Size(106, 21);
            this.cheeseBox.TabIndex = 6;
            // 
            // meatBox
            // 
            this.meatBox.FormattingEnabled = true;
            this.meatBox.Items.AddRange(new object[] {
            "Black Forest Ham.",
            "Oven Roasted Chicken.",
            "Roast Beef.",
            "Rotisserie-Style Chicken.",
            "Subway Club®",
            "Sweet Onion Chicken Teriyaki.",
            "Turkey Breast.",
            "Veggie Delite®"});
            this.meatBox.Location = new System.Drawing.Point(74, 83);
            this.meatBox.Name = "meatBox";
            this.meatBox.Size = new System.Drawing.Size(106, 21);
            this.meatBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Meat";
            // 
            // doneButton
            // 
            this.doneButton.Location = new System.Drawing.Point(476, 61);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(78, 45);
            this.doneButton.TabIndex = 29;
            this.doneButton.Text = "Exit";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.pepper);
            this.Controls.Add(this.pickles);
            this.Controls.Add(this.tomato);
            this.Controls.Add(this.spinach);
            this.Controls.Add(this.lettuce);
            this.Controls.Add(this.buttonSummary);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.ordersBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Sandwich Shop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox pepper;
        private System.Windows.Forms.CheckBox pickles;
        private System.Windows.Forms.CheckBox tomato;
        private System.Windows.Forms.CheckBox spinach;
        private System.Windows.Forms.CheckBox lettuce;
        private System.Windows.Forms.Button buttonSummary;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.ListBox ordersBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox breadBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cheeseBox;
        private System.Windows.Forms.ComboBox meatBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button doneButton;
    }
}

