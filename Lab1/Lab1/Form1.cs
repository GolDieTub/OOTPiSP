using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            window = this;
            listView1.View = View.Details;
            foreach (string i in Enum.GetNames(typeof(MenuItem.TCategorys)))
            {
                comboBox1.Items.Add(i);
            }
        }
        public static Form1 window = null;
        public static List<MenuItem> Catalog = new List<MenuItem>();
        public delegate void UpdateMethod(object obj, int index);

        public static Creator[] Creators = { new ComplexDishesCreator(), new DessertsCreator(), new MeatCreator(), new SaladsCreator(), new SnacksCreator(), new SoupCreator()};

        public static object[] GetCommonData(TextBox Name, TextBox Count, TextBox Caloris, TextBox Price)
        {
            object[] values = new object[5];
            if (Name.Text != "" && Cloth.Text != "")
            {
                values[0] = (string)Name.Text;
                values[1] = (string)Cloth.Text;
            }
            else
            {
                MessageBox.Show("В одном из текстовых полей нет данных!!");
                return null;
            }
            if (Color.SelectedItem != null)
            {
                values[4] = (MenuItem.TColor)Enum.Parse(typeof(MenuItem.TColor), Color.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("В одном из комбо полей нет данных!!");
                return null;
            }
            try
            {
                values[3] = Convert.ToDouble(Price.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Не верно введена стоимость");
                return null;
            }
            try
            {
                values[2] = Convert.ToInt32(Length.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Не верно введена длина");
                return null;
            }
            return values;
        }
        private void btCreate_Click(object sender, EventArgs e)
        {
 
                if (comboBox1.SelectedIndex != -1)
                {
                    object obj = null;
                    Form form = Creators[comboBox1.SelectedIndex].Create(AddObject, obj, -1);
                    form.Show();
            }
            
        }

        public void AddObject(object Obj, int ind)
        {
            if (ind == -1)
            {
                Catalog.Add((MenuItem)Obj);
            }
            else
            {
                Catalog.RemoveAt(ind);
                Catalog.Insert(ind, (MenuItem)Obj);
            }
            ShowListView();
        }

        private void ShowListView()
        {
            int i = 0;
            listView1.Items.Clear();
            foreach (MenuItem item in Catalog)
            {
                    AddLinetoListView();
                    listView1.Items[i].SubItems[0].Text = item.Category.ToString();
                    listView1.Items[i].SubItems[1].Text = item.Name;
                    listView1.Items[i].SubItems[2].Text = item.Count.ToString();
                    listView1.Items[i].SubItems[3].Text = item.Calorie_content.ToString();
                    listView1.Items[i].SubItems[4].Text = item.Price.ToString();
                    i++;
            }
        }

        public static void AddLinetoListView()
        {
            ListViewItem lvi = new ListViewItem();
            for (int i = 0; i < 6; i++)
            {
                ListViewItem.ListViewSubItem lvsi = new ListViewItem.ListViewSubItem();
                lvi.SubItems.Add(lvsi);
            }
            Form1.window.listView1.Items.Add(lvi);
        }

    }
}
