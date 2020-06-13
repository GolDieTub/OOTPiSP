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
    public partial class SnacksForm : Form
    {
        Form1.UpdateMethod Add_Display;
        int ObjectIndex;
        public SnacksForm(Form1.UpdateMethod method, object obj, int index)
        {
            InitializeComponent();
            foreach (string i in Enum.GetNames(typeof(Snacks.TFromWhat)))
            {
                cmbFromWhat.Items.Add(i);
            }
            foreach (string i in Enum.GetNames(typeof(ColdDishes.TServing_size)))
            {
                cmbServingSize.Items.Add(i);
            }

            if (obj != null)
            {
                Name.Text = (obj as Snacks).Name;
                Count.Text = (obj as Snacks).Count.ToString();
                Calories.Text = (obj as Snacks).Calorie_content.ToString();
                Price.Text = (obj as Snacks).Price.ToString();
                cmbFromWhat.SelectedItem = (obj as Snacks).FromWhat;
                cmbServingSize.SelectedItem = (obj as Snacks).Serving_size;
            }
            Add_Display = method;
            ObjectIndex = index;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColdDishes.TServing_size servingSize;
            Snacks.TFromWhat fromWhat;
            if (cmbFromWhat.SelectedItem != null && cmbServingSize.SelectedItem != null)
            {
                fromWhat = (Snacks.TFromWhat)Enum.Parse(typeof(Snacks.TFromWhat), cmbFromWhat.SelectedItem.ToString());
                servingSize = (ColdDishes.TServing_size)Enum.Parse(typeof(ColdDishes.TServing_size), cmbServingSize.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("В комбооксах не хватает данных!!");
                return;
            }
            object[] value = Form1.GetCommonData(Name, Count, Calories, Price);
            if (value != null)
            {
                Snacks snack = new Snacks(fromWhat, servingSize, (string)value[0], (int)value[1], (double)value[2], (double)value[3]);
                Add_Display(snack, ObjectIndex);
                this.Close();
            }
        }
    }
}

