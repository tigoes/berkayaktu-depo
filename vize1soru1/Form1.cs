using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinavsarosu1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayi,tahmin,hak=10;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                tahmin = Convert.ToInt16(textBox1.Text);
                listBox1.Items.Add(tahmin);
                textBox1.Clear();
                hak--;
                if (tahmin > sayi)
                {
                    label1.Text = "Tahmininiz Gizli Sayıdan Küçük";
                }
                else if (tahmin < sayi)
                {
                    label1.Text = "Tahmininiz Gizli Sayıdan Büyük";

                }
                else if (tahmin == sayi)
                {
                    MessageBox.Show("Tebrikler");
                    button1.Enabled = false;
                }
                if (hak == 0)
                {
                    MessageBox.Show("Hakkınız Bitti");
                    button1.Enabled = false;
                }
            }
            catch 
            {

                MessageBox.Show("Lütfen alanı boş bırakmayınız bu size 1 hak ceza verdi");
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            sayi = rnd.Next(-1, 101);
            label1.Text = "";
        }
    }
}
