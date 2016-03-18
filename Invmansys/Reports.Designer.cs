namespace Invmansys
{
    partial class Reports
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Supplier_Reports = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Product_Reports = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.Supplier_Reports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Product_Reports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Supplier_Reports);
            this.tabControl1.Controls.Add(this.Product_Reports);
            this.tabControl1.Location = new System.Drawing.Point(13, 64);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(624, 410);
            this.tabControl1.TabIndex = 0;
            // 
            // Supplier_Reports
            // 
            this.Supplier_Reports.Controls.Add(this.button1);
            this.Supplier_Reports.Controls.Add(this.label1);
            this.Supplier_Reports.Controls.Add(this.textBox1);
            this.Supplier_Reports.Controls.Add(this.dataGridView1);
            this.Supplier_Reports.Location = new System.Drawing.Point(4, 22);
            this.Supplier_Reports.Name = "Supplier_Reports";
            this.Supplier_Reports.Padding = new System.Windows.Forms.Padding(3);
            this.Supplier_Reports.Size = new System.Drawing.Size(616, 384);
            this.Supplier_Reports.TabIndex = 0;
            this.Supplier_Reports.Text = "Supplier Reports";
            this.Supplier_Reports.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(455, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 20);
            this.button1.TabIndex = 3;
            this.button1.Text = "Print Report";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search Report :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 358);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(355, 20);
            this.textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(604, 346);
            this.dataGridView1.TabIndex = 0;
            // 
            // Product_Reports
            // 
            this.Product_Reports.Controls.Add(this.button2);
            this.Product_Reports.Controls.Add(this.label2);
            this.Product_Reports.Controls.Add(this.textBox2);
            this.Product_Reports.Controls.Add(this.dataGridView2);
            this.Product_Reports.Location = new System.Drawing.Point(4, 22);
            this.Product_Reports.Name = "Product_Reports";
            this.Product_Reports.Padding = new System.Windows.Forms.Padding(3);
            this.Product_Reports.Size = new System.Drawing.Size(616, 384);
            this.Product_Reports.TabIndex = 1;
            this.Product_Reports.Text = "Product Reports";
            this.Product_Reports.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(455, 358);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 20);
            this.button2.TabIndex = 7;
            this.button2.Text = "Print Report";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Search Report :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(94, 358);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(355, 20);
            this.textBox2.TabIndex = 5;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(604, 346);
            this.dataGridView2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Invmansys.Properties.Resources.Banner;
            this.pictureBox1.Location = new System.Drawing.Point(185, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 483);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Reports";
            this.Text = "Reports";
            this.tabControl1.ResumeLayout(false);
            this.Supplier_Reports.ResumeLayout(false);
            this.Supplier_Reports.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Product_Reports.ResumeLayout(false);
            this.Product_Reports.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Supplier_Reports;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage Product_Reports;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}