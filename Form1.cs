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

namespace Hastaneotomasyon
{
    public partial class Form1 : Form
    {
        public Form1() //KULLANICI GİRİŞ
        {
            InitializeComponent();
        }
        //DB BAĞLANTISI
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=hastaneoto.mdb");
        private void button3_Click(object sender, EventArgs e)
        {
          
            //YÖNETİCİ GİRİŞ
            getir();
            con.Open();
           OleDbCommand komut = new OleDbCommand("select * from yönetici where k_adi = '" + textBox1.Text + "'and sifre = '" + textBox2.Text + "'", con);
            OleDbDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                yönetici yntc = new yönetici();
                yntc.Show();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO log(k_adi) VALUES('" + textBox1.Text + "')";
                cmd.ExecuteNonQuery();
                cmd.Dispose();

            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
            }
            con.Close();

            }
            public static string tal;
            public static string cen;
            private void getir()
             {
            con.Open();
            //OleDbCommand cm = new OleDbCommand("select k_adi , soyisim from yönetici where k_adi = ' " + textBox1.Text + " ' and sifre = ' " + textBox2.Text + " ' ", con);
            OleDbCommand cm = new OleDbCommand($"select k_adi , soyad from doktorliste where k_adi = '{textBox1.Text}' and sifre = '{textBox2.Text}' ", con);
             OleDbDataReader dr = cm.ExecuteReader();
             if (dr.Read())
            {
          
            }
            con.Close();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=hastaneoto.mdb");
        public static string sa;
        public static string ur;
        
        private void button1_Click(object sender, EventArgs e)
        {
            
        
            baglanti.Open();
            OleDbCommand bn = new OleDbCommand("select * from doktorliste where k_adi = '" + textBox1.Text + "'and sifre = '" + textBox2.Text + "'", baglanti);
            
            OleDbDataReader mc = bn.ExecuteReader();
            
            
            if (mc.Read())


            {
                sa = mc[0].ToString();
                ur = mc[1].ToString();
                Form2 frm2 = new Form2();
                frm2.Show();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baglanti;
                cmd.CommandText = "INSERT INTO log(k_adi) VALUES('" + textBox1.Text + "')";
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");

            }
            baglanti.Close();
        }
        //public static string k_adi;
        //public static string soyisim;
        private void saman()
        {
            //baglanti.Open();
            //SqlComman
          
        }
      
        private void button2_Click(object sender, EventArgs e)
        {
           
      
        }
        OleDbConnection mat = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=hastaneoto.mdb");
        private void button4_Click(object sender, EventArgs e)
        {
            mat.Open();
            OleDbCommand islem = new OleDbCommand("select * from bilgislem where k_adi = '" + textBox1.Text + "'and sifre = '" + textBox2.Text + "'", mat);
            OleDbDataReader gl = islem.ExecuteReader();
            if(gl.Read())
            {
                Form5 frm5 = new Form5();
                frm5.Show();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = mat;
                cmd.CommandText = "INSERT INTO log(k_adi) VALUES('" + textBox1.Text + "')";
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
            }
            mat.Close();
        }
       




private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            kaaan kaan = new kaaan();
            kaan.Show();


        }
    }
    }

    


