namespace LunchbillCalculatorApp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.riceTextBox = new System.Windows.Forms.TextBox();
            this.fishTextBox = new System.Windows.Forms.TextBox();
            this.meatTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.showTotalButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.totalGrossTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.discountTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.showNetButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.showNetButton);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.discountTextBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.totalGrossTextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.showTotalButton);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.meatTextBox);
            this.groupBox1.Controls.Add(this.fishTextBox);
            this.groupBox1.Controls.Add(this.riceTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 400);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bill For Lunch";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rice(Unit price:20tk)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fish(Unit price:80tk)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Meat(Unit price:100tk)";
            // 
            // riceTextBox
            // 
            this.riceTextBox.Location = new System.Drawing.Point(177, 57);
            this.riceTextBox.Name = "riceTextBox";
            this.riceTextBox.Size = new System.Drawing.Size(100, 20);
            this.riceTextBox.TabIndex = 3;
            // 
            // fishTextBox
            // 
            this.fishTextBox.Location = new System.Drawing.Point(177, 97);
            this.fishTextBox.Name = "fishTextBox";
            this.fishTextBox.Size = new System.Drawing.Size(100, 20);
            this.fishTextBox.TabIndex = 4;
            // 
            // meatTextBox
            // 
            this.meatTextBox.Location = new System.Drawing.Point(177, 137);
            this.meatTextBox.Name = "meatTextBox";
            this.meatTextBox.Size = new System.Drawing.Size(100, 20);
            this.meatTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Unit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(307, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Unit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(307, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Unit";
            // 
            // showTotalButton
            // 
            this.showTotalButton.Location = new System.Drawing.Point(23, 189);
            this.showTotalButton.Name = "showTotalButton";
            this.showTotalButton.Size = new System.Drawing.Size(75, 23);
            this.showTotalButton.TabIndex = 9;
            this.showTotalButton.Text = "Show Total";
            this.showTotalButton.UseVisualStyleBackColor = true;
            this.showTotalButton.Click += new System.EventHandler(this.showTotalButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(142, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Total Gross";
            // 
            // totalGrossTextBox
            // 
            this.totalGrossTextBox.Location = new System.Drawing.Point(220, 189);
            this.totalGrossTextBox.Name = "totalGrossTextBox";
            this.totalGrossTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalGrossTextBox.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(331, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "tk";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(142, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Discount";
            // 
            // discountTextBox
            // 
            this.discountTextBox.Location = new System.Drawing.Point(220, 215);
            this.discountTextBox.Name = "discountTextBox";
            this.discountTextBox.Size = new System.Drawing.Size(100, 20);
            this.discountTextBox.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(331, 222);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "%";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(236, 272);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Vat(5%)";
            // 
            // showNetButton
            // 
            this.showNetButton.Location = new System.Drawing.Point(220, 317);
            this.showNetButton.Name = "showNetButton";
            this.showNetButton.Size = new System.Drawing.Size(75, 23);
            this.showNetButton.TabIndex = 17;
            this.showNetButton.Text = "Show Net Bill";
            this.showNetButton.UseVisualStyleBackColor = true;
            this.showNetButton.Click += new System.EventHandler(this.showNetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 402);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Lunch Bill Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button showNetButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox discountTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox totalGrossTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button showTotalButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox meatTextBox;
        private System.Windows.Forms.TextBox fishTextBox;
        private System.Windows.Forms.TextBox riceTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

