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
    public partial class hastasevk : Form
    {
        public hastasevk()
        {
            InitializeComponent();
        }
        OleDbConnection baglantis = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = hastaneoto.mdb");
        private void button1_Click(object sender, EventArgs e)
        {
            baglantis.Open();
            OleDbCommand cod = new OleDbCommand("select * from konsültasyon", baglantis);
            OleDbDataAdapter adpn = new OleDbDataAdapter(cod);
            DataTable nj = new DataTable();
            adpn.Fill(nj);
            dataGridView1.DataSource = nj;
            baglantis.Close();
            dataGridView1.Columns[0].Visible = false;
            
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
        }
        public void verilerigöster(string veriler)
        {
            OleDbDataAdapter da = new OleDbDataAdapter(veriler, baglantis);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }            
            

        private void hastasevk_Load(object sender, EventArgs e)
        {
            label5.Text = Form1.sa.ToString();
            label6.Text = Form1.ur.ToString();




        }
        OleDbConnection tersane = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = hastaneoto.mdb");
        private void button2_Click(object sender, EventArgs e)
        {

            baglantis.Open();
            tersane.Open();
            OleDbCommand jery = new OleDbCommand(" update konsültasyon set doktoru='"+textBox2.Text+"',poliklinik='"+textBox3.Text+"' where doktoru='"+textBox2.Text+"'",baglantis);
            jery.ExecuteNonQuery();
            
          
            tersane.Close();
            baglantis.Close();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int seçilialan = dataGridView1.SelectedCells[0].RowIndex;
            string doktoru = dataGridView1.Rows[seçilialan].Cells[1].Value.ToString();
            string poliklinik = dataGridView1.Rows[seçilialan].Cells[10].Value.ToString();
            string bölüm = dataGridView1.Rows[seçilialan].Cells[7].Value.ToString();

            textBox1.Text = doktoru;
            textBox2.Text = poliklinik;
            textBox3.Text = bölüm;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
