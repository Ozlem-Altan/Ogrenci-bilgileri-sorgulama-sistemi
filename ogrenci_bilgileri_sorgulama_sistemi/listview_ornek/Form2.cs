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
    public partial class Form2 : Form
    {
        public List<string> ogrenciler = new List<string>();
        string secim;
        public Form2(List<string>ogr, string secim)
        {
            InitializeComponent();
            ogrenciler = ogr;
            this.secim = secim;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int y = 0;
            string ad, soyad, no, cins, sinif, tc;
            switch (secim)
            {
                case "derya":
                    for (int i = 0; i < 1; i++)
                    {
                       
                        ad = ogrenciler[i + y];
                        soyad = ogrenciler[i + y + 1];
                        no = ogrenciler[i + y + 2];
                        
                        cins = "kadın";
                        sinif= "12/TB";
                        tc = "11111111111";
                        y = y + 2;
                        string[] satir = { ad, soyad, no,cins,sinif,tc };
                        ListViewItem item = new ListViewItem(satir);
                        listView1.Items.Add(item);

                    }
                    break;

                case "selin":
                    for (int i = 0; i <1; i++)
                    {
                        ad = ogrenciler[i + y+3];
                        soyad = ogrenciler[i + y + 4];
                        no = ogrenciler[i + y + 5];

                        cins = "kadın";
                        sinif = "10/B";
                        tc = "22222222222";
                        y = y + 2;
                        string[] satir = { ad, soyad, no, cins, sinif, tc };
                        ListViewItem item = new ListViewItem(satir);
                        listView1.Items.Add(item);

                    }
                    break;

                default:
                    MessageBox.Show("Kayıt Bulunamadı");
                    break;
            }

        }
    }
}
