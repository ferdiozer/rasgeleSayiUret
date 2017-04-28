using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rasgele_sayi_uret_RANDOM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            

            try
            {
                Random rasgele = new Random();
                int sayi = rasgele.Next(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text) + 1);
                label2.Text=sayi.ToString();
                label2.Visible = true;
            }
            catch
            {

                MessageBox.Show("Geçerli değer girin");
               
            }
           
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Visible = false;
        }
    }
}
