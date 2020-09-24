using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kronometre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int salise = Convert.ToInt32(label6.Text);
            int saniye = Convert.ToInt32(label1.Text);
            int dakika = Convert.ToInt32(label2.Text);
            salise++;
            label6.Text = salise.ToString();
            if(Convert.ToInt32(salise)==60)
            {
                salise = 0;
                label6.Text = salise.ToString();
                saniye++;
                label1.Text = saniye.ToString();
            }
            if(Convert.ToInt32(saniye)==60)
            {
                saniye = 0;
                label1.Text = saniye.ToString();
                dakika++;
                label2.Text = dakika.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(0);
            label2.Text = Convert.ToString(0);
            label6.Text = Convert.ToString(0);
            timer1.Enabled = false;
        }

        //private void timer2_Tick(object sender, EventArgs e)
        //{

        //}
    }
}
