namespace _1050838_Lu_Unit_7_Mail
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
            this.countBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearForNextCarterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.addBagelTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeBagelTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayCountOfBagelTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewDialogCatalog = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialogCatalog = new System.Windows.Forms.PrintDialog();
            this.docCata = new System.Drawing.Printing.PrintDocument();
            this.groupBoxInput.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // countBox
            // 
            this.countBox.Location = new System.Drawing.Point(385, 241);
            this.countBox.Name = "countBox";
            this.countBox.Size = new System.Drawing.Size(88, 20);
            this.countBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Catalog Count";
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.label4);
            this.groupBoxInput.Controls.Add(this.typeBox);
            this.groupBoxInput.Location = new System.Drawing.Point(299, 150);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(188, 68);
            this.groupBoxInput.TabIndex = 12;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Unit 7 Mail Order";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Type";
            // 
            // typeBox
            // 
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Items.AddRange(new object[] {
            "Odds and Ends",
            "Solutions",
            "Camping Needs",
            "ToolTime",
            "Spiegel",
            "The Outlet",
            "The Large Size"});
            this.typeBox.Location = new System.Drawing.Point(87, 13);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(87, 21);
            this.typeBox.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printSummaryToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // printSummaryToolStripMenuItem
            // 
            this.printSummaryToolStripMenuItem.Name = "printSummaryToolStripMenuItem";
            this.printSummaryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.printSummaryToolStripMenuItem.Text = "Print Catalog";
            this.printSummaryToolStripMenuItem.Click += new System.EventHandler(this.printSummaryToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearForNextCarterToolStripMenuItem,
            this.toolStripMenuItem2,
            this.addBagelTypeToolStripMenuItem,
            this.removeBagelTypeToolStripMenuItem,
            this.displayCountOfBagelTypesToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // clearForNextCarterToolStripMenuItem
            // 
            this.clearForNextCarterToolStripMenuItem.Name = "clearForNextCarterToolStripMenuItem";
            this.clearForNextCarterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clearForNextCarterToolStripMenuItem.Text = "Clear";
            this.clearForNextCarterToolStripMenuItem.Click += new System.EventHandler(this.clearForNextCarterToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // addBagelTypeToolStripMenuItem
            // 
            this.addBagelTypeToolStripMenuItem.Name = "addBagelTypeToolStripMenuItem";
            this.addBagelTypeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addBagelTypeToolStripMenuItem.Text = "Add Type";
            this.addBagelTypeToolStripMenuItem.Click += new System.EventHandler(this.addBagelTypeToolStripMenuItem_Click);
            // 
            // removeBagelTypeToolStripMenuItem
            // 
            this.removeBagelTypeToolStripMenuItem.Name = "removeBagelTypeToolStripMenuItem";
            this.removeBagelTypeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeBagelTypeToolStripMenuItem.Text = "Remove Type";
            this.removeBagelTypeToolStripMenuItem.Click += new System.EventHandler(this.removeBagelTypeToolStripMenuItem_Click);
            // 
            // displayCountOfBagelTypesToolStripMenuItem
            // 
            this.displayCountOfBagelTypesToolStripMenuItem.Name = "displayCountOfBagelTypesToolStripMenuItem";
            this.displayCountOfBagelTypesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.displayCountOfBagelTypesToolStripMenuItem.Text = "Number of Types";
            this.displayCountOfBagelTypesToolStripMenuItem.Click += new System.EventHandler(this.displayCountOfBagelTypesToolStripMenuItem_Click);
            // 
            // printPreviewDialogCatalog
            // 
            this.printPreviewDialogCatalog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogCatalog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogCatalog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogCatalog.Enabled = true;
            this.printPreviewDialogCatalog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogCatalog.Icon")));
            this.printPreviewDialogCatalog.Name = "printPreviewDialogBagel";
            this.printPreviewDialogCatalog.Visible = false;
            // 
            // printDialogCatalog
            // 
            this.printDialogCatalog.UseEXDialog = true;
            // 
            // docCata
            // 
            this.docCata.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentCatalog_PrintPage);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.countBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxInput);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Unit 7 Mail Order";
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox countBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox typeBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printSummaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearForNextCarterToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem addBagelTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeBagelTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayCountOfBagelTypesToolStripMenuItem;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogCatalog;
        private System.Windows.Forms.PrintDialog printDialogCatalog;
        private System.Drawing.Printing.PrintDocument docCata;
    }
}

