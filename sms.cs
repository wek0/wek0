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
    public partial class sms : Form
    {
        public sms()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (WebClient client = new WebClient())
            {
                byte[] response = client.UploadValues("http://textbelt.com/text", new NameValueCollection() {
    { "phone", textBox1.Text },
    { "message", textBox2.Text },
    { "key", "textbelt" },
  });

                string result = System.Text.Encoding.UTF8.GetString(response);
                textBox3.Text = result;
            }
        }
    }
}
