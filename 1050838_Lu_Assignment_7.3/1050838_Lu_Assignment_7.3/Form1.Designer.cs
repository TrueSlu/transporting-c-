namespace _1050838_Lu_Assignment_7._3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richBox = new System.Windows.Forms.RichTextBox();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.size = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.type = new System.Windows.Forms.ComboBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hoursBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printYachtTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addYachtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeYachtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayNumberOfTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewDialogSum = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocumentYacht = new System.Drawing.Printing.PrintDocument();
            this.printDocumentSum = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialogYacht = new System.Windows.Forms.PrintPreviewDialog();
            this.groupBoxInput.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richBox
            // 
            this.richBox.Location = new System.Drawing.Point(14, 160);
            this.richBox.Name = "richBox";
            this.richBox.Size = new System.Drawing.Size(189, 45);
            this.richBox.TabIndex = 4;
            this.richBox.Text = "";
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.clearButton);
            this.groupBoxInput.Controls.Add(this.okButton);
            this.groupBoxInput.Controls.Add(this.label3);
            this.groupBoxInput.Controls.Add(this.priceBox);
            this.groupBoxInput.Controls.Add(this.richBox);
            this.groupBoxInput.Controls.Add(this.size);
            this.groupBoxInput.Controls.Add(this.label5);
            this.groupBoxInput.Controls.Add(this.label4);
            this.groupBoxInput.Controls.Add(this.type);
            this.groupBoxInput.Controls.Add(this.nameBox);
            this.groupBoxInput.Controls.Add(this.label1);
            this.groupBoxInput.Controls.Add(this.hoursBox);
            this.groupBoxInput.Controls.Add(this.label2);
            this.groupBoxInput.Location = new System.Drawing.Point(201, 94);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(386, 228);
            this.groupBoxInput.TabIndex = 3;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Input your Info";
            // 
            // clearButton
            // 
            this.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clearButton.Location = new System.Drawing.Point(215, 160);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(165, 29);
            this.clearButton.TabIndex = 15;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(14, 125);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(366, 29);
            this.okButton.TabIndex = 5;
            this.okButton.Text = "Confirm";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // size
            // 
            this.size.FormattingEnabled = true;
            this.size.Items.AddRange(new object[] {
            "22",
            "24",
            "30",
            "32",
            "36",
            "38",
            "45"});
            this.size.Location = new System.Drawing.Point(118, 98);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(196, 21);
            this.size.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Charter Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Type";
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(286, 202);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(94, 20);
            this.priceBox.TabIndex = 6;
            // 
            // type
            // 
            this.type.FormattingEnabled = true;
            this.type.Items.AddRange(new object[] {
            "Ranger",
            "Wave-length",
            "Catalina",
            "Coronada",
            "Hobie",
            "C & C",
            "Hans Christian",
            "Excalibur"});
            this.type.Location = new System.Drawing.Point(118, 71);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(196, 21);
            this.type.TabIndex = 3;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(118, 15);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(196, 20);
            this.nameBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // hoursBox
            // 
            this.hoursBox.Location = new System.Drawing.Point(118, 45);
            this.hoursBox.Name = "hoursBox";
            this.hoursBox.Size = new System.Drawing.Size(196, 20);
            this.hoursBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Hours";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printSummaryToolStripMenuItem,
            this.printYachtTypesToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // printSummaryToolStripMenuItem
            // 
            this.printSummaryToolStripMenuItem.Name = "printSummaryToolStripMenuItem";
            this.printSummaryToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.printSummaryToolStripMenuItem.Text = "Print Summary";
            this.printSummaryToolStripMenuItem.Click += new System.EventHandler(this.printSummaryToolStripMenuItem_Click);
            // 
            // printYachtTypesToolStripMenuItem
            // 
            this.printYachtTypesToolStripMenuItem.Name = "printYachtTypesToolStripMenuItem";
            this.printYachtTypesToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.printYachtTypesToolStripMenuItem.Text = "Print Yacht Types";
            this.printYachtTypesToolStripMenuItem.Click += new System.EventHandler(this.printYachtTypesToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.toolStripSeparator1,
            this.addYachtToolStripMenuItem,
            this.removeYachtToolStripMenuItem,
            this.displayNumberOfTypesToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(203, 6);
            // 
            // addYachtToolStripMenuItem
            // 
            this.addYachtToolStripMenuItem.Name = "addYachtToolStripMenuItem";
            this.addYachtToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.addYachtToolStripMenuItem.Text = "Add Yacht";
            this.addYachtToolStripMenuItem.Click += new System.EventHandler(this.addYachtToolStripMenuItem_Click);
            // 
            // removeYachtToolStripMenuItem
            // 
            this.removeYachtToolStripMenuItem.Name = "removeYachtToolStripMenuItem";
            this.removeYachtToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.removeYachtToolStripMenuItem.Text = "Remove Yacht";
            this.removeYachtToolStripMenuItem.Click += new System.EventHandler(this.removeYachtToolStripMenuItem_Click);
            // 
            // displayNumberOfTypesToolStripMenuItem
            // 
            this.displayNumberOfTypesToolStripMenuItem.Name = "displayNumberOfTypesToolStripMenuItem";
            this.displayNumberOfTypesToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.displayNumberOfTypesToolStripMenuItem.Text = "Display Number of Types";
            this.displayNumberOfTypesToolStripMenuItem.Click += new System.EventHandler(this.displayNumberOfTypesToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // printPreviewDialogSum
            // 
            this.printPreviewDialogSum.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogSum.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogSum.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogSum.Enabled = true;
            this.printPreviewDialogSum.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogSum.Icon")));
            this.printPreviewDialogSum.Name = "printPreviewDialogSum";
            this.printPreviewDialogSum.Visible = false;
            this.printPreviewDialogSum.Load += new System.EventHandler(this.printPreviewDialogSum_Load);
            // 
            // printDocumentYacht
            // 
            this.printDocumentYacht.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentYacht_PrintPage);
            // 
            // printDocumentSum
            // 
            this.printDocumentSum.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentSum_PrintPage);
            // 
            // printPreviewDialogYacht
            // 
            this.printPreviewDialogYacht.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogYacht.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogYacht.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogYacht.Enabled = true;
            this.printPreviewDialogYacht.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogYacht.Icon")));
            this.printPreviewDialogYacht.Name = "printPreviewDialogYacht";
            this.printPreviewDialogYacht.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxInput);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Assignment 7.3";
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richBox;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.ComboBox size;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox hoursBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printSummaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printYachtTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem addYachtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeYachtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayNumberOfTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogSum;
        private System.Drawing.Printing.PrintDocument printDocumentYacht;
        private System.Drawing.Printing.PrintDocument printDocumentSum;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogYacht;
    }
}

