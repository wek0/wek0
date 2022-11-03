using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;

namespace dumphub
{
  public  class Program : Form
    {

        public static Program instantce;
        [DllImport("kernel32.dll")]

        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int CmdShow);

       const int SW_HIDE = 0;
        //const int SW_SHOW = 5;


        static void Main(string[] args)
        {
            Start:
            string HWID;
            HWID = System.Security.Principal.WindowsIdentity.GetCurrent().User.Value;
            string test = HWID;
            Console.WriteLine("Welcome");
            Console.WriteLine("If you are not a user off this group please close this program");
            Console.WriteLine("");
            Console.WriteLine("Your computer id:" + HWID);
            Console.WriteLine("");
            Console.Write("Enter your username: ");
            var username = Console.ReadLine();

            WebClient web = new WebClient();

            string checker = test + ":" + username;
            Boolean login1 = web.DownloadString("https://pastebin.com/raw/mPHGYdV5").Contains(checker);

            if (test == "")
                login1 = false;

            if (username == "")
                login1 = false;



            if (login1 == true)
            {

                Console.Clear();

                Console.WriteLine("WELCOME " + username);

                Thread.Sleep(1000);


                IntPtr hWnd = GetConsoleWindow();
                ShowWindow(hWnd, SW_HIDE);


                Thread.Sleep(1000);

                //   var handle = GetConsoleWindow();
                
                Application.Run(new Form1());
                // ShowWindow(handle, SW_HIDE);

                // Form2.instantce.ddd = username;
              
            }

            else
            {
                Console.WriteLine("Wrong login.");
                Console.ReadLine();
                goto Start;


            }



        }

        private void InitializeComponent()
        {
            instantce = this;
            this.SuspendLayout();
            // 
            // Program
            // 
            this.ClientSize = new System.Drawing.Size(1033, 580);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Program";
            this.Load += new System.EventHandler(this.Program_Load);
            this.ResumeLayout(false);
           
        }

        private void Program_Load(object sender, EventArgs e)
        {

        }
    }
}
