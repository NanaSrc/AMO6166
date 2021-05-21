using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace amo6166
{
    public partial class ProgressBar : MetroFramework.Forms.MetroForm
    {
        string username;
        string login;
        public ProgressBar(string user, string log)
        {
            InitializeComponent();
            username = user;
            login = log;
        }

        private void ProgressBar_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true; // Enable the timer.
            timer1.Start();//Strart it
            timer1.Interval = 1000; // The time per tick.
            timer1.Tick += new EventHandler(timer1_Tick);

            //lbBar.Text = "</////////////////////>";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string load = lbBar.Text;

            switch (load)
            {
                //0
                case "<                     >":
                    lbBar.Text = "<//                   >";
                    break;
                //10
                case "<//                   >":
                    lbBar.Text = "<////                 >";
                    break;
                //20
                case "<////                 >":
                    lbBar.Text = "<//////               >";
                    break;
                //30
                case "<//////               >":
                    lbBar.Text = "<////////             >";
                    break;
                //40
                case "<////////             >":
                    lbBar.Text = "<//////////           >";
                    break;
                //50
                case "<//////////           >":
                    lbBar.Text = "<////////////         >";
                    break;
                //60
                case "<////////////         >":
                    lbBar.Text = "<//////////////       >";
                    break;
                //70
                case "<//////////////       >":
                    lbBar.Text = "<////////////////     >";
                    break;
                //80
                case "<////////////////     >":
                    lbBar.Text = "<//////////////////   >";
                    break;
                //90
                case "<//////////////////   >":
                    lbBar.Text = "<//////////////////// >";
                    break;
                //99
                case "<//////////////////// >":
                    lbBar.Text = "</////////////////////>";
                    break;
                //100
                case "</////////////////////>":
                    this.Hide();
                    love lov = new love(username, login);
                    timer1.Stop();
                    lov.ShowDialog();
                    this.Close();
                    break;
            }
        }

        private void lbBar_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
