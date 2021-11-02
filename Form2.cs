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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            label1.Text = Form1.sa.ToString();
            label2.Text = Form1.ur.ToString();
            //label1.Text = Form1.onur.ToString();
            //label2.Text = Form1.zaaz.ToString();

        }
        //DB BAĞLANTISI
        OleDbConnection agla = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=hastaneoto.mdb");
        private void button1_Click(object sender, EventArgs e)
        {
            //RANDEVU LİSTELEME
            agla.Open();
            OleDbCommand komut = new OleDbCommand("select * from randevu", agla);
            OleDbDataAdapter adpr = new OleDbDataAdapter(komut);
            DataTable tb = new DataTable();
            adpr.Fill(tb);
            dataGridView1.DataSource = tb;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        OleDbConnection demir = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=hastaneoto.mdb");
        private void button2_Click(object sender, EventArgs e)
        {
            //AMELİYATLAR FORMUNA GEÇİŞ
            ameliyatlar aml = new ameliyatlar();
            aml.Show();
            
        }
        OleDbConnection tarak = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=hastaneoto.mdb");
        private void button3_Click(object sender, EventArgs e)
        {
            //kon
            tarak.Open();
            OleDbCommand komut = new OleDbCommand("select * from konsültasyon", tarak);
            OleDbDataAdapter adpr = new OleDbDataAdapter(komut);
            DataTable tb = new DataTable();
            adpr.Fill(tb);
            dataGridView1.DataSource = tb;
            tarak.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            konsültasyon kons = new konsültasyon();
            kons.Show();
        }
    }
}
