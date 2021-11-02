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
    public partial class Form10 : Form
    {

        public Form10()
        {
            InitializeComponent();
        }


        OleDbConnection baglantik = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=hastaneoto.mdb");
        private void button1_Click(object sender, EventArgs e)
        {
            if (baglantik.State == ConnectionState.Closed)
            {
                baglantik.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baglantik;
                cmd.CommandText = "INSERT INTO bilgislem(k_adi,soyad,sifre) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglantik.Close();
                serap();
                MessageBox.Show("Kayıt alınmıştır");
            }
        }
        void serap()
        {
            if (baglantik.State == ConnectionState.Closed)
            {
                baglantik.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baglantik;
                cmd.CommandText = "select * from bilgislem";
                OleDbDataAdapter adpr = new OleDbDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpr.Fill(ds, "bilgislem");
                dataGridView1.DataSource = ds.Tables["bilgislem"];

                baglantik.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çalışan kaydını silmek istediğinize eminmisiniz", "DİKKAT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (baglantik.State == ConnectionState.Closed)
                {
                    baglantik.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = baglantik;
                    cmd.CommandText = "delete from bilgislem where k_adi=@numara";
                    cmd.Parameters.AddWithValue("@numara", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    baglantik.Close();
                   serap();


                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
    


    
            