namespace Lab1.AllForms
{
    partial class ComplexDishesForm
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
            this.Name = new System.Windows.Forms.TextBox();
            this.Count = new System.Windows.Forms.TextBox();
            this.Calories = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbSoup = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbMeat = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbServingSize = new System.Windows.Forms.ComboBox();
            this.txtServingSize = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(40, 62);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(150, 38);
            this.Name.TabIndex = 0;
            // 
            // Count
            // 
            this.Count.Location = new System.Drawing.Point(40, 157);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(150, 38);
            this.Count.TabIndex = 1;
            // 
            // Calories
            // 
            this.Calories.Location = new System.Drawing.Point(40, 259);
            this.Calories.Name = "Calories";
            this.Calories.Size = new System.Drawing.Size(150, 38);
            this.Calories.TabIndex = 2;
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(40, 357);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(150, 38);
            this.Price.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Count";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Calories";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Price";
            // 
            // cmbSoup
            // 
            this.cmbSoup.FormattingEnabled = true;
            this.cmbSoup.Location = new System.Drawing.Point(353, 202);
            this.cmbSoup.Name = "cmbSoup";
            this.cmbSoup.Size = new System.Drawing.Size(184, 39);
            this.cmbSoup.TabIndex = 111;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(558, 231);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(148, 39);
            this.button4.TabIndex = 110;
            this.button4.Text = "Редактировать";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(558, 181);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(148, 42);
            this.button5.TabIndex = 109;
            this.button5.Text = "Добавить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(232, 197);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 46);
            this.label8.TabIndex = 108;
            this.label8.Text = "Soup";
            // 
            // cmbMeat
            // 
            this.cmbMeat.FormattingEnabled = true;
            this.cmbMeat.Location = new System.Drawing.Point(353, 68);
            this.cmbMeat.Name = "cmbMeat";
            this.cmbMeat.Size = new System.Drawing.Size(184, 39);
            this.cmbMeat.TabIndex = 107;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(558, 89);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 46);
            this.button3.TabIndex = 106;
            this.button3.Text = "Редактировать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(558, 31);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 47);
            this.button2.TabIndex = 105;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(238, 68);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 46);
            this.label7.TabIndex = 104;
            this.label7.Text = "Meat";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(260, 381);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 55);
            this.button1.TabIndex = 103;
            this.button1.Text = "Готово";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cmbServingSize
            // 
            this.cmbServingSize.FormattingEnabled = true;
            this.cmbServingSize.Location = new System.Drawing.Point(522, 304);
            this.cmbServingSize.Name = "cmbServingSize";
            this.cmbServingSize.Size = new System.Drawing.Size(184, 39);
            this.cmbServingSize.TabIndex = 113;
            // 
            // txtServingSize
            // 
            this.txtServingSize.AutoSize = true;
            this.txtServingSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtServingSize.Location = new System.Drawing.Point(238, 296);
            this.txtServingSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtServingSize.Name = "txtServingSize";
            this.txtServingSize.Size = new System.Drawing.Size(243, 46);
            this.txtServingSize.TabIndex = 112;
            this.txtServingSize.Text = "Serving Size";
            // 
            // ComplexDishesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 462);
            this.Controls.Add(this.cmbServingSize);
            this.Controls.Add(this.txtServingSize);
            this.Controls.Add(this.cmbSoup);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbMeat);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Calories);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.Name);
            //this.Name = "ComplexDishesForm";
            this.Text = "ComplexDishesForm";
            this.Activated += new System.EventHandler(this.ComplexDishesForm_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox Count;
        private System.Windows.Forms.TextBox Calories;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbSoup;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbMeat;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbServingSize;
        private System.Windows.Forms.Label txtServingSize;
    }
}