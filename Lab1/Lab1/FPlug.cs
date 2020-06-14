using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Lab1
{
    public partial class ChoosePlugForm : Form
    {

        private byte[] _Serialized_Data;
        private string Filename;
        public ChoosePlugForm(byte[] stream, string filename)
        {
            InitializeComponent();
            GetPlugs(Directory.GetCurrentDirectory() + "/Plugins");
            _Serialized_Data = stream;
            Filename = filename;
        }

        private void GetPlugs(string Path)
        {
            if (!Directory.Exists(Path))
            {
                return;
            }

            Plug curr = lstPlugins.SelectedItem as Plug;
            lstPlugins.BeginUpdate();
            lstPlugins.Items.Clear();

            foreach (string f in Directory.GetFiles(Path))
            {
                FileInfo fi = new FileInfo(f);

                if (fi.Extension.Equals(".dll"))
                {
                    lstPlugins.Items.Add(new Plug(f));
                }
            }
            lstPlugins.EndUpdate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.CurPlugin = lstPlugins.SelectedItem as Plug;
            if (Form1.CurPlugin != null)
            {
                byte[] data = Plug.ActivatePlug(Form1.CurPlugin, _Serialized_Data, true);
                using (FileStream fs = new FileStream(Filename, FileMode.OpenOrCreate))
                {
                    fs.Write(data, 0, data.Length);
                }
                Plug.SetCustomFileProperty(Filename, Form1.CurPlugin.Filename);
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.CurPlugin = null;
            using (FileStream fs = new FileStream(Filename, FileMode.OpenOrCreate))
            {
                fs.Write(_Serialized_Data, 0, _Serialized_Data.Length);
            }
            Plug.SetCustomFileProperty(Filename, "");
            this.Close();
        }
    }
}

