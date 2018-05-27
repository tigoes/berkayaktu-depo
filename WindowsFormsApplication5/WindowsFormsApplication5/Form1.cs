using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;    

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("@Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\DataBase1.accdb");
        OleDbCommand komut = new OleDbCommand();
        OleDbDataAdapter adtr = new OleDbDataAdapter();
        DataSet ds = new DataSet();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
                {
                    if(textBox1.Text !="" &&textBox2.Text !="" &&textBox3.Text !="" &&textBox4.Text !="" &&textBox5.Text !="" )
                    {
                        komut.Connection=baglanti;
                        komut.CommandText="Insert Into Tablo1(kimlik,Isım,Tarih,Askerlik) Values ('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"','"+textBox5.Text+"')";
                        baglanti.Open();
                        komut.ExecuteNonQuery();
                        komut.Dispose();
                        baglanti.Close();
                        MessageBox.Show("Kayıt Tamamlandı");
                    }
                }
            catch (Exception)
            {

                MessageBox.Show("Lütfen Bilgilerinizi Düzenleyip Tekrar Deneyiniz");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
                {
                    if(textBox1.Text !="" &&textBox2.Text !="" &&textBox3.Text !="" &&textBox4.Text !="" &&textBox5.Text !="" )
                    {
                        komut.Connection=baglanti;
                        komut.CommandText="Insert Update Tablo1(kimlik,Isım,Tarih,Askerlik) Values ('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"','"+textBox5.Text+"')";
                        baglanti.Open();
                        komut.ExecuteNonQuery();
                        komut.Dispose();
                        baglanti.Close();
                        MessageBox.Show("Kayıt Tamamlandı");
                    }
                }
            catch (Exception)
            {

                MessageBox.Show("Lütfen Bilgilerinizi Düzenleyip Tekrar Deneyiniz");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                    komut.Connection = baglanti;
                    komut.CommandText = "delete from tablo1 where id='"+textBox6.Text+"'";
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    komut.Dispose();
                    baglanti.Close();
                    MessageBox.Show("Kayıt Tamamlandı");
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen Bilgilerinizi Düzenleyip Tekrar Deneyiniz");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
