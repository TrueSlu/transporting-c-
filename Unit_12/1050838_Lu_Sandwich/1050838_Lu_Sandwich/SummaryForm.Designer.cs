namespace _1050838_Lu_Sandwich
{
    partial class SummaryForm
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
            this.buttonDone = new System.Windows.Forms.Button();
            this.orders = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxPepper = new System.Windows.Forms.CheckBox();
            this.checkBoxPickles = new System.Windows.Forms.CheckBox();
            this.checkBoxTomato = new System.Windows.Forms.CheckBox();
            this.checkBoxSpinach = new System.Windows.Forms.CheckBox();
            this.checkBoxLuttuce = new System.Windows.Forms.CheckBox();
            this.cheeseBox = new System.Windows.Forms.TextBox();
            this.meatBox = new System.Windows.Forms.TextBox();
            this.breadBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelCheese = new System.Windows.Forms.Label();
            this.labelBread = new System.Windows.Forms.Label();
            this.labelMeat = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDone
            // 
            this.buttonDone.Location = new System.Drawing.Point(48, 249);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(164, 50);
            this.buttonDone.TabIndex = 19;
            this.buttonDone.Text = "Done";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click_1);
            // 
            // orders
            // 
            this.orders.FormattingEnabled = true;
            this.orders.Location = new System.Drawing.Point(299, 44);
            this.orders.Name = "orders";
            this.orders.Size = new System.Drawing.Size(164, 251);
            this.orders.TabIndex = 18;
            this.orders.SelectedIndexChanged += new System.EventHandler(this.listBoxOrders_SelectedIndexChanged_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxPepper);
            this.groupBox1.Controls.Add(this.checkBoxPickles);
            this.groupBox1.Controls.Add(this.checkBoxTomato);
            this.groupBox1.Controls.Add(this.checkBoxSpinach);
            this.groupBox1.Controls.Add(this.checkBoxLuttuce);
            this.groupBox1.Controls.Add(this.cheeseBox);
            this.groupBox1.Controls.Add(this.meatBox);
            this.groupBox1.Controls.Add(this.breadBox);
            this.groupBox1.Controls.Add(this.nameBox);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Controls.Add(this.labelCheese);
            this.groupBox1.Controls.Add(this.labelBread);
            this.groupBox1.Controls.Add(this.labelMeat);
            this.groupBox1.Location = new System.Drawing.Point(34, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 200);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order";
            // 
            // checkBoxPepper
            // 
            this.checkBoxPepper.AutoSize = true;
            this.checkBoxPepper.Location = new System.Drawing.Point(37, 170);
            this.checkBoxPepper.Name = "checkBoxPepper";
            this.checkBoxPepper.Size = new System.Drawing.Size(60, 17);
            this.checkBoxPepper.TabIndex = 24;
            this.checkBoxPepper.Text = "Pepper";
            this.checkBoxPepper.UseVisualStyleBackColor = true;
            // 
            // checkBoxPickles
            // 
            this.checkBoxPickles.AutoSize = true;
            this.checkBoxPickles.Location = new System.Drawing.Point(74, 147);
            this.checkBoxPickles.Name = "checkBoxPickles";
            this.checkBoxPickles.Size = new System.Drawing.Size(60, 17);
            this.checkBoxPickles.TabIndex = 23;
            this.checkBoxPickles.Text = "Pickles";
            this.checkBoxPickles.UseVisualStyleBackColor = true;
            // 
            // checkBoxTomato
            // 
            this.checkBoxTomato.AutoSize = true;
            this.checkBoxTomato.Location = new System.Drawing.Point(6, 147);
            this.checkBoxTomato.Name = "checkBoxTomato";
            this.checkBoxTomato.Size = new System.Drawing.Size(62, 17);
            this.checkBoxTomato.TabIndex = 22;
            this.checkBoxTomato.Text = "Tomato";
            this.checkBoxTomato.UseVisualStyleBackColor = true;
            // 
            // checkBoxSpinach
            // 
            this.checkBoxSpinach.AutoSize = true;
            this.checkBoxSpinach.Location = new System.Drawing.Point(74, 124);
            this.checkBoxSpinach.Name = "checkBoxSpinach";
            this.checkBoxSpinach.Size = new System.Drawing.Size(65, 17);
            this.checkBoxSpinach.TabIndex = 21;
            this.checkBoxSpinach.Text = "Spinach";
            this.checkBoxSpinach.UseVisualStyleBackColor = true;
            // 
            // checkBoxLuttuce
            // 
            this.checkBoxLuttuce.AutoSize = true;
            this.checkBoxLuttuce.Location = new System.Drawing.Point(6, 124);
            this.checkBoxLuttuce.Name = "checkBoxLuttuce";
            this.checkBoxLuttuce.Size = new System.Drawing.Size(62, 17);
            this.checkBoxLuttuce.TabIndex = 20;
            this.checkBoxLuttuce.Text = "Lettuce";
            this.checkBoxLuttuce.UseVisualStyleBackColor = true;
            // 
            // cheeseBox
            // 
            this.cheeseBox.Location = new System.Drawing.Point(60, 100);
            this.cheeseBox.Name = "cheeseBox";
            this.cheeseBox.ReadOnly = true;
            this.cheeseBox.Size = new System.Drawing.Size(98, 20);
            this.cheeseBox.TabIndex = 13;
            // 
            // meatBox
            // 
            this.meatBox.Location = new System.Drawing.Point(60, 73);
            this.meatBox.Name = "meatBox";
            this.meatBox.ReadOnly = true;
            this.meatBox.Size = new System.Drawing.Size(98, 20);
            this.meatBox.TabIndex = 12;
            // 
            // breadBox
            // 
            this.breadBox.Location = new System.Drawing.Point(60, 46);
            this.breadBox.Name = "breadBox";
            this.breadBox.ReadOnly = true;
            this.breadBox.Size = new System.Drawing.Size(98, 20);
            this.breadBox.TabIndex = 11;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(60, 19);
            this.nameBox.Name = "nameBox";
            this.nameBox.ReadOnly = true;
            this.nameBox.Size = new System.Drawing.Size(98, 20);
            this.nameBox.TabIndex = 10;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(11, 22);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // labelCheese
            // 
            this.labelCheese.AutoSize = true;
            this.labelCheese.Location = new System.Drawing.Point(11, 103);
            this.labelCheese.Name = "labelCheese";
            this.labelCheese.Size = new System.Drawing.Size(43, 13);
            this.labelCheese.TabIndex = 7;
            this.labelCheese.Text = "Cheese";
            // 
            // labelBread
            // 
            this.labelBread.AutoSize = true;
            this.labelBread.Location = new System.Drawing.Point(11, 49);
            this.labelBread.Name = "labelBread";
            this.labelBread.Size = new System.Drawing.Size(35, 13);
            this.labelBread.TabIndex = 3;
            this.labelBread.Text = "Bread";
            // 
            // labelMeat
            // 
            this.labelMeat.AutoSize = true;
            this.labelMeat.Location = new System.Drawing.Point(11, 76);
            this.labelMeat.Name = "labelMeat";
            this.labelMeat.Size = new System.Drawing.Size(31, 13);
            this.labelMeat.TabIndex = 5;
            this.labelMeat.Text = "Meat";
            // 
            // SummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.orders);
            this.Controls.Add(this.groupBox1);
            this.Name = "SummaryForm";
            this.Text = "SummaryForm";
            this.Load += new System.EventHandler(this.SummaryForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.ListBox orders;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxPepper;
        private System.Windows.Forms.CheckBox checkBoxPickles;
        private System.Windows.Forms.CheckBox checkBoxTomato;
        private System.Windows.Forms.CheckBox checkBoxSpinach;
        private System.Windows.Forms.CheckBox checkBoxLuttuce;
        private System.Windows.Forms.TextBox cheeseBox;
        private System.Windows.Forms.TextBox meatBox;
        private System.Windows.Forms.TextBox breadBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCheese;
        private System.Windows.Forms.Label labelBread;
        private System.Windows.Forms.Label labelMeat;
    }
}