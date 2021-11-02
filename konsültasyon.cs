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
    public partial class konsültasyon : Form
    {
        public konsültasyon()
        {
            InitializeComponent();
        }
        OleDbConnection baglantik = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = hastaneoto.mdb");
        private void button1_Click(object sender, EventArgs e)
        {
            baglantik.Open();
            OleDbCommand jale = new OleDbCommand("Select * from hastadoya where dosyano like '%" + textBox1.Text + "%'", baglantik);
            OleDbDataAdapter da = new OleDbDataAdapter(jale);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglantik.Close();
            dataGridView1.Columns[0].Visible = false;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int seçilenalan = dataGridView1.SelectedCells[0].RowIndex;
            string dosyano = dataGridView1.Rows[seçilenalan].Cells[0].Value.ToString();
            string ismi = dataGridView1.Rows[seçilenalan].Cells[1].Value.ToString();
            string soyisim = dataGridView1.Rows[seçilenalan].Cells[2].Value.ToString();
            string tc = dataGridView1.Rows[seçilenalan].Cells[3].Value.ToString();
            string tarih = dataGridView1.Rows[seçilenalan].Cells[4].Value.ToString();
            string babadi = dataGridView1.Rows[seçilenalan].Cells[5].Value.ToString();
            string anneadi = dataGridView1.Rows[seçilenalan].Cells[6].Value.ToString();
            string kanGrubu = dataGridView1.Rows[seçilenalan].Cells[7].Value.ToString();
            string cinsiyet = dataGridView1.Rows[seçilenalan].Cells[8].Value.ToString();
            string adres = dataGridView1.Rows[seçilenalan].Cells[9].Value.ToString();
            string medenihal = dataGridView1.Rows[seçilenalan].Cells[10].Value.ToString();
            string telefon = dataGridView1.Rows[seçilenalan].Cells[11].Value.ToString();

            textBox2.Text = dosyano;
            textBox3.Text = ismi;
            textBox4.Text = soyisim;
            textBox5.Text = tc;
            textBox6.Text = tarih;
            textBox7.Text = babadi;
            textBox8.Text = anneadi;
            textBox9.Text = kanGrubu;
            textBox10.Text = cinsiyet;
            textBox11.Text = adres;
            textBox12.Text = medenihal;
            textBox13.Text = telefon;



        }

        private void konsültasyon_Load(object sender, EventArgs e)
        {
            label8.Text = Form1.sa.ToString();
            label9.Text = Form1.ur.ToString();
            OleDbConnection bro = new OleDbConnection();
            bro.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=hastaneoto.mdb";
            OleDbCommand jennifer = new OleDbCommand();
            OleDbCommand jr = new OleDbCommand();
            jennifer.CommandText = "SELECT *from doktorliste";
            jr.CommandText = "SELECT *from Hemşire";
            jennifer.Connection = bro;
            jennifer.CommandType = CommandType.Text;
            OleDbDataReader dr;
            bro.Open();
            dr = jennifer.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["k_adi"]);
                
            }
            bro.Close();







        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (baglantik.State == ConnectionState.Closed)
            {
                baglantik.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baglantik;
                cmd.CommandText = "INSERT INTO konsültasyon(ismi,soyisim,tc,kayit_tarih,kanGrubu,cinsiyet,doktoru,poliklinik,saglikg,öncelik) VALUES('" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox14.Text + "','" + textBox10.Text + "','" + textBox9.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + comboBox4.Text + "','" + comboBox3.Text + "')";
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglantik.Close();
                serap();
                MessageBox.Show("Konsültasyon kaydı tamamlanmıştır");
            }
        }
        void serap()
        {
            if (baglantik.State == ConnectionState.Closed)
            {
                baglantik.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baglantik;
                cmd.CommandText = "select * from konsültasyon";
                OleDbDataAdapter adpr = new OleDbDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpr.Fill(ds, "konsültasyon");
                dataGridView1.DataSource = ds.Tables["konsültasyon"];

                baglantik.Close();
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            hastasevk hstn = new hastasevk();
            hstn.Show();
        }
    }
    }

