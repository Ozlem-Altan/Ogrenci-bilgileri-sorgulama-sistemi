using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listview_ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<string> ogrenciler = new List<string>();
        public string secim;
        string ad, soyad, no;
        private void button1_Click(object sender, EventArgs e)
        {
            ad = textBox1.Text;
            soyad = textBox2.Text;
            no=textBox3.Text;
            ogrenciler.Add(ad);
            ogrenciler.Add(soyad);
            ogrenciler.Add(no);
            string[] satir = { ad, soyad, no };
            ListViewItem item = new ListViewItem(satir);
            listView1.Items.Add(item);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Select();
        }
        
        private void listView1_DoubleClick(object sender, EventArgs e)
        {

            secim = listView1.SelectedItems[0].Text;
            this.Hide();
            Form2 form2 = new Form2(ogrenciler,secim);
            form2.Show();
            
        }
    }
}
