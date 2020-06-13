using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab1.AllForms;

namespace Lab1
{
    public abstract class Creator
    {
        public abstract Form Create(Form1.UpdateMethod method, object obj, int index);
    }
        
    class MeatCreator : Creator
    {
        public override Form Create(Form1.UpdateMethod method, object obj, int index)
        {
            return new MeatForm(method, obj, index);
        }
    }

    class SoupCreator : Creator
    {
        public override Form Create(Form1.UpdateMethod method, object obj, int index)
        {
            return new SoupForm(method, obj, index);
        }
    }

    class DessertsCreator : Creator
    {
        public override Form Create(Form1.UpdateMethod method, object obj, int index)
        {
            return new DessertsForm(method, obj, index);
        }
    }

    class SnacksCreator : Creator
    {
        public override Form Create(Form1.UpdateMethod method, object obj, int index)
        {
            return new SnacksForm(method, obj, index);
        }
    }

    class SaladsCreator : Creator
    {
        public override Form Create(Form1.UpdateMethod method, object obj, int index)
        {
            return new SaladsForm(method, obj, index);
        }
    }

    class ComplexDishesCreator : Creator
    {
        public override Form Create(Form1.UpdateMethod method, object obj, int index)
        {
            return new ComplexDishesForm(method, obj, index);
        }
    }
  
}
