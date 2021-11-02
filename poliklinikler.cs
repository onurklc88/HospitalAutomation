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
    public partial class poliklinikler : Form
    {
        public poliklinikler()
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
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
        }

        private void poliklinikler_Load(object sender, EventArgs e)
        {

        }
    }
}
