using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1.AllForms
{
    public partial class SaladsForm : Form
    {
        Form1.UpdateMethod Add_Display;
        int ObjectIndex;
        public SaladsForm(Form1.UpdateMethod method, object obj, int index)
        {
            InitializeComponent();
            foreach (string i in Enum.GetNames(typeof(Salads.TEddition)))
            {
                cmbEddition.Items.Add(i);
            }
            foreach (string i in Enum.GetNames(typeof(ColdDishes.TServing_size)))
            {
                cmbServingSize.Items.Add(i);
            }
            if (obj != null)
            {
                Name.Text = (obj as Salads).Name;
                Count.Text = (obj as Salads).Count.ToString();
                Calories.Text = (obj as Salads).Calorie_content.ToString();
                Price.Text = (obj as Salads).Price.ToString();
                cmbEddition.SelectedItem = (obj as Salads).Eddition.ToString();
                cmbServingSize.SelectedItem = (obj as Salads).Serving_size.ToString();
            }
            Add_Display = method;
            ObjectIndex = index;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool withFruit;
            bool withVegan;
            ColdDishes.TServing_size servingSize;
            Salads.TEddition eddition;
            if (cmbEddition.SelectedItem != null && cmbServingSize.SelectedItem != null)
            {
                eddition = (Salads.TEddition)Enum.Parse(typeof(Salads.TEddition), cmbEddition.SelectedItem.ToString());
                servingSize = (ColdDishes.TServing_size)Enum.Parse(typeof(ColdDishes.TServing_size), cmbServingSize.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("В комбо полей нет данных!!");
                return;
            }
            withFruit = chbFruit.Checked;
            withVegan = chbVeg.Checked;
            object[] value = Form1.GetCommonData(Name, Count, Calories, Price);
            if (value != null)
            {
                Salads salad = new Salads(eddition, withFruit, withVegan, servingSize, (string)value[0], (int)value[1], (double)value[2], (double)value[3]);
                Add_Display(salad, ObjectIndex);
                this.Close();
            }
        }
    }
}

