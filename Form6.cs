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
    public partial class Form6 : Form
    {
        OleDbConnection connect = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=hastaneoto.mdb");
        public Form6()
        {
            InitializeComponent();
        }
        public string ConnectionString
        {
            get { return "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=hastaneoto.mdb"; }

        }




        private void Form6_Load(object sender, EventArgs e)
        {
            
            OleDbConnection bro = new OleDbConnection();
            bro.ConnectionString =@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=hastaneoto.mdb";
            OleDbCommand jennifer = new OleDbCommand();
            jennifer.CommandText = "SELECT *from doktorliste";
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = connect;
                cmd.CommandText = "INSERT INTO randevu(isim,soyisim,tc,randevu_tarih,saat,doktor,HastaDurumu) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "')";
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                connect.Close();
                listeleme();
                MessageBox.Show("Randevu kayıdı tamamlanmıştır");

            }
        }
        void listeleme()
        {
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = connect;
                cmd.CommandText = "select * from randevu";
                OleDbDataAdapter adpr = new OleDbDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpr.Fill(ds, "randevu");
                dataGridView1.DataSource = ds.Tables["randevu"];
                dataGridView1.Columns[6].Visible = false;

                connect.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çalışan kaydını silmek istediğinize eminmisiniz", "DİKKAT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = connect;
                    cmd.CommandText = "delete from randevu where isim=@numara";
                    cmd.Parameters.AddWithValue("@numara", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    connect.Close();
                    listeleme();


                }

            }
        }

        private void Form6_Load_1(object sender, EventArgs e)
        {
            OleDbConnection bro = new OleDbConnection();
            bro.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=hastaneoto.mdb";
            OleDbCommand jennifer = new OleDbCommand();
            
            jennifer.CommandText = "SELECT *from doktorliste";
            
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
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çalışan kaydını silmek istediğinize eminmisiniz", "DİKKAT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = connect;
                    cmd.CommandText = "delete from randevu where isim=@numara";
                    cmd.Parameters.AddWithValue("@numara", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    connect.Close();
                    listeleme();


                }

            }
        }
    }
}