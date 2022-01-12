
namespace Склад
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Task1_btm = new System.Windows.Forms.Button();
            this.Task2_Btm = new System.Windows.Forms.Button();
            this.Task3_Btm = new System.Windows.Forms.Button();
            this.Task4_Btm = new System.Windows.Forms.Button();
            this.Task5 = new System.Windows.Forms.Button();
            this.Task6_Btm = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.typeText = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuppliertextBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Task1_btm
            // 
            this.Task1_btm.FlatAppearance.BorderSize = 4;
            this.Task1_btm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Task1_btm.Location = new System.Drawing.Point(567, 700);
            this.Task1_btm.Name = "Task1_btm";
            this.Task1_btm.Size = new System.Drawing.Size(284, 93);
            this.Task1_btm.TabIndex = 0;
            this.Task1_btm.Text = "Display all information about the product";
            this.Task1_btm.UseVisualStyleBackColor = true;
            this.Task1_btm.Click += new System.EventHandler(this.Task1_btm_Click);
            // 
            // Task2_Btm
            // 
            this.Task2_Btm.FlatAppearance.BorderSize = 4;
            this.Task2_Btm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Task2_Btm.Location = new System.Drawing.Point(12, 53);
            this.Task2_Btm.Name = "Task2_Btm";
            this.Task2_Btm.Size = new System.Drawing.Size(284, 93);
            this.Task2_Btm.TabIndex = 1;
            this.Task2_Btm.Text = "Display of all types of products";
            this.Task2_Btm.UseVisualStyleBackColor = true;
            this.Task2_Btm.Click += new System.EventHandler(this.Task2_Btm_Click);
            // 
            // Task3_Btm
            // 
            this.Task3_Btm.FlatAppearance.BorderSize = 4;
            this.Task3_Btm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Task3_Btm.Location = new System.Drawing.Point(12, 159);
            this.Task3_Btm.Name = "Task3_Btm";
            this.Task3_Btm.Size = new System.Drawing.Size(284, 93);
            this.Task3_Btm.TabIndex = 2;
            this.Task3_Btm.Text = "Display all provider";
            this.Task3_Btm.UseVisualStyleBackColor = true;
            this.Task3_Btm.Click += new System.EventHandler(this.Task3_Btm_Click);
            // 
            // Task4_Btm
            // 
            this.Task4_Btm.FlatAppearance.BorderSize = 4;
            this.Task4_Btm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Task4_Btm.Location = new System.Drawing.Point(12, 288);
            this.Task4_Btm.Name = "Task4_Btm";
            this.Task4_Btm.Size = new System.Drawing.Size(284, 93);
            this.Task4_Btm.TabIndex = 3;
            this.Task4_Btm.Text = "Show product with maximum quantity";
            this.Task4_Btm.UseVisualStyleBackColor = true;
            this.Task4_Btm.Click += new System.EventHandler(this.Task4_Btm_Click);
            // 
            // Task5
            // 
            this.Task5.FlatAppearance.BorderSize = 4;
            this.Task5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Task5.Location = new System.Drawing.Point(1134, 53);
            this.Task5.Name = "Task5";
            this.Task5.Size = new System.Drawing.Size(284, 93);
            this.Task5.TabIndex = 4;
            this.Task5.Text = "Show product with minimum quantity";
            this.Task5.UseVisualStyleBackColor = true;
            this.Task5.Click += new System.EventHandler(this.Task5_Click);
            // 
            // Task6_Btm
            // 
            this.Task6_Btm.FlatAppearance.BorderSize = 4;
            this.Task6_Btm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Task6_Btm.Location = new System.Drawing.Point(1134, 170);
            this.Task6_Btm.Name = "Task6_Btm";
            this.Task6_Btm.Size = new System.Drawing.Size(284, 93);
            this.Task6_Btm.TabIndex = 5;
            this.Task6_Btm.Text = "Show product with minimum cost";
            this.Task6_Btm.UseVisualStyleBackColor = true;
            this.Task6_Btm.Click += new System.EventHandler(this.Task6_Btm_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 4;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1134, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(284, 93);
            this.button1.TabIndex = 6;
            this.button1.Text = "Show product with maximum cost";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(339, 53);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(750, 480);
            this.textBox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 561);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 45);
            this.label1.TabIndex = 8;
            this.label1.Text = "Enter Type staff: ";
            // 
            // typeText
            // 
            this.typeText.Location = new System.Drawing.Point(295, 567);
            this.typeText.Name = "typeText";
            this.typeText.Size = new System.Drawing.Size(305, 39);
            this.typeText.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(625, 567);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 46);
            this.button2.TabIndex = 10;
            this.button2.Text = "search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(625, 615);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 46);
            this.button3.TabIndex = 13;
            this.button3.Text = "search";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // SuppliertextBox2
            // 
            this.SuppliertextBox2.Location = new System.Drawing.Point(295, 615);
            this.SuppliertextBox2.Name = "SuppliertextBox2";
            this.SuppliertextBox2.Size = new System.Drawing.Size(305, 39);
            this.SuppliertextBox2.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 609);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 45);
            this.label2.TabIndex = 11;
            this.label2.Text = "Enter Supplier : ";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(988, 561);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(402, 91);
            this.button4.TabIndex = 14;
            this.button4.Text = "Show the oldest product in stock";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(988, 677);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(402, 91);
            this.button5.TabIndex = 15;
            this.button5.Text = "Show the average number of products for each";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1430, 805);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.SuppliertextBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.typeText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Task6_Btm);
            this.Controls.Add(this.Task5);
            this.Controls.Add(this.Task4_Btm);
            this.Controls.Add(this.Task3_Btm);
            this.Controls.Add(this.Task2_Btm);
            this.Controls.Add(this.Task1_btm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Task1_btm;
        private System.Windows.Forms.Button Task2_Btm;
        private System.Windows.Forms.Button Task3_Btm;
        private System.Windows.Forms.Button Task4_Btm;
        private System.Windows.Forms.Button Task5;
        private System.Windows.Forms.Button Task6_Btm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox typeText;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox SuppliertextBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

