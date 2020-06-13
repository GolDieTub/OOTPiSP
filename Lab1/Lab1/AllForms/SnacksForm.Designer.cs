namespace Lab1.AllForms
{
    partial class SnacksForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.TextBox();
            this.Calories = new System.Windows.Forms.TextBox();
            this.Count = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbFromWhat = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbServingSize = new System.Windows.Forms.ComboBox();
            this.txtServingSize = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 32);
            this.label4.TabIndex = 15;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 32);
            this.label3.TabIndex = 14;
            this.label3.Text = "Calories";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "Count";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name";
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(46, 369);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(150, 38);
            this.Price.TabIndex = 11;
            // 
            // Calories
            // 
            this.Calories.Location = new System.Drawing.Point(46, 271);
            this.Calories.Name = "Calories";
            this.Calories.Size = new System.Drawing.Size(150, 38);
            this.Calories.TabIndex = 10;
            // 
            // Count
            // 
            this.Count.Location = new System.Drawing.Point(46, 169);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(150, 38);
            this.Count.TabIndex = 9;
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(46, 74);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(150, 38);
            this.Name.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(383, 382);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 55);
            this.button1.TabIndex = 105;
            this.button1.Text = "Готово";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbFromWhat
            // 
            this.cmbFromWhat.FormattingEnabled = true;
            this.cmbFromWhat.Location = new System.Drawing.Point(477, 134);
            this.cmbFromWhat.Name = "cmbFromWhat";
            this.cmbFromWhat.Size = new System.Drawing.Size(184, 39);
            this.cmbFromWhat.TabIndex = 107;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(255, 126);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(206, 46);
            this.label7.TabIndex = 106;
            this.label7.Text = "FromWhat";
            // 
            // cmbServingSize
            // 
            this.cmbServingSize.FormattingEnabled = true;
            this.cmbServingSize.Location = new System.Drawing.Point(477, 260);
            this.cmbServingSize.Name = "cmbServingSize";
            this.cmbServingSize.Size = new System.Drawing.Size(184, 39);
            this.cmbServingSize.TabIndex = 109;
            // 
            // txtServingSize
            // 
            this.txtServingSize.AutoSize = true;
            this.txtServingSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtServingSize.Location = new System.Drawing.Point(227, 243);
            this.txtServingSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtServingSize.Name = "txtServingSize";
            this.txtServingSize.Size = new System.Drawing.Size(243, 46);
            this.txtServingSize.TabIndex = 108;
            this.txtServingSize.Text = "Serving Size";
            // 
            // SnacksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 462);
            this.Controls.Add(this.cmbServingSize);
            this.Controls.Add(this.txtServingSize);
            this.Controls.Add(this.cmbFromWhat);
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
            //this.Name = "SnacksForm";
            this.Text = "SnacksForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.TextBox Calories;
        private System.Windows.Forms.TextBox Count;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbFromWhat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbServingSize;
        private System.Windows.Forms.Label txtServingSize;
    }
}