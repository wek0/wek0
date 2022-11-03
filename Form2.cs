using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu;
using System;
using System.Collections.Specialized;
using System.Net;


namespace dumphub
{
    public partial class Form2 : Form
    {
   
        public Form2()
        {
            InitializeComponent();
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Logo.Text = "Paraply - Welcome ";
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sms fm2 = new sms();
            fm2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
         



        }
    }
}
    
