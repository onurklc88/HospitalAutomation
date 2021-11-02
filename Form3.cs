using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hastaneotomasyon
{
    public partial class Form3 : Form
    {
        
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
          
        }
        SqlConnection lale = new SqlConnection("Data Source =DESKTOP-39A1GHA\\CROSSSQL; Initial Catalog = hastaneoto; Integrated Security = True");
        private void button1_Click(object sender, EventArgs e)
        {
            lale.Open();
            SqlCommand komut = new SqlCommand("select * from randevu",lale);
            SqlDataAdapter adpr = new SqlDataAdapter(komut);
            DataTable tb = new DataTable();
            adpr.Fill(tb);
            dataGridView1.DataSource = tb;



        }
        SqlConnection demir = new SqlConnection("Data Source =DESKTOP-39A1GHA\\CROSSSQL; Initial Catalog = hastaneoto; Integrated Security = True");
        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
        }

    
  
    
    
    
        

