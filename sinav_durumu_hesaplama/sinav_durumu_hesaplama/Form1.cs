using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinav_durumu_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sinav1, sinav2, proje, ortalama;
            string durum;
            sinav1 = Convert.ToDouble(textBox1.Text);
            sinav2 = Convert.ToDouble(textBox2.Text);
            proje = Convert.ToDouble(textBox3.Text);
            ortalama = (sinav1 + sinav2 + proje) / 3;
            if (ortalama>=50)
            {
                durum = "geçti";
            }
            else
            {
                durum = "kaldı";
            }
            textBox4.Text = ortalama + "\n " + durum;

        }
    }
}
