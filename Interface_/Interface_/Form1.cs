using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Oyuncu o = new Oyuncu();
            o.Adi = "Mikayil";
            o.Yasi = 22;
            o.YasamDegeri = 200;
            o.Silahi = new Kanas();
            MessageBox.Show(o.NisanAl());
            Oyuncu o2 = new Oyuncu();
            Bicak bck = new Bicak();
            o2.Silahi = bck;
            MessageBox.Show(o2.NisanAl());
        }
    }
}
