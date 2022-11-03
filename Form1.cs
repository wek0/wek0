using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;
namespace dumphub
{
    public partial class Form1 : Form
    {
   
        private int _ticks;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
      


           // SoundPlayer sound = new SoundPlayer("Sound1.wav");
            //sound.PlaySync();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _ticks++;
            this.Text = _ticks.ToString();

            if (_ticks == 20)
            {
                timer1.Stop();

                Form2 fm2 = new Form2();
                this.Hide();
                Thread.Sleep(1000);
                fm2.Show();
            }   
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
