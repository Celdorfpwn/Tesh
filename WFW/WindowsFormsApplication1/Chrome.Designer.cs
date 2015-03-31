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
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Shop Monday 1");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Monday", new System.Windows.Forms.TreeNode[] {
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Shop Tuesday 1");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Shop Tuesday 2");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Shop Tuesday 3");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Tuesday", new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode18,
            treeNode19});
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Shop Wednesday 2");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Wednesday", new System.Windows.Forms.TreeNode[] {
            treeNode21});
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Node13");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Thursday", new System.Windows.Forms.TreeNode[] {
            treeNode23});
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Node14");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Friday", new System.Windows.Forms.TreeNode[] {
            treeNode25});
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Saturday");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Sunday");
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PartNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ListPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LineType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerialNo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaxExempt = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Reorder = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
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
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(0, 88);
            this.treeView1.Name = "treeView1";
            treeNode15.Name = "Node7";
            treeNode15.Text = "Shop Monday 1";
            treeNode16.Name = "Monday";
            treeNode16.Text = "Monday";
            treeNode17.Name = "Node9";
            treeNode17.Text = "Shop Tuesday 1";
            treeNode18.Name = "Node10";
            treeNode18.Text = "Shop Tuesday 2";
            treeNode19.Name = "Node11";
            treeNode19.Text = "Shop Tuesday 3";
            treeNode20.Name = "Node1";
            treeNode20.Text = "Tuesday";
            treeNode21.Name = "Node12";
            treeNode21.Text = "Shop Wednesday 2";
            treeNode22.Name = "Node2";
            treeNode22.Text = "Wednesday";
            treeNode23.Name = "Node13";
            treeNode23.Text = "Node13";
            treeNode24.Name = "Node3";
            treeNode24.Text = "Thursday";
            treeNode25.Name = "Node14";
            treeNode25.Text = "Node14";
            treeNode26.Name = "Node4";
            treeNode26.Text = "Friday";
            treeNode27.Name = "Node5";
            treeNode27.Text = "Saturday";
            treeNode28.Name = "Node6";
            treeNode28.Text = "Sunday";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode20,
            treeNode22,
            treeNode24,
            treeNode26,
            treeNode27,
            treeNode28});
            this.treeView1.Size = new System.Drawing.Size(205, 488);
            this.treeView1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1154, 82);
            this.tableLayoutPanel1.TabIndex = 0;
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
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox4, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox5, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox6, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox7, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox8, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox9, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox10, 4, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1148, 76);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(223, 29);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "This is algerian bold";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox2.Location = new System.Drawing.Point(232, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(223, 26);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Consolas Bold Italic";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(461, 3);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(223, 28);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "Sanp-ITC italic";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(690, 3);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(223, 19);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "Modern No. 20 regular";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox5.Location = new System.Drawing.Point(919, 3);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(226, 29);
            this.textBox5.TabIndex = 4;
            this.textBox5.Text = "Monotype Corsiva";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox6.Location = new System.Drawing.Point(3, 41);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(223, 27);
            this.textBox6.TabIndex = 5;
            this.textBox6.Text = "Mistral";
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(232, 41);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(223, 21);
            this.textBox7.TabIndex = 6;
            this.textBox7.Text = "Gill Sans Ultra Bold";
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(461, 41);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(223, 33);
            this.textBox8.TabIndex = 7;
            this.textBox8.Text = "Papyrus";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(690, 41);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(223, 20);
            this.textBox9.TabIndex = 8;
            this.textBox9.Text = "Microsoft Sans Serif";
            // 
            // textBox10
            // 
            this.textBox10.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.Location = new System.Drawing.Point(919, 41);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(225, 20);
            this.textBox10.TabIndex = 9;
            this.textBox10.Text = "RockWell";
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
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
    }
}