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
    public partial class ComplexDishesForm : Form
    {
        Form1.UpdateMethod Add_Display;
        int ObjectIndex;
        public ComplexDishesForm(Form1.UpdateMethod method, object obj, int index)
        {
            InitializeComponent();
            foreach (string i in Enum.GetNames(typeof(HotDishes.TServing_size)))
            {
                cmbServingSize.Items.Add(i);
            }
            foreach (MenuItem item in Form1.Catalog)
            {
                if (item.Category == MenuItem.TCategorys.Meat)
                    cmbMeat.Items.Add(item.Name);
                if (item.Category == MenuItem.TCategorys.Soups)
                    cmbSoup.Items.Add(item.Name);
            }
            if (obj != null)
            {
                Name.Text = (obj as ComplexDishes).Name;
                Count.Text = (obj as ComplexDishes).Count.ToString();
                Calories.Text = (obj as ComplexDishes).Calorie_content.ToString();
                Price.Text = (obj as ComplexDishes).Price.ToString();
                cmbMeat.SelectedItem = (obj as ComplexDishes).Meat.Name;
                cmbSoup.SelectedItem = (obj as ComplexDishes).Soups.Name;
                cmbServingSize.SelectedItem = (obj as ComplexDishes).Serving_size;
            }
            Add_Display = method;
            ObjectIndex = index;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Meat meat;
            Soups soups;
            HotDishes.TServing_size servingSize;
            if (cmbMeat.SelectedItem != null && cmbSoup.SelectedItem != null && cmbServingSize.SelectedItem != null)
            {
                meat = (Meat)Form1.Catalog.Find(x => x.Name == cmbMeat.SelectedItem.ToString() && x.Category == MenuItem.TCategorys.Meat);
                soups = (Soups)Form1.Catalog.Find(x => x.Name == cmbSoup.SelectedItem.ToString() && x.Category == MenuItem.TCategorys.Soups);
                servingSize = (HotDishes.TServing_size)Enum.Parse(typeof(HotDishes.TServing_size), cmbServingSize.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("В одном из комбо полей нет данных!!");
                return;
            }

            object[] value = Form1.GetCommonData(Name, Count, Calories, Price);
            if (value != null)
            {
                ComplexDishes complexDishes = new ComplexDishes(meat, soups, servingSize, (string)value[0], (int)value[1], (double)value[2], (double)value[3]);
                Add_Display(complexDishes, ObjectIndex);
                this.Close();
            }
        }

        private void DressForm_Activated(object sender, EventArgs e)
        {
            object obj1 = cmbMeat.SelectedItem;
            object obj2 = cmbSoup.SelectedItem;
            cmbMeat.Items.Clear();
            cmbSoup.Items.Clear();
            foreach (MenuItem item in Form1.Catalog)
            {
                if (item.Category == MenuItem.TCategorys.Meat)
                    cmbMeat.Items.Add(item.Name);
                if (item.Category == MenuItem.TCategorys.Soups)
                    cmbSoup.Items.Add(item.Name);
            }
            cmbMeat.SelectedItem = obj1;
            cmbSoup.SelectedItem = obj2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            object obj = null;
            Form form = Form1.Creators[2].Create(Form1.window.AddObject, obj, -1);
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            object obj = null;
            Form form = Form1.Creators[5].Create(Form1.window.AddObject, obj, -1);
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            object obj = Form1.Catalog.Find(x => x.Name == cmbMeat.SelectedItem.ToString() && x.Category == MenuItem.TCategorys.Meat);
            int ind = (int)(obj as Meat).Category;
            int i = Form1.Catalog.IndexOf((Meat)obj);
            Form form = Form1.Creators[ind].Create(Form1.window.AddObject, obj, i);
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            object obj = Form1.Catalog.Find(x => x.Name == cmbSoup.SelectedItem.ToString() && x.Category == MenuItem.TCategorys.Soups);
            int ind = (int)(obj as Soups).Category;
            int i = Form1.Catalog.IndexOf((Soups)obj);
            Form form = Form1.Creators[ind].Create(Form1.window.AddObject, obj, i);
            form.Show();
        }

        private void ComplexDishesForm_Activated(object sender, EventArgs e)
        {
            object obj1 = cmbMeat.SelectedItem;
            object obj2 = cmbSoup.SelectedItem;
            cmbMeat.Items.Clear();
            cmbSoup.Items.Clear();
            foreach (MenuItem item in Form1.Catalog)
            {
                if (item.Category == MenuItem.TCategorys.Meat)
                    cmbMeat.Items.Add(item.Name);
                if (item.Category == MenuItem.TCategorys.Soups)
                    cmbSoup.Items.Add(item.Name);
            }
            cmbMeat.SelectedItem = obj1;
            cmbSoup.SelectedItem = obj2;
        }
    }
}