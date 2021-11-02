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
    public partial class yönetici : Form
    {
        public yönetici()
        {
            InitializeComponent();
        }
        OleDbConnection nope = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = hastaneoto.mdb");
        private void button1_Click(object sender, EventArgs e)
        {
            nope.Open();
            OleDbCommand jale = new OleDbCommand("Select * from doktorliste where listno like '%" + textBox1.Text + "%'", nope);
            OleDbDataAdapter da = new OleDbDataAdapter(jale);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            nope.Close();
        }
    }
}
