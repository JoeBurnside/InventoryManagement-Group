﻿namespace Invmansys
{
    partial class Create_Product
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
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.RichTextBox();
            this.Cost_Price = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.Weight = new System.Windows.Forms.TextBox();
            this.Sale_Price = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Colour = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Nametxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(259, 26);
            this.button1.TabIndex = 34;
            this.button1.Text = "Add Product";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Invmansys.Properties.Resources.Banner;
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(96, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 54;
            this.label7.Text = "Description";
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(10, 277);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(259, 83);
            this.Description.TabIndex = 53;
            this.Description.Text = "";
            // 
            // Cost_Price
            // 
            this.Cost_Price.Location = new System.Drawing.Point(124, 134);
            this.Cost_Price.Name = "Cost_Price";
            this.Cost_Price.Size = new System.Drawing.Size(149, 20);
            this.Cost_Price.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Cost Price:";
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(124, 186);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(149, 20);
            this.Quantity.TabIndex = 50;
            // 
            // Weight
            // 
            this.Weight.Location = new System.Drawing.Point(124, 212);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(149, 20);
            this.Weight.TabIndex = 49;
            // 
            // Sale_Price
            // 
            this.Sale_Price.Location = new System.Drawing.Point(124, 108);
            this.Sale_Price.Name = "Sale_Price";
            this.Sale_Price.Size = new System.Drawing.Size(149, 20);
            this.Sale_Price.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Product Weight:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Product Quantity:";
            // 
            // Colour
            // 
            this.Colour.Location = new System.Drawing.Point(124, 160);
            this.Colour.Name = "Colour";
            this.Colour.Size = new System.Drawing.Size(149, 20);
            this.Colour.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Product Colour:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Sales Price:";
            // 
            // Nametxt
            // 
            this.Nametxt.Location = new System.Drawing.Point(124, 82);
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(149, 20);
            this.Nametxt.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = " Product Name:";
            // 
            // Create_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 402);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Cost_Price);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.Weight);
            this.Controls.Add(this.Sale_Price);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Colour);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nametxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Create_Product";
            this.Text = "Create_Product";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox Description;
        private System.Windows.Forms.TextBox Cost_Price;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.TextBox Weight;
        private System.Windows.Forms.TextBox Sale_Price;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Colour;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nametxt;
        private System.Windows.Forms.Label label2;
    }
}