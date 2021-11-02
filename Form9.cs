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
    public partial class Form9 : Form
    {
        public Form9()
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


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
