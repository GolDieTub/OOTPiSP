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
    public partial class SoupForm : Form
    {
        Form1.UpdateMethod Add_Display;
        int ObjectIndex;
        public SoupForm(Form1.UpdateMethod method, object obj, int index)
        {
            InitializeComponent();
            foreach (string i in Enum.GetNames(typeof(Soups.TliquidType)))
            {
                cmbLiquidType.Items.Add(i);
            }
            foreach (string i in Enum.GetNames(typeof(HotDishes.TServing_size)))
            {
                cmbServingSize.Items.Add(i);
            }
            if (obj != null)
            {
                Name.Text = (obj as Soups).Name;
                Count.Text = (obj as Soups).Count.ToString();
                Calories.Text = (obj as Soups).Calorie_content.ToString();
                Price.Text = (obj as Soups).Price.ToString();
                cmbLiquidType.SelectedItem = (obj as Soups).LiquidType;
                cmbServingSize.SelectedItem = (obj as Soups).Serving_size;
            }
            Add_Display = method;
            ObjectIndex = index;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool withMeat;
            bool coldSoup;
            HotDishes.TServing_size servingSize;
            Soups.TliquidType liquidType;
            if (cmbLiquidType.SelectedItem != null && cmbServingSize.SelectedItem != null)
            {
                liquidType = (Soups.TliquidType)Enum.Parse(typeof(Soups.TliquidType), cmbLiquidType.SelectedItem.ToString());
                servingSize = (HotDishes.TServing_size)Enum.Parse(typeof(HotDishes.TServing_size), cmbServingSize.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("В комбо полей нет данных!!");
                return;
            }
            withMeat = chbWithMeat.Checked;
            coldSoup = chbColdSoup.Checked;
            object[] value = Form1.GetCommonData(Name, Count, Calories, Price);
            if (value != null)
            {
                Soups soup = new Soups(withMeat, coldSoup, liquidType, servingSize, (string)value[0], (int)value[1], (double)value[2], (double)value[3]);
                Add_Display(soup, ObjectIndex);
                this.Close();
            }
        }
    }
}

