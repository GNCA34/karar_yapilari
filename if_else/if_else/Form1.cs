using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace if_else
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="ali")
            {
                label1.Text = "doğru";
            }
            else
            {
                label1.Text = "yanlış";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi = 5;
            int girilen_değer;
            girilen_değer = Convert.ToInt16(textBox2.Text);
            if (girilen_değer==sayi)
            {
                label2.Text = "doğru";
            }
            else
            {
                label2.Text = "yanlış";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt16(textBox3.Text);
            if (sayi%2==0)
            {
                label3.Text = "Sayı çifttir.";
            }
            else
            {
                label3.Text = "Sayı tektir.";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt16(textBox4.Text);
            if (sayi % 2 == 0 && sayi>=10)
            {
                label4.Text = "Sayı çifttir ve 10 dan büyük eşittir.";
            }
            else
            {
                label4.Text = "Sayı çift değil veya 10'dan büyük değildir.";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt16(textBox5.Text);
            if (sayi % 2 == 0 || sayi >= 10)
            {
                label5.Text = "Sayı çifttir ya da  10 dan büyük eşittir.";
            }
            else
            {
                label5.Text = "Sayı çift değil ya da  10'dan büyük değildir.";
            }
        }
    }
}
