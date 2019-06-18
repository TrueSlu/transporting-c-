namespace _1050838_Lu_11._2
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
            this.labelPay = new System.Windows.Forms.Label();
            this.payBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.rateBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.hoursBox = new System.Windows.Forms.TextBox();
            this.labelHours = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.employeesBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.employeeGroup = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label = new System.Windows.Forms.Label();
            this.employeeGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPay
            // 
            this.labelPay.AutoSize = true;
            this.labelPay.Location = new System.Drawing.Point(13, 74);
            this.labelPay.Name = "labelPay";
            this.labelPay.Size = new System.Drawing.Size(25, 13);
            this.labelPay.TabIndex = 30;
            this.labelPay.Text = "Pay";
            // 
            // payBox
            // 
            this.payBox.Location = new System.Drawing.Point(70, 67);
            this.payBox.Name = "payBox";
            this.payBox.ReadOnly = true;
            this.payBox.Size = new System.Drawing.Size(100, 20);
            this.payBox.TabIndex = 29;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(533, 162);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 28;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(318, 162);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 27;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click_1);
            // 
            // rateBox
            // 
            this.rateBox.Location = new System.Drawing.Point(70, 78);
            this.rateBox.Name = "rateBox";
            this.rateBox.Size = new System.Drawing.Size(100, 20);
            this.rateBox.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Rate";
            // 
            // hoursBox
            // 
            this.hoursBox.Location = new System.Drawing.Point(70, 23);
            this.hoursBox.Name = "hoursBox";
            this.hoursBox.Size = new System.Drawing.Size(100, 20);
            this.hoursBox.TabIndex = 24;
            // 
            // labelHours
            // 
            this.labelHours.AutoSize = true;
            this.labelHours.Location = new System.Drawing.Point(13, 26);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(35, 13);
            this.labelHours.TabIndex = 23;
            this.labelHours.Text = "Hours";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(121, 162);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 22;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // employeesBox
            // 
            this.employeesBox.FormattingEnabled = true;
            this.employeesBox.Location = new System.Drawing.Point(293, 35);
            this.employeesBox.Name = "employeesBox";
            this.employeesBox.Size = new System.Drawing.Size(125, 121);
            this.employeesBox.TabIndex = 21;
            this.employeesBox.SelectedIndexChanged += new System.EventHandler(this.employeesBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Phone #";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Name";
            // 
            // phoneBox
            // 
            this.phoneBox.Location = new System.Drawing.Point(70, 45);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(100, 20);
            this.phoneBox.TabIndex = 18;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(70, 13);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 17;
            // 
            // employeeGroup
            // 
            this.employeeGroup.Controls.Add(this.label1);
            this.employeeGroup.Controls.Add(this.nameBox);
            this.employeeGroup.Controls.Add(this.phoneBox);
            this.employeeGroup.Controls.Add(this.label2);
            this.employeeGroup.Controls.Add(this.label4);
            this.employeeGroup.Controls.Add(this.rateBox);
            this.employeeGroup.Location = new System.Drawing.Point(51, 35);
            this.employeeGroup.Name = "employeeGroup";
            this.employeeGroup.Size = new System.Drawing.Size(200, 121);
            this.employeeGroup.TabIndex = 31;
            this.employeeGroup.TabStop = false;
            this.employeeGroup.Text = "Employee";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelHours);
            this.groupBox1.Controls.Add(this.hoursBox);
            this.groupBox1.Controls.Add(this.labelPay);
            this.groupBox1.Controls.Add(this.payBox);
            this.groupBox1.Location = new System.Drawing.Point(463, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 121);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pay";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(290, 19);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(58, 13);
            this.label.TabIndex = 33;
            this.label.Text = "Employees";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.employeeGroup);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.employeesBox);
            this.Name = "Form1";
            this.Text = "Unit 11.2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.employeeGroup.ResumeLayout(false);
            this.employeeGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPay;
        private System.Windows.Forms.TextBox payBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox rateBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox hoursBox;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListBox employeesBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.GroupBox employeeGroup;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label;
    }
}

