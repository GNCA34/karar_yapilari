using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alisveris_indirim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kitapadet;
            double toplam;
            kitapadet = Convert.ToInt16(textBox1.Text);
            if (kitapadet>=0 && kitapadet<=20)
            {
                toplam = (kitapadet * 8) - (kitapadet * 8)* 0.2;
                label3.Text = toplam + " TL";
            }
            if (kitapadet>=21 && kitapadet<=40)
            {
                toplam = (kitapadet * 8) - (kitapadet * 8 * 0.4);
                label3.Text = toplam + " TL";

            }
            if (kitapadet>=41)
            {
                toplam = (kitapadet * 8) - (kitapadet * 8 * 0.5);
                label3.Text = toplam + " TL";
            }
        }
    }
}

//0-20 ==> %20
//21-40 ==> %40
//41++ ==>%50
//Kitap=8

