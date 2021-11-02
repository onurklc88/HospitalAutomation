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
    public partial class ameliyatlar : Form
    {
        public ameliyatlar()
        {
            InitializeComponent();
        }
        OleDbConnection baglantik = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = hastaneoto.mdb");
        private void button1_Click(object sender, EventArgs e)
        {
            if (baglantik.State == ConnectionState.Closed)
            {
                serap();
                baglantik.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baglantik;
                cmd.CommandText = "INSERT INTO ameliyat(ad,soyad,tc,ameliyatt) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "')";
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglantik.Close();

                MessageBox.Show("hasta kayıdı tamamlanmıştır");
            }
        }
        void serap()
        {
            if (baglantik.State == ConnectionState.Closed)
            {
                baglantik.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baglantik;
                cmd.CommandText = "select *from ameliyat";
                OleDbDataAdapter adpr = new OleDbDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpr.Fill(ds, "ameliyat");
                dataGridView2.DataSource = ds.Tables["ameliyat"];

                baglantik.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        OleDbConnection connect = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = hastaneoto.mdb");
        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hasta kaydını silmek istediğinize eminmisiniz", "DİKKAT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = connect;
                    cmd.CommandText = "delete from ameliyat where id=@numara";
                    cmd.Parameters.AddWithValue("@numara", dataGridView2.CurrentRow.Cells[0].Value.ToString());
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    connect.Close();
                }




            }
        }
        OleDbConnection kaan = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = hastaneoto.mdb");
        private void button4_Click(object sender, EventArgs e)
        {
            kaan.Open();
            OleDbCommand cod = new OleDbCommand("select * from ameliyat", kaan);
            OleDbDataAdapter adpn = new OleDbDataAdapter(cod);
            DataTable nj = new DataTable();
            adpn.Fill(nj);
            dataGridView2.DataSource = nj;
            kaan.Close();
        }
    }
}
              