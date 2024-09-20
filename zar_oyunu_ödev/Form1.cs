using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zar_oyunu_ödev
{
    public partial class Form1 : Form
    {
        int sayac;
    
        public Form1()
        {
            
            InitializeComponent();
        }

       
        private void btnzarlarıat_Click(object sender, EventArgs e)
        {
            timer1.Start();
            btnzarlarıat.Enabled = false;
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            int zar1, zar2;
            Random rnd = new Random();
            zar1 = rnd.Next(0, 5);
            zar2 = rnd.Next(0, 5);
            pb1.Image = ımageList1.Images[zar1];
            pb2.Image = ımageList1.Images[zar2];
            txtzar1.Text = (zar1 + 1).ToString();
            txtzar2.Text = (zar2 + 1).ToString();
            sayac++;
            if (sayac == 10)
            {
                timer1.Stop();
                sayac = 0;
                btnzarlarıat.Enabled = true;
                
            }
        }

        private void btnskoraekle_Click(object sender, EventArgs e)
        {
            if (o1rdb.Checked == true)
            {
                listBox1.Items.Add(txtzar1.Text + " " + txtzar2.Text);
                txto1skor.Text = (Convert.ToInt32(txto1skor.Text)+Convert.ToInt32(txtzar1.Text) + Convert.ToInt32(txtzar2.Text)).ToString();
            }
            else
            {
                listBox2.Items.Add(txtzar1.Text + " " + txtzar2.Text);
                txto2skor.Text = (Convert.ToInt32(txto2skor.Text) + Convert.ToInt32(txtzar1.Text) + Convert.ToInt32(txtzar2.Text)).ToString();
            }
           
        }
    }
}
