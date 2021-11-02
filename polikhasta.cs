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
    public partial class polikhasta : Form
    {
        public polikhasta()
        {
            InitializeComponent();
        }
        OleDbConnection baglantis = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = hastaneoto.mdb");
        private void button1_Click(object sender, EventArgs e)
        {
            baglantis.Open();
            OleDbCommand cod = new OleDbCommand("select * from poliklinikhastalistesi where poliklinik", baglantis);
            OleDbDataAdapter adpn = new OleDbDataAdapter(cod);
            DataTable nj = new DataTable();
            adpn.Fill(nj);
            dataGridView1.DataSource = nj;
           
        }
        OleDbConnection cano = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = hastaneoto.mdb");
        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hasta kaydını silmek istediğinizden eminmisiniz?", "DİKKAT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (cano.State == ConnectionState.Closed)
                {
                    cano.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = cano;
                    cmd.CommandText = "delete from poliklinikhastalistesi where id=@numara";
                    cmd.Parameters.AddWithValue("@numara", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    cano.Close();
                    serap();
                }
            }
        }
        OleDbConnection nope= new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = hastaneoto.mdb");
        private void button2_Click(object sender, EventArgs e)
        {
            if (nope.State == ConnectionState.Closed)
            {
                nope.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = nope;
                cmd.CommandText = "INSERT INTO poliklinikhastalistesi(ad,soyad,tc,poliklinik) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "')";
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                nope.Close();
                serap();
                MessageBox.Show("hasta kayıdı tamamlanmıştır");
            }
        }
        void serap()
        {
            if (nope.State == ConnectionState.Closed)
            {
                nope.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = nope;
                cmd.CommandText = "select * from poliklinikhastalistesi";
                OleDbDataAdapter adpr = new OleDbDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpr.Fill(ds, "poliklinikhastalistesi");
                dataGridView1.DataSource = ds.Tables["poliklinikhastalistesi"];

                nope.Close();
            }
        }

        private void polikhasta_Load(object sender, EventArgs e)
        {

            OleDbConnection bro = new OleDbConnection();
            bro.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=hastaneoto.mdb";
            OleDbCommand jennifer = new OleDbCommand();
            jennifer.CommandText = "SELECT *from poliklinikhastalistesi";
            jennifer.Connection = bro;
            jennifer.CommandType = CommandType.Text;
            OleDbDataReader dr;
            bro.Open();
            dr = jennifer.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["poliklinik"]);
            }
            bro.Close();







        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

