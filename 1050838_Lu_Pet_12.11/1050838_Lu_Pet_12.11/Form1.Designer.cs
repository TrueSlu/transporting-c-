namespace _1050838_Lu_Pet_12._11
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
            this.buttonViewSummary = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.typeBox = new System.Windows.Forms.TextBox();
            this.breedBox = new System.Windows.Forms.TextBox();
            this.colorBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonViewSummary
            // 
            this.buttonViewSummary.Location = new System.Drawing.Point(386, 263);
            this.buttonViewSummary.Name = "buttonViewSummary";
            this.buttonViewSummary.Size = new System.Drawing.Size(114, 43);
            this.buttonViewSummary.TabIndex = 5;
            this.buttonViewSummary.Text = "View Summary";
            this.buttonViewSummary.UseVisualStyleBackColor = true;
            this.buttonViewSummary.Click += new System.EventHandler(this.buttonViewSummary_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(300, 263);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(80, 43);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.colorBox);
            this.groupBox1.Controls.Add(this.breedBox);
            this.groupBox1.Controls.Add(this.typeBox);
            this.groupBox1.Controls.Add(this.nameBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(300, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 175);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Make a Pet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Breed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(68, 40);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 7;
            // 
            // typeBox
            // 
            this.typeBox.Location = new System.Drawing.Point(68, 66);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(100, 20);
            this.typeBox.TabIndex = 8;
            // 
            // breedBox
            // 
            this.breedBox.Location = new System.Drawing.Point(68, 95);
            this.breedBox.Name = "breedBox";
            this.breedBox.Size = new System.Drawing.Size(100, 20);
            this.breedBox.TabIndex = 9;
            // 
            // colorBox
            // 
            this.colorBox.Location = new System.Drawing.Point(68, 121);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(100, 20);
            this.colorBox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonViewSummary);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Assignment 12.11";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonViewSummary;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox colorBox;
        private System.Windows.Forms.TextBox breedBox;
        private System.Windows.Forms.TextBox typeBox;
        private System.Windows.Forms.TextBox nameBox;
    }
}

