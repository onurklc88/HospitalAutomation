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

    public partial class doktorekle : Form
    {
        OleDbConnection bagla = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=hastaneoto.mdb");
        public doktorekle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bagla.State == ConnectionState.Closed)
            {
                bagla.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = bagla;
                cmd.CommandText = "INSERT INTO doktorliste(k_adi,soyad,sifre,bölüm,ünvan,listno) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" +textBox3.Text+ "','"+comboBox1.Text+"','"+comboBox2.Text+"','"+textBox4.Text+"')";
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                bagla.Close();
                serap();
                MessageBox.Show("Çalışan kayıdı tamamlanmıştır");
            }
        }
        void serap()
        {
            if (bagla.State == ConnectionState.Closed)
            {
                bagla.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = bagla;
                cmd.CommandText = "select * from doktorliste";
                OleDbDataAdapter adpr = new OleDbDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpr.Fill(ds, "doktorliste");
                dataGridView1.DataSource = ds.Tables["doktorliste"];
                
                bagla.Close();
            }
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            serap();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çalışan kaydını silmek istediğinize eminmisiniz", "DİKKAT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (bagla.State == ConnectionState.Closed)
                {
                    bagla.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = bagla;
                    cmd.CommandText = "delete from doktorliste where k_adi=@numara";
                    cmd.Parameters.AddWithValue("@numara", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    bagla.Close();
                    serap();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çalışan kaydını silmek istediğinize eminmisiniz", "DİKKAT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (bagla.State == ConnectionState.Closed)
                {
                    bagla.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = bagla;
                    cmd.CommandText = "delete from doktorliste where k_adi=@numara";
                    cmd.Parameters.AddWithValue("@numara", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    bagla.Close();
                    serap();
                }
            }
        }
    }
    }

