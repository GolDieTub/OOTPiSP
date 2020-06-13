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
    public partial class DessertsForm : Form
    {
        Form1.UpdateMethod Add_Display;
        int ObjectIndex;
        public DessertsForm(Form1.UpdateMethod method, object obj, int index)
        {
            InitializeComponent();
            foreach (string i in Enum.GetNames(typeof(Desserts.TDesserts)))
            {
                cmbDesserts.Items.Add(i);
            }
            
            if (obj != null)
            {
                Name.Text = (obj as Desserts).Name;
                Count.Text = (obj as Desserts).Count.ToString();
                Calories.Text = (obj as Desserts).Calorie_content.ToString();
                Price.Text = (obj as Desserts).Price.ToString();
                cmbDesserts.SelectedItem = (obj as Desserts).MyDesserts;
            }
            Add_Display = method;
            ObjectIndex = index;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Desserts.TDesserts desserts;
            if (cmbDesserts.SelectedItem != null)
            {
                desserts = (Desserts.TDesserts)Enum.Parse(typeof(Desserts.TDesserts), cmbDesserts.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("В комбо полей нет данных!!");
                return;
            }
            object[] value = Form1.GetCommonData(Name, Count, Calories, Price);
            if (value != null)
            {
                Desserts dessert = new Desserts(desserts, (string)value[0], (int)value[1], (double)value[2], (double)value[3]);
                Add_Display(dessert, ObjectIndex);
                this.Close();
            }
        }
    }
}