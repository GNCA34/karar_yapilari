using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace switch_case
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ay = Convert.ToInt16(textBox1.Text);
            switch (ay)
            {
                case 1:label2.Text = "Ocak";
                    break;
                case 2:label2.Text = "Şubat";break;
                case 3:label2.Text = "Mart"; break;
                case 4:label2.Text = "Nisan";break;
                case 5:label2.Text = "Mayıs";break;
                case 6:label2.Text = "Haziran";break;
                case 7:label2.Text = "Temmuz";break;
                case 8:label2.Text = "Ağustos";break;
                case 9:label2.Text = "Eylül";break;
                case 10:label2.Text = "Ekim";break;
                case 11:label2.Text = "Kasım";break;
                case 12:label2.Text = "Aralık";break;
                default: label2.Text="Hatalı Ay";break;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //klavyeden girilen mevsime göre o mevsimin aylarını veren kod
            string mevsim;
            mevsim = textBox2.Text;
            switch (mevsim)
            {
                case "yaz": label4.Text="haziran,temmuz,ağustos" ;break;
                case "kış": label4.Text = "aralık,ocak,şubat";break;
                case "ilkbahar":label4.Text = "mart,nisan,mayıs";break;
                case "sonbahar":label4.Text = "eylül,ekim,kasım";break;
                default: label4.Text = "Hatalı mevsim girdiniz.";
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2;
            string isaret;
            sayi1 = Convert.ToInt32(textBox3.Text);
            sayi2 = Convert.ToInt32(textBox4.Text);
           
            isaret = Convert.ToString(textBox5.Text);
            
            switch (isaret)
            {
                case "+":label8.Text = Convert.ToString(sayi1+sayi2); break;
                case "-":label8.Text = Convert.ToString(sayi1-sayi2);break;
                case "*":label8.Text = Convert.ToString(sayi1*sayi2);break;
                case "/":label8.Text = Convert.ToString(sayi1/sayi2);break;

                default: label8.Text = "Hatali işaret girişi yaptınız";break;
            }
        }

        private string To(int v)
        {
            throw new NotImplementedException();
        }

        private string ToString(string v)
        {
            throw new NotImplementedException();
        }
    }
}
//Klavyeden girilen sayılara göre aritmetik işarete göre hesaplama yap