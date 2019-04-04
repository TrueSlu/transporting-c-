namespace _1050838_Lu_Pet_12._11
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
            this.petsBox = new System.Windows.Forms.ListBox();
            this.colorBoxSum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.breedBoxSum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.typeBoxSum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameBoxSum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonDone
            // 
            this.buttonDone.Location = new System.Drawing.Point(316, 319);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(172, 60);
            this.buttonDone.TabIndex = 27;
            this.buttonDone.Text = "Done";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // petsBox
            // 
            this.petsBox.FormattingEnabled = true;
            this.petsBox.Location = new System.Drawing.Point(316, 108);
            this.petsBox.Name = "petsBox";
            this.petsBox.Size = new System.Drawing.Size(172, 95);
            this.petsBox.TabIndex = 26;
            this.petsBox.SelectedIndexChanged += new System.EventHandler(this.petsBox_SelectedIndexChanged_1);
            // 
            // colorBoxSum
            // 
            this.colorBoxSum.Location = new System.Drawing.Point(388, 293);
            this.colorBoxSum.Name = "colorBoxSum";
            this.colorBoxSum.Size = new System.Drawing.Size(100, 20);
            this.colorBoxSum.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Animal Color";
            // 
            // breedBoxSum
            // 
            this.breedBoxSum.Location = new System.Drawing.Point(388, 267);
            this.breedBoxSum.Name = "breedBoxSum";
            this.breedBoxSum.Size = new System.Drawing.Size(100, 20);
            this.breedBoxSum.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Animal Breed";
            // 
            // typeBoxSum
            // 
            this.typeBoxSum.Location = new System.Drawing.Point(388, 241);
            this.typeBoxSum.Name = "typeBoxSum";
            this.typeBoxSum.Size = new System.Drawing.Size(100, 20);
            this.typeBoxSum.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Animal Type";
            // 
            // nameBoxSum
            // 
            this.nameBoxSum.Location = new System.Drawing.Point(388, 215);
            this.nameBoxSum.Name = "nameBoxSum";
            this.nameBoxSum.Size = new System.Drawing.Size(100, 20);
            this.nameBoxSum.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Animal Name";
            // 
            // SummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.petsBox);
            this.Controls.Add(this.colorBoxSum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.breedBoxSum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.typeBoxSum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameBoxSum);
            this.Controls.Add(this.label1);
            this.Name = "SummaryForm";
            this.Text = "SummaryForm";
            this.Load += new System.EventHandler(this.SummaryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.ListBox petsBox;
        private System.Windows.Forms.TextBox colorBoxSum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox breedBoxSum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox typeBoxSum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameBoxSum;
        private System.Windows.Forms.Label label1;
    }
}