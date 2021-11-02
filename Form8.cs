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
    //DB BAĞLANTI
    public partial class Form8 : Form
    {
       OleDbConnection agla = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=hastaneoto.mdb");
        public Form8()
        {
            InitializeComponent();
        }
        public string ConnectionString
        {
            get { return "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=hastaneoto.mdb"; }
        }


        private void Form8_Load(object sender, EventArgs e)
        {
            
           

  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (agla.State == ConnectionState.Closed)
            {
                agla.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = agla;
                cmd.CommandText = "INSERT INTO hastadoya(ismi,soyisim,tc,tarih,babadi,anneadi,kanGrubu,cinsiyet,adres,medenihal,telefon) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','"+textBox6.Text+"','"+textBox5.Text+"','" + comboBox2.Text + "','"+comboBox1.Text+"','"+textBox7.Text+"','"+comboBox3.Text+"','"+textBox8.Text+"')";
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                agla.Close();
                serap();
                MessageBox.Show("Randevu kayıdı tamamlanmıştır");
            }
        }
        void serap()
        {
            if (agla.State == ConnectionState.Closed)
            {
                agla.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = agla;
                cmd.CommandText = "select * from hastadoya";
                OleDbDataAdapter adpr = new OleDbDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpr.Fill(ds, "hastadoya");
                dataGridView1.DataSource = ds.Tables["hastadoya"];
                
                agla.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Randevu kaydını silmek istediğinizden eminmisiniz?", "DİKKAT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (agla.State == ConnectionState.Closed)
                {
                    agla.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = agla;
                    cmd.CommandText = "delete from hastadoya where dosyano=@numara";
                    cmd.Parameters.AddWithValue("@numara", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    agla.Close();
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

    
    

