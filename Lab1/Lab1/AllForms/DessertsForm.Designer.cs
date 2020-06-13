namespace Lab1.AllForms
{
    partial class DessertsForm
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
            this.cmbDesserts = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 32);
            this.label4.TabIndex = 15;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 32);
            this.label3.TabIndex = 14;
            this.label3.Text = "Calories";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "Count";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name";
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(47, 373);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(150, 38);
            this.Price.TabIndex = 11;
            // 
            // Calories
            // 
            this.Calories.Location = new System.Drawing.Point(47, 275);
            this.Calories.Name = "Calories";
            this.Calories.Size = new System.Drawing.Size(150, 38);
            this.Calories.TabIndex = 10;
            // 
            // Count
            // 
            this.Count.Location = new System.Drawing.Point(47, 173);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(150, 38);
            this.Count.TabIndex = 9;
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(47, 78);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(150, 38);
            this.Name.TabIndex = 8;
            // 
            // cmbDesserts
            // 
            this.cmbDesserts.FormattingEnabled = true;
            this.cmbDesserts.Location = new System.Drawing.Point(351, 108);
            this.cmbDesserts.Name = "cmbDesserts";
            this.cmbDesserts.Size = new System.Drawing.Size(206, 39);
            this.cmbDesserts.TabIndex = 104;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(334, 51);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(263, 46);
            this.label10.TabIndex = 103;
            this.label10.Text = "Desserts type";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(325, 373);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 55);
            this.button1.TabIndex = 105;
            this.button1.Text = "Готово";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DessertsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 462);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbDesserts);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Calories);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.Name);
            //this.Name = "DessertsForm";
            this.Text = "DessertsForm";
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
        private System.Windows.Forms.ComboBox cmbDesserts;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
    }
}