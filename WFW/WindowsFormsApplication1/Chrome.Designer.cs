namespace WindowsFormsApplication1
{
    partial class Chrome
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
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Shop Monday 1");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Monday", new System.Windows.Forms.TreeNode[] {
            treeNode29});
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Shop Tuesday 1");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Shop Tuesday 2");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Shop Tuesday 3");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Tuesday", new System.Windows.Forms.TreeNode[] {
            treeNode31,
            treeNode32,
            treeNode33});
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Shop Wednesday 2");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("Wednesday", new System.Windows.Forms.TreeNode[] {
            treeNode35});
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("Node13");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("Thursday", new System.Windows.Forms.TreeNode[] {
            treeNode37});
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("Node14");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("Friday", new System.Windows.Forms.TreeNode[] {
            treeNode39});
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("Saturday");
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("Sunday");
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PartNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ListPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LineType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerialNo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaxExempt = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Reorder = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-2, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1162, 602);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabControl2);
            this.tabPage1.Controls.Add(this.treeView1);
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1154, 576);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Point of sale";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1154, 576);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Business Management";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1154, 82);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(0, 88);
            this.treeView1.Name = "treeView1";
            treeNode29.Name = "Node7";
            treeNode29.Text = "Shop Monday 1";
            treeNode30.Name = "Monday";
            treeNode30.Text = "Monday";
            treeNode31.Name = "Node9";
            treeNode31.Text = "Shop Tuesday 1";
            treeNode32.Name = "Node10";
            treeNode32.Text = "Shop Tuesday 2";
            treeNode33.Name = "Node11";
            treeNode33.Text = "Shop Tuesday 3";
            treeNode34.Name = "Node1";
            treeNode34.Text = "Tuesday";
            treeNode35.Name = "Node12";
            treeNode35.Text = "Shop Wednesday 2";
            treeNode36.Name = "Node2";
            treeNode36.Text = "Wednesday";
            treeNode37.Name = "Node13";
            treeNode37.Text = "Node13";
            treeNode38.Name = "Node3";
            treeNode38.Text = "Thursday";
            treeNode39.Name = "Node14";
            treeNode39.Text = "Node14";
            treeNode40.Name = "Node4";
            treeNode40.Text = "Friday";
            treeNode41.Name = "Node5";
            treeNode41.Text = "Saturday";
            treeNode42.Name = "Node6";
            treeNode42.Text = "Sunday";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode30,
            treeNode34,
            treeNode36,
            treeNode38,
            treeNode40,
            treeNode41,
            treeNode42});
            this.treeView1.Size = new System.Drawing.Size(205, 488);
            this.treeView1.TabIndex = 1;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Location = new System.Drawing.Point(212, 88);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(939, 488);
            this.tabControl2.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(931, 462);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Summary";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(931, 462);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Transaction History";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataGridView1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(931, 462);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Order #23432233432";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(931, 462);
            this.tabPage6.TabIndex = 3;
            this.tabPage6.Text = "Order #223333445667";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartNumber,
            this.ListPrice,
            this.LineType,
            this.SerialNo,
            this.Discount,
            this.TaxExempt,
            this.Reorder,
            this.Notes});
            this.dataGridView1.Location = new System.Drawing.Point(7, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(921, 179);
            this.dataGridView1.TabIndex = 0;
            // 
            // PartNumber
            // 
            this.PartNumber.HeaderText = "Part #";
            this.PartNumber.Name = "PartNumber";
            this.PartNumber.Width = 125;
            // 
            // ListPrice
            // 
            this.ListPrice.HeaderText = "ListPrice";
            this.ListPrice.Name = "ListPrice";
            // 
            // LineType
            // 
            this.LineType.HeaderText = "LineType";
            this.LineType.Name = "LineType";
            // 
            // SerialNo
            // 
            this.SerialNo.HeaderText = "SerialNo";
            this.SerialNo.Name = "SerialNo";
            // 
            // Discount
            // 
            this.Discount.HeaderText = "Discount";
            this.Discount.Name = "Discount";
            // 
            // TaxExempt
            // 
            this.TaxExempt.HeaderText = "TaxExempt";
            this.TaxExempt.Name = "TaxExempt";
            // 
            // Reorder
            // 
            this.Reorder.HeaderText = "Reorder";
            this.Reorder.Name = "Reorder";
            // 
            // Notes
            // 
            this.Notes.HeaderText = "Notes";
            this.Notes.Name = "Notes";
            this.Notes.Width = 150;
            // 
            // Chrome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 603);
            this.Controls.Add(this.tabControl1);
            this.Name = "Chrome";
            this.Text = "Chrome";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ListPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn LineType;
        private System.Windows.Forms.DataGridViewButtonColumn SerialNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TaxExempt;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Reorder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
    }
}