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
    public partial class loggörüntüle : Form
    {
        public loggörüntüle()
        {
            InitializeComponent();
        }
        OleDbConnection baglantis = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = hastaneoto.mdb");
        private void button1_Click(object sender, EventArgs e)
        {
            baglantis.Open();
            OleDbCommand cod = new OleDbCommand("select * from log", baglantis);
            OleDbDataAdapter adpn = new OleDbDataAdapter(cod);
            DataTable nj = new DataTable();
            adpn.Fill(nj);
            dataGridView1.DataSource = nj;
        }
    }
}
