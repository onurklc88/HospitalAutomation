using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastaneotomasyon
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();
            frm6.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            doktorekle dktr = new doktorekle();
            dktr.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form8 frm8 = new Form8();
            frm8.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form9 fmr9 = new Form9();
            fmr9.Show();

            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            konsültasyon knst = new konsültasyon();
            knst.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            poliklinikler plk = new poliklinikler();
            plk.Show();
            this.Hide();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            polikhasta poli = new polikhasta();
            poli.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form10 frm10 = new Form10();
            frm10.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            loggörüntüle log = new loggörüntüle();
            log.Show();
        }
    }
}
