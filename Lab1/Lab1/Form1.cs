using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            window = this;
            foreach (string i in Enum.GetNames(typeof(MenuItem.TCategorys)))
            {
                comboBox1.Items.Add(i);
            }
            saveFileDialog1.Filter = "Binary file|*.bin|Json file|*.json|Text file|*.txt";
            openFileDialog1.Filter = "Binary file|*.bin|Json file|*.json|Text file|*.txt";
        }
        public static Plug CurPlugin = null;
        public static Form1 window = null;
        public static List<MenuItem> AllOdj = new List<MenuItem>();
        public delegate void UpdateMethod(object obj, int index);

        public static Creator[] Creators = { new ComplexDishesCreator(), new DessertsCreator(), new MeatCreator(), new SaladsCreator(), new SnacksCreator(), new SoupCreator()};
        public static FileCreator[] FileCreators = { new BinFileCreator(), new JsonFileCreator(), new TextFileCreator() };
        public static object[] GetCommonData(TextBox Name, TextBox Count, TextBox Caloris, TextBox Price)
        {
            object[] values = new object[4];
            if (Name.Text != "" && Count.Text != "")
            {
                values[0] = (string)Name.Text;
                values[1] = Convert.ToInt32(Count.Text);
            }
            else
            {
                MessageBox.Show("В одном из текстовых полей нет данных!!");
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
                values[2] = Convert.ToDouble(Caloris.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Не верно введено значение количества каллорий");
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
                AllOdj.Add((MenuItem)Obj);
            }
            else
            {
                AllOdj.RemoveAt(ind);
                AllOdj.Insert(ind, (MenuItem)Obj);
            }
            ShowListView();
        }

        private void ShowListView()
        {
            int i = 0;
            listView1.Items.Clear();
            foreach (MenuItem item in AllOdj)
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

        private void btUpdate_Click(object sender, EventArgs e)
        {
            int j = 0;
            for (int i = 0; i <= AllOdj.Count - 1; i++)
            {
                    if (listView1.Items[j].Selected)
                    {
                        int ind = comboBox1.Items.IndexOf(listView1.Items[j].SubItems[0].Text);
                        Form form = Creators[ind].Create(AddObject, AllOdj[i], i);
                        form.Show();
                    }
                    j++;
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            int j = 0;
            for (int i = 0; i <= AllOdj.Count - 1; i++)
            {
                    if (listView1.Items[j].Selected)
                    {
                        AllOdj.RemoveAt(i);
                        listView1.Items.RemoveAt(j);
                    }
                    j++;
            }
        }
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            byte[] serialized = null;
            byte[] data = null;
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                serialized = new byte[(int)fs.Length];
                fs.Read(serialized, 0, serialized.Length);
            }
            int res = Plug.FindPlugin(filename);

            switch (res)
            {
                case -1:
                    MessageBox.Show("Соответствующий плагин отсутствует!!!");
                    return;
                case 1:
                    data = Plug.ActivatePlug(Form1.CurPlugin, serialized, false);
                    break;
                case 0:
                    data = serialized;
                    break;
            }
            AllOdj = FileCreators[openFileDialog1.FilterIndex - 1].FileOpen(data);
            ShowListView();
        }

        private void сохранитьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            byte[] data = FileCreators[saveFileDialog1.FilterIndex - 1].FileSave(AllOdj);
            ChoosePlugForm pluginForm = new ChoosePlugForm(data, filename);
            pluginForm.Show();
        }
    }
}
