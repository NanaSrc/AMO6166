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
        love lov;
        public ProgressBar(string user, string log)
        {
            InitializeComponent();
            username = user;
            login = log;
            lov = new love(username, login);
        }

        private void ProgressBar_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true; // Enable the timer.
            timer1.Start();//Strart it
            timer1.Interval = 800; // The time per tick.
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
                    lbLoading.Text = "☆ Drink water." /*+
                        Environment.NewLine +
                        Environment.NewLine +
                        "After Eating Fish"*/;
                    //fish1.Visible = true;
                    label2.Visible = true;
                    break;
                //10
                case "<//                   >":
                    lbBar.Text = "<////                 >";
                    lbLoading.Text = "☆ Drink water..";
                    //label1.Visible = true;
                    //fish2.Visible = true;
                    //fish1.Visible = false;
                    break;
                //20
                case "<////                 >":
                    lbBar.Text = "<//////               >";
                    lbLoading.Text = "☆ Feeding monkeys...";
                    //label1.Visible = false;
                    label2.Visible = false;
                    //fish2.Visible = false;
                    //fish3.Visible = true;
                    break;
                //30
                case "<//////               >":
                    lbBar.Text = "<////////             >";
                    lbLoading.Text = "☆ Feeding monkeys.";
                    //fish3.Visible = false;
                    //fish4.Visible = true;
                    break;
                //40
                case "<////////             >":
                    lbBar.Text = "<//////////           >";
                    lbLoading.Text = "☆ Loving Marco..";
                    //fish4.Visible = false;
                    //fish5.Visible = true;
                    break;
                //50
                case "<//////////           >":
                    lbBar.Text = "<////////////         >";
                    lbLoading.Text = "☆ Loving Nana...";
                    //fish5.Visible = false;
                    //fish6.Visible = true;
                    break;
                //60
                case "<////////////         >":
                    lbBar.Text = "<//////////////       >";
                    lbLoading.Text = "☆ Cleaning Windows.";
                    //fish6.Visible = false;
                    break;
                //70
                case "<//////////////       >":
                    lbBar.Text = "<////////////////     >";
                    lbLoading.Text = "☆ Cleaning Windows.. "/* +
                        Environment.NewLine +
                        "(yes I said windows b****)"*/;
                    //label1.TextAlign = ContentAlignment.MiddleCenter;
                    //label1.Text = "yes I said windows b****";
                    //label1.Visible = true;
                    break;
                //80
                case "<////////////////     >":
                    lbBar.Text = "<//////////////////   >";
                    lbLoading.Text = "☆ Hating Linux...";
                   //label1.Visible = false;
                    break;
                //90
                case "<//////////////////   >":
                    lbBar.Text = "<//////////////////// >";
                    lbLoading.Text = "☆ Opening doors.";
                    break;
                //99
                case "<//////////////////// >":
                    lbBar.Text = "</////////////////////>";
                    lbLoading.Text = "☆ Opening doors..";
                    break;
                //100
                case "</////////////////////>":
                    lbLoading.Text = "☆ Opening doors...";
                    break;
            }
        }

        private void lbBar_TextChanged(object sender, EventArgs e)
        {
            /*if (lbBar.Text == "<//////////           >")
            {
                lov.ShowDialog();
                lov.SendToBack();
                BringToFront();
            }
            else */
            if (lbBar.Text == "</////////////////////>")
            {
                Hide();
                Close();
                timer1.Stop();
                lov.ShowDialog();
                lov.BringToFront();
                //Hide();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Congrats! Now you have a fish in ur stomach :)");
            
        }
    }
}
