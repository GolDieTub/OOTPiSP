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
    public partial class MeatForm : Form
    {
        Form1.UpdateMethod Add_Display;
        int ObjectIndex;
        public MeatForm(Form1.UpdateMethod method, object obj, int index)
        {
            InitializeComponent();
            foreach (string i in Enum.GetNames(typeof(Meat.TMeatType)))
            {
                cmbMeatType.Items.Add(i);
            }
            foreach (string i in Enum.GetNames(typeof(HotDishes.TServing_size)))
            {
                cmbServingSize.Items.Add(i);
            }
            if (obj != null)
            {
                Name.Text = (obj as Meat).Name;
                Count.Text = (obj as Meat).Count.ToString();
                Calories.Text = (obj as Meat).Calorie_content.ToString();
                Price.Text = (obj as Meat).Price.ToString();
                cmbMeatType.SelectedItem = (obj as Meat).MeatType.ToString();
                cmbServingSize.SelectedItem = (obj as Meat).Serving_size.ToString();
            }
            Add_Display = method;
            ObjectIndex = index;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Meat.TMeatType meatType;
            HotDishes.TServing_size servingSize;
            if (cmbMeatType.SelectedItem != null && cmbServingSize.SelectedItem != null)
            {
                meatType = (Meat.TMeatType)Enum.Parse(typeof(Meat.TMeatType), cmbMeatType.SelectedItem.ToString());
                servingSize = (HotDishes.TServing_size)Enum.Parse(typeof(HotDishes.TServing_size), cmbServingSize.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("В комбо полей нет данных!!");
                return;
            }

            object[] value = Form1.GetCommonData(Name, Count, Calories, Price);
            if (value != null)
            {
                Meat meat = new Meat(meatType, servingSize, (string)value[0], (int)value[1], (double)value[2], (double)value[3]);
                Add_Display(meat, ObjectIndex);
                this.Close();
            }
        }

    }
}

